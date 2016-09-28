---
title: "choice::choice Constructor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "agents/concurrency::choice::choice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "choice, constructor"
ms.assetid: eb16dc20-0681-4b78-8c11-a19fa1106a28
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice::choice Constructor
Constructs a `choice` messaging block.  
  
## Syntax  
  
```  
explicit choice(  
   _Type _Tuple  
);  
  
choice(  
   Scheduler& _PScheduler,  
   _Type _Tuple  
);  
  
choice(  
   ScheduleGroup& _PScheduleGroup,  
   _Type _Tuple  
);  
  
choice(  
   choice && _Choice  
);  
```  
  
#### Parameters  
 `_Tuple`  
 A `tuple` of sources for the choice.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `choice` messaging block is scheduled.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `choice` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
 `_Choice`  
 A `choice` messaging block to copy from. Note that the original object is orphaned, making this a move constructor.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PScheduleGroup` parameters.  
  
 Move construction is not performed under a lock, which means that it is up to the user to make sure that there are no light-weight tasks in flight at the time of moving. Otherwise, numerous races can occur, leading to exceptions or inconsistent state.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)
---
title: "multitype_join::multitype_join Constructor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - agents/concurrency::multitype_join::multitype_join
dev_langs: 
  - C++
helpviewer_keywords: 
  - multitype_join, constructor
ms.assetid: d0fbafa3-b73f-4ba2-90e1-6fcc8bc4e387
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multitype_join::multitype_join Constructor
Constructs a `multitype_join` messaging block.  
  
## Syntax  
  
```  
explicit multitype_join(  
   _Type _Tuple  
);  
  
multitype_join(  
   Scheduler& _PScheduler,  
   _Type _Tuple  
);  
  
multitype_join(  
   ScheduleGroup& _PScheduleGroup,  
   _Type _Tuple  
);  
  
multitype_join(  
   multitype_join && _Join  
);  
```  
  
#### Parameters  
 `_Tuple`  
 A `tuple` of sources for this `multitype_join` messaging block.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `multitype_join` messaging block is scheduled.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `multitype_join` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
 `_Join`  
 A `multitype_join` messaging block to copy from. Note that the original object is orphaned, making this a move constructor.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PScheduleGroup` parameters.  
  
 Move construction is not performed under a lock, which means that it is up to the user to make sure that there are no light-weight tasks in flight at the time of moving. Otherwise, numerous races can occur, leading to exceptions or inconsistent state.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multitype_join Class](../vs140/multitype_join-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)
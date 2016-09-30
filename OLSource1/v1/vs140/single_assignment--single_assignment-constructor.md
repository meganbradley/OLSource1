---
title: "single_assignment::single_assignment Constructor"
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
  - "agents/concurrency::single_assignment::single_assignment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "single_assignment, constructor"
ms.assetid: dca350a1-5071-4d44-8806-47f3fca1ef67
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::single_assignment Constructor
Constructs a `single_assignment` messaging block.  
  
## Syntax  
  
```  
single_assignment();  
  
single_assignment(  
   filter_method const& _Filter  
);  
  
single_assignment(  
   Scheduler& _PScheduler  
);  
  
single_assignment(  
   Scheduler& _PScheduler,  
   filter_method const& _Filter  
);  
  
single_assignment(  
   ScheduleGroup& _PScheduleGroup  
);  
  
single_assignment(  
   ScheduleGroup& _PScheduleGroup,  
   filter_method const& _Filter  
);  
```  
  
#### Parameters  
 `_Filter`  
 A filter function which determines whether offered messages should be accepted.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `single_assignment` messaging block is scheduled.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `single_assignment` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PScheduleGroup` parameters.  
  
 The type `filter_method` is a functor with signature `bool (_Type const &)` which is invoked by this `single_assignment` messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_assignment Class](../vs140/single_assignment-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)
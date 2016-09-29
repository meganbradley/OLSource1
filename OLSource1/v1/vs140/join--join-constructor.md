---
title: "join::join Constructor"
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
  - "agents/concurrency::join::join"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "join, constructor"
ms.assetid: 36177ccb-7de9-41e4-b710-73e2da533d80
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# join::join Constructor
Constructs a `join` messaging block.  
  
## Syntax  
  
```  
join(  
   size_t _NumInputs  
);  
  
join(  
   size_t _NumInputs,  
   filter_method const& _Filter  
);  
  
join(  
   Scheduler& _PScheduler,  
   size_t _NumInputs  
);  
  
join(  
   Scheduler& _PScheduler,  
   size_t _NumInputs,  
   filter_method const& _Filter  
);  
  
join(  
   ScheduleGroup& _PScheduleGroup,  
   size_t _NumInputs  
);  
  
join(  
   ScheduleGroup& _PScheduleGroup,  
   size_t _NumInputs,  
   filter_method const& _Filter  
);  
```  
  
#### Parameters  
 `_NumInputs`  
 The number of inputs this `join` block will be allowed.  
  
 `_Filter`  
 A filter function which determines whether offered messages should be accepted.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `join` messaging block is scheduled.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `join` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PScheduleGroup` parameters.  
  
 The type `filter_method` is a functor with signature `bool (_Type const &)` which is invoked by this `join` messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [join Class](../vs140/join-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)
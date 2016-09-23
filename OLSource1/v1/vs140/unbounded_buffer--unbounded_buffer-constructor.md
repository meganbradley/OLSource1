---
title: "unbounded_buffer::unbounded_buffer Constructor"
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
  - agents/concurrency::unbounded_buffer::unbounded_buffer
dev_langs: 
  - C++
helpviewer_keywords: 
  - unbounded_buffer, constructor
ms.assetid: 7608f40b-af72-49a6-8173-541ad9cfa4ce
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unbounded_buffer::unbounded_buffer Constructor
Constructs an `unbounded_buffer` messaging block.  
  
## Syntax  
  
```  
unbounded_buffer();  
  
unbounded_buffer(  
   filter_method const& _Filter  
);  
  
unbounded_buffer(  
   Scheduler& _PScheduler  
);  
  
unbounded_buffer(  
   Scheduler& _PScheduler,  
   filter_method const& _Filter  
);  
  
unbounded_buffer(  
   ScheduleGroup& _PScheduleGroup  
);  
  
unbounded_buffer(  
   ScheduleGroup& _PScheduleGroup,  
   filter_method const& _Filter  
);  
```  
  
#### Parameters  
 `_Filter`  
 A filter function which determines whether offered messages should be accepted.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `unbounded_buffer` messaging block is scheduled.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `unbounded_buffer` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PScheduleGroup` parameters.  
  
 The type `filter_method` is a functor with signature `bool (_Type const &)` which is invoked by this `unbounded_buffer` messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [unbounded_buffer Class](../vs140/unbounded_buffer-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)
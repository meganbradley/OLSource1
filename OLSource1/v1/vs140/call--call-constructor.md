---
title: "call::call Constructor"
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
  - "agents/concurrency::call::call"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "call, constructor"
ms.assetid: 8fa34cc5-8c85-4240-a989-dbabb63bfb3d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# call::call Constructor
Constructs a `call` messaging block.  
  
## Syntax  
  
```  
call(  
   _Call_method const& _Func  
);  
  
call(  
   _Call_method const& _Func,  
   filter_method const& _Filter  
);  
  
call(  
   Scheduler& _PScheduler,  
   _Call_method const& _Func  
);  
  
call(  
   Scheduler& _PScheduler,  
   _Call_method const& _Func,  
   filter_method const& _Filter  
);  
  
call(  
   ScheduleGroup& _PScheduleGroup,  
   _Call_method const& _Func  
);  
  
call(  
   ScheduleGroup& _PScheduleGroup,  
   _Call_method const& _Func,  
   filter_method const& _Filter  
);  
```  
  
#### Parameters  
 `_Func`  
 A function that will be invoked for each accepted message.  
  
 `_Filter`  
 A filter function which determines whether offered messages should be accepted.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `call` messaging block is scheduled.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `call` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PScheduleGroup` parameters.  
  
 The type `_Call_method` is a functor with signature `void (_Type const &)` which is invoked by this `call` messaging block to process a message.  
  
 The type `filter_method` is a functor with signature `bool (_Type const &)` which is invoked by this `call` messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [call Class](../vs140/call-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)
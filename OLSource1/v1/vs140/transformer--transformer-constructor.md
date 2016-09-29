---
title: "transformer::transformer Constructor"
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
  - "agents/concurrency::transformer::transformer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transformer, constructor"
ms.assetid: 163a9b9f-91b8-4cbf-95ff-1103b71e25b4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# transformer::transformer Constructor
Constructs a `transformer` messaging block.  
  
## Syntax  
  
```  
transformer(  
   _Transform_method const& _Func,  
   _Inout_opt_ ITarget<_Output> * _PTarget = NULL  
);  
  
transformer(  
   _Transform_method const& _Func,  
   _Inout_opt_ ITarget<_Output> * _PTarget,  
   filter_method const& _Filter  
);  
  
transformer(  
   Scheduler& _PScheduler,  
   _Transform_method const& _Func,  
   _Inout_opt_ ITarget<_Output> * _PTarget = NULL  
);  
  
transformer(  
   Scheduler& _PScheduler,  
   _Transform_method const& _Func,  
   _Inout_opt_ ITarget<_Output> * _PTarget,  
   filter_method const& _Filter  
);  
  
transformer(  
   ScheduleGroup& _PScheduleGroup,  
   _Transform_method const& _Func,  
   _Inout_opt_ ITarget<_Output> * _PTarget = NULL  
);  
  
transformer(  
   ScheduleGroup& _PScheduleGroup,  
   _Transform_method const& _Func,  
   _Inout_opt_ ITarget<_Output> * _PTarget,  
   filter_method const& _Filter  
);  
```  
  
#### Parameters  
 `_Func`  
 A function that will be invoked for each accepted message.  
  
 `_PTarget`  
 A pointer to a target block to link with the transformer.  
  
 `_Filter`  
 A filter function which determines whether offered messages should be accepted.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `transformer` messaging block is scheduled.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `transformer` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PScheduleGroup` parameters.  
  
 The type `_Transform_method` is a functor with signature `_Output (_Input const &)` which is invoked by this `transformer` messaging block to process a message.  
  
 The type `filter_method` is a functor with signature `bool (_Input const &)` which is invoked by this `transformer` messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [transformer Class](../vs140/transformer-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)
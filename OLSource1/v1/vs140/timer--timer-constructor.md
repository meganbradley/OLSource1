---
title: "timer::timer Constructor"
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
  - "agents/concurrency::timer::timer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "timer, constructor"
ms.assetid: bb972fd8-24ec-4640-83b6-12fd58209e98
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timer::timer Constructor
Constructs a `timer` messaging block that will fire a given message after a specified interval.  
  
## Syntax  
  
```  
timer(  
   unsigned int _Ms,  
   _Type const& _Value,  
   ITarget<_Type> *_PTarget = NULL,  
   bool _Repeating = false  
);  
  
timer(  
   Scheduler& _Scheduler,  
   unsigned int _Ms,  
   _Type const& _Value,  
   _Inout_opt_ ITarget<_Type> *_PTarget = NULL,  
   bool _Repeating = false  
);  
  
timer(  
   ScheduleGroup& _ScheduleGroup,  
   unsigned int _Ms,  
   _Type const& _Value,  
   _Inout_opt_ ITarget<_Type> *_PTarget = NULL,  
   bool _Repeating = false  
);  
```  
  
#### Parameters  
 `_Ms`  
 The number of milliseconds that must elapse after the call to start for the specified message to be propagated downstream.  
  
 `_Value`  
 The value which will be propagated downstream when the timer elapses.  
  
 `_PTarget`  
 The target to which the timer will propagate its message.  
  
 `_Repeating`  
 If true, indicates that the timer will fire periodically every `_Ms` milliseconds.  
  
 `_Scheduler`  
 The `Scheduler` object within which the propagation task for the `timer` messaging block is scheduled is scheduled.  
  
 `_ScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `timer` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_Scheduler` or `_ScheduleGroup` parameters.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [timer Class](../vs140/timer-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)
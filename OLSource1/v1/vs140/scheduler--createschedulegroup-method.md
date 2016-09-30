---
title: "Scheduler::CreateScheduleGroup Method"
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
  - "concrt/concurrency::Scheduler::CreateScheduleGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateScheduleGroup method"
ms.assetid: d0daf471-0608-4c33-8625-58f5636c863a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::CreateScheduleGroup Method
Creates a new schedule group within the scheduler. The version that takes the parameter `_Placement` causes tasks within the newly created schedule group to be biased towards executing at the location specified by that parameter.  
  
## Syntax  
  
```  
virtual ScheduleGroup * CreateScheduleGroup() =0;  
  
virtual ScheduleGroup * CreateScheduleGroup(  
   location& _Placement  
) =0;  
```  
  
#### Parameters  
 `_Placement`  
 A reference to a location where the tasks within the schedule group will biased towards executing at.  
  
## Return Value  
 A pointer to the newly created schedule group. This `ScheduleGroup` object has an initial reference count placed on it.  
  
## Remarks  
 You must invoke the [Release](../vs140/schedulegroup--release-method.md) method on a schedule group when you are done scheduling work to it. The scheduler will destroy the schedule group when all work queued to it has completed.  
  
 Note that if you explicitly created this scheduler, you must release all references to schedule groups within it, before you release your references on the scheduler.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)   
 [ScheduleGroup::Release Method](../vs140/schedulegroup--release-method.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)   
 [location Class](../vs140/location-class.md)
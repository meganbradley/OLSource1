---
title: "CurrentScheduler::CreateScheduleGroup Method"
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
  - "concrt/concurrency::CurrentScheduler::CreateScheduleGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateScheduleGroup method"
ms.assetid: ddc4170f-ca00-4d15-81df-a4980a2352ed
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CurrentScheduler::CreateScheduleGroup Method
Creates a new schedule group within the scheduler associated with the calling context. The version that takes the parameter `_Placement` causes tasks within the newly created schedule group to be biased towards executing at the location specified by that parameter.  
  
## Syntax  
  
```  
static ScheduleGroup * __cdecl CreateScheduleGroup();  
  
static ScheduleGroup * __cdecl CreateScheduleGroup(  
   location& _Placement  
);  
```  
  
#### Parameters  
 `_Placement`  
 A reference to a location where the tasks within the schedule group will be biased towards executing at.  
  
## Return Value  
 A pointer to the newly created schedule group. This `ScheduleGroup` object has an initial reference count placed on it.  
  
## Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
 You must invoke the [Release](../vs140/schedulegroup--release-method.md) method on a schedule group when you are done scheduling work to it. The scheduler will destroy the schedule group when all work queued to it has completed.  
  
 Note that if you explicitly created this scheduler, you must release all references to schedule groups within it, before you release your reference on the scheduler, by detaching the current context from it.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)   
 [ScheduleGroup::Release Method](../vs140/schedulegroup--release-method.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)   
 [location Class](../vs140/location-class.md)
---
title: "ScheduleGroup::Reference Method"
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
  - "concrt/concurrency::ScheduleGroup::Reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reference method"
ms.assetid: df0182d7-1fdd-4b1f-b4a8-9852aead7fe5
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ScheduleGroup::Reference Method
Increments the schedule group reference count.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The newly incremented reference count.  
  
## Remarks  
 This is typically used to manage the lifetime of the schedule group for composition. When the reference count of a schedule group falls to zero, the schedule group is deleted by the runtime. A schedule group created using either the [CurrentScheduler::CreateScheduleGroup](../vs140/currentscheduler--createschedulegroup-method.md) method, or the [Scheduler::CreateScheduleGroup](../vs140/scheduler--createschedulegroup-method.md) method starts out with a reference count of one.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)   
 [ScheduleGroup::Release Method](../vs140/schedulegroup--release-method.md)   
 [CurrentScheduler::CreateScheduleGroup Method](../vs140/currentscheduler--createschedulegroup-method.md)   
 [Scheduler::CreateScheduleGroup Method](../vs140/scheduler--createschedulegroup-method.md)
---
title: "Scheduler::ScheduleTask Method"
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
  - "concrt/concurrency::Scheduler::ScheduleTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ScheduleTask method"
ms.assetid: f2afd40c-206e-4e00-a582-f430d0e1ef3b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::ScheduleTask Method
Schedules a light-weight task within the scheduler. The light-weight task will be placed in a schedule group determined by the runtime. The version that takes the parameter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> causes the task to be biased towards executing at the specified location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the function to execute to perform the body of the light-weight task.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A void pointer to the data that will be passed as a parameter to the body of the task.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to a location where the light-weight task will be biased towards executing at.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)   
 [location Class](../vs140/location-class.md)
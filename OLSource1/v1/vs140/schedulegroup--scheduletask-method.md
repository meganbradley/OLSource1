---
title: "ScheduleGroup::ScheduleTask Method"
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
  - "concrt/concurrency::ScheduleGroup::ScheduleTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ScheduleTask method"
ms.assetid: 82be91e6-a641-4cec-b2f3-a99281b3fd66
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ScheduleGroup::ScheduleTask Method
Schedules a light-weight task within the schedule group.  
  
## Syntax  
  
```  
virtual void ScheduleTask(  
   TaskProc _Proc,  
   _Inout_opt_ void * _Data  
) =0;  
```  
  
#### Parameters  
 `_Proc`  
 A pointer to the function to execute to perform the body of the light-weight task.  
  
 `_Data`  
 A void pointer to the data that will be passed as a parameter to the body of the task.  
  
## Remarks  
 Calling the `ScheduleTask` method implicitly places a reference count on the schedule group which is removed by the runtime at an appropriate time after the task executes.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)   
 [ScheduleGroup::Reference Method](../vs140/schedulegroup--reference-method.md)
---
title: "Scheduler::SetDefaultSchedulerPolicy Method"
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
  - "concrt/concurrency::Scheduler::SetDefaultSchedulerPolicy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultSchedulerPolicy method"
ms.assetid: 87bf9d4c-05ed-4b38-bbcd-1aaf541271d3
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::SetDefaultSchedulerPolicy Method
Allows a user defined policy to be used to create the default scheduler. This method can be called only when no default scheduler exists within the process. After a default policy has been set, it remains in effect until the next valid call to either the `SetDefaultSchedulerPolicy` or the [ResetDefaultSchedulerPolicy](../VS_csharp/scheduler--resetdefaultschedulerpolicy-method.md) method.  
  
## Syntax  
  
```  
static void __cdecl SetDefaultSchedulerPolicy(  
   const SchedulerPolicy& _Policy  
);  
```  
  
#### Parameters  
 `_Policy`  
 The policy to be set as the default scheduler policy.  
  
## Remarks  
 If the `SetDefaultSchedulerPolicy` method is called when a default scheduler already exists within the process, the runtime will throw a [default_scheduler_exists](../VS_csharp/default_scheduler_exists-class.md) exception.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../VS_csharp/scheduler-class.md)   
 [Scheduler::ResetDefaultSchedulerPolicy Method](../VS_csharp/scheduler--resetdefaultschedulerpolicy-method.md)   
 [SchedulerPolicy Class](../VS_csharp/schedulerpolicy-class.md)   
 [PolicyElementKey Enumeration](../VS_csharp/policyelementkey-enumeration.md)   
 [Task Scheduler (Concurrency Runtime)](../VS_csharp/task-scheduler--concurrency-runtime-.md)
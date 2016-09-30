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
Allows a user defined policy to be used to create the default scheduler. This method can be called only when no default scheduler exists within the process. After a default policy has been set, it remains in effect until the next valid call to either the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or the [ResetDefaultSchedulerPolicy](../vs140/scheduler--resetdefaultschedulerpolicy-method.md) method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The policy to be set as the default scheduler policy.  
  
## Remarks  
 If the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method is called when a default scheduler already exists within the process, the runtime will throw a [default_scheduler_exists](../vs140/default_scheduler_exists-class.md) exception.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Scheduler::ResetDefaultSchedulerPolicy Method](../vs140/scheduler--resetdefaultschedulerpolicy-method.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)
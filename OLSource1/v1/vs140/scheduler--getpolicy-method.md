---
title: "Scheduler::GetPolicy Method"
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
  - "concrt/concurrency::Scheduler::GetPolicy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPolicy method"
ms.assetid: db8ccac3-7b62-4321-a056-5861d2ac719b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::GetPolicy Method
Returns a copy of the policy that the scheduler was created with.  
  
## Syntax  
  
```  
virtual SchedulerPolicy GetPolicy() const =0;  
```  
  
## Return Value  
 A copy of the policy that the scheduler was created with.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)
---
title: "task::wait Method"
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
  - "ppltasks/concurrency::task::wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait method"
ms.assetid: 0b58d152-2098-477b-970e-cbbb12245284
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task::wait Method
Waits for this task to reach a terminal state. It is possible for `wait` to execute the task inline, if all of the tasks dependencies are satisfied, and it has not already been picked up for execution by a background worker.  
  
## Syntax  
  
```  
task_status wait() const;  
```  
  
## Return Value  
 A `task_status` value which could be either `completed` or `canceled`. If the task encountered an exception during execution, or an exception was propagated to it from an antecedent task, `wait` will throw that exception.  
  
## Remarks  
  
> [!IMPORTANT]
>  In a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, do not call `wait` in code that runs on the STA. Otherwise, the runtime throws [concurrency::invalid_operation](../vs140/invalid_operation-class.md) because this method blocks the current thread and can cause the app to become unresponsive. However, you can call the [concurrency::task::get](../vs140/task--get-method.md) method to receive the result of the antecedent task in a task-based continuation.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../vs140/task-class--concurrency-runtime-.md)
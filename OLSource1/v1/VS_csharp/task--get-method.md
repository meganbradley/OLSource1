---
title: "task::get Method"
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
  - "ppltasks/concurrency::task::get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get method"
ms.assetid: 487483a1-a9a1-4fe1-83ae-c3c19ce54bd0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task::get Method
Returns the result this task produced. If the task is not in a terminal state, a call to `get` will wait for the task to finish. This method does not return a value when called on a task with a `result_type` of `void`.  
  
## Syntax  
  
```  
_ReturnType get() const;  
  
void get() const;  
```  
  
## Return Value  
 The result of the task.  
  
## Remarks  
 If the task is canceled, a call to `get` will throw a [task_canceled](../VS_csharp/task_canceled-class.md) exception. If the task encountered an different exception or an exception was propagated to it from an antecedent task, a call to `get` will throw that exception.  
  
> [!IMPORTANT]
>  In a [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app, do not call [concurrency::task::wait](../VS_csharp/task--wait-method.md) or `get` (`wait` calls `get`) in code that runs on the STA. Otherwise, the runtime throws [concurrency::invalid_operation](../VS_csharp/invalid_operation-class.md) because these methods block the current thread and can cause the app to become unresponsive. However, you can call the `get` method to receive the result of the antecedent task in a task-based continuation because the result is immediately available.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../VS_csharp/task-class--concurrency-runtime-.md)
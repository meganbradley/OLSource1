---
title: "task_continuation_context::use_current Method"
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
  - "ppltasks/concurrency::task_continuation_context::use_current"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "use_current method"
ms.assetid: aa6c3f94-b440-4868-9bb0-f139b0d2bb69
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_continuation_context::use_current Method
Returns a task continuation context object that represents the current execution context.  
  
## Syntax  
  
```  
static task_continuation_context use_current();  
```  
  
## Return Value  
 The current execution context.  
  
## Remarks  
 This method captures the caller's Windows Runtime context so that continuations can be executed in the right apartment.  
  
 The value returned by `use_current` can be used to indicate to the Runtime that the continuation should execute in the captured context (STA vs MTA) regardless of whether or not the antecedent task is apartment aware. An apartment aware task is a task that unwraps a Windows Runtime `IAsyncInfo` interface, or a task that is descended from such a task.  
  
 This method is only available to Windows Store apps.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_continuation_context Class](../vs140/task_continuation_context-class.md)
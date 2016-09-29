---
title: "task_continuation_context::get_current_winrt_context Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ppltasks/concurrency::task_continuation_context::get_current_winrt_context"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_current_winrt_context"
ms.assetid: da44d4ef-44cd-49bb-b4d0-8721fa6dc976
caps.latest.revision: 10
---
# task_continuation_context::get_current_winrt_context Method
Returns a task continuation context object that represents the current WinRT thread context.  
  
## Syntax  
  
```  
static task_continuation_context get_current_winrt_context();  
```  
  
## Return Value  
 The current Windows Runtime thread context. Returns an empty task_continuation_context if called from a non-Windows Runtime context.  
  
## Remarks  
 The `get_current_winrt_context` method captures the caller's Windows Runtime thread context. It returns an empty context to non-Windows Runtime callers.  
  
 The value returned by `get_current_winrt_context` can be used to indicate to the Runtime that the continuation should execute in the apartment model of the captured context (STA vs MTA), regardless of whether the antecedent task is apartment aware. An apartment aware task is a task that unwraps a Windows Runtime `IAsyncInfo` interface, or a task that is descended from such a task.  
  
 This method is similar to the  `use_current` method, but it is also available to native C++ code without C++/CX extension support. It is intended for use by advanced users writing C++/CX-agnostic library code for both native and Windows Runtime callers. Unless you need this functionality, we recommend the `use_current` method, which is only available to C++/CX clients.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_continuation_context Class](../vs140/task_continuation_context-class.md)   
 [task_continuation_context::use_current](../vs140/task_continuation_context--use_current-method.md)
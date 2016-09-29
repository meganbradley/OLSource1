---
title: "task_continuation_context::use_default Method"
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
  - "ppltasks/concurrency::task_continuation_context::use_default"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "use_default method"
ms.assetid: 9ed467c2-6453-4ae2-b88a-b8849e966ad7
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_continuation_context::use_default Method
Creates the default task continuation context.  
  
## Syntax  
  
```  
static task_continuation_context use_default();  
```  
  
## Return Value  
 The default continuation context.  
  
## Remarks  
 The default context is used if you don't specifiy a continuation context when you call the `then` method. In Windows applications for Windows 7 and below, as well as desktop applications on Windows 8 and higher, the runtime determines where task continuations will execute. However, in a Windows Store app, the default continuation context for a continuation on an apartment aware task is the apartment where `then` is invoked.  
  
 An apartment aware task is a task that unwraps a Windows Runtime `IAsyncInfo` interface, or a task that is descended from such a task. Therefore, if you schedule a continuation on an apartment aware task in a Windows Runtime STA, the continuation will execute in that STA.  
  
 A continuation on a non-apartment aware task will execute in a context the Runtime chooses.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_continuation_context Class](../vs140/task_continuation_context-class.md)
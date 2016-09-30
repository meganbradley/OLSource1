---
title: "task_continuation_context Class"
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
  - "ppltasks/concurrency::task_continuation_context"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "task_continuation_context class"
ms.assetid: 1fb5a76a-3682-45c2-a615-8b6b527741f0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_continuation_context Class
The             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class allows you to specify where you would like a continuation to be executed. It is only useful to use this class from a Windows Store app. For non-Windows Store apps, the task continuation's execution context is determined by the runtime, and not configurable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[task_continuation_context::get_current_winrt_context](../vs140/task_continuation_context--get_current_winrt_context-method.md)|Returns a task continuation context object that represents the current winrt thread context.|  
|[task_continuation_context::use_arbitrary Method](#task_continuation_context__use_arbitrary_method)|Creates a task continuation context which allows the Runtime to choose the execution context for a continuation.|  
|[task_continuation_context::use_current Method](#task_continuation_context__use_current_method)|Returns a task continuation context object that represents the current execution context.|  
|[task_continuation_context::use_default Method](#task_continuation_context__use_default_method)|Creates the default task continuation context.|  
|[task_continuation_context::use_synchronous_execution](../vs140/task_continuation_context--use_synchronous_execution-method.md)|Returns a task continuation context object that represents the synchronous execution context.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
##  \<a name="task_continuation_context__use_arbitrary_method">\</a>  task_continuation_context::use_arbitrary Method  
 Creates a task continuation context which allows the Runtime to choose the execution context for a continuation.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A task continuation context that represents an arbitrary location.  
  
### Remarks  
 When this continuation context is used the continuation will execute in a context the runtime chooses even if the antecedent task is apartment aware.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to turn off the default behavior for a continuation on an apartment aware task created in an STA.  
  
 This method is only available to Windows Store apps.  
  
##  \<a name="task_continuation_context__use_current_method">\</a>  task_continuation_context::use_current Method  
 Returns a task continuation context object that represents the current execution context.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The current execution context.  
  
### Remarks  
 This method captures the caller's Windows Runtime context so that continuations can be executed in the right apartment.  
  
 The value returned by                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used to indicate to the Runtime that the continuation should execute in the captured context (STA vs MTA) regardless of whether or not the antecedent task is apartment aware. An apartment aware task is a task that unwraps a Windows Runtime                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface, or a task that is descended from such a task.  
  
 This method is only available to Windows Store apps.  
  
##  \<a name="task_continuation_context__use_default_method">\</a>  task_continuation_context::use_default Method  
 Creates the default task continuation context.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The default continuation context.  
  
### Remarks  
 The default context is used if you don't specifiy a continuation context when you call the                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method. In Windows applications for Windows 7 and below, as well as desktop applications on Windows 8 and higher, the runtime determines where task continuations will execute. However, in a Windows Store app, the default continuation context for a continuation on an apartment aware task is the apartment where                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is invoked.  
  
 An apartment aware task is a task that unwraps a Windows Runtime                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> interface, or a task that is descended from such a task. Therefore, if you schedule a continuation on an apartment aware task in a Windows Runtime STA, the continuation will execute in that STA.  
  
 A continuation on a non-apartment aware task will execute in a context the Runtime chooses.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task Class](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f)
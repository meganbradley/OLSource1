---
title: "task::then Method"
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
  - "ppltasks/concurrency::task::then"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "then method"
ms.assetid: 78ef0c69-1f5d-468f-b5ef-b554d8791cb7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task::then Method
Adds a continuation task to this task.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked by this task.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The continuation function to execute when this task completes. This continuation function must take as input a variable of either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the type of the result this task produces.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The task options include cancellation token, scheduler and continuation context. By default the former 3 options are inherited from the antecedent task  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The cancellation token to associate with the continuation task. A continuation task that is created without a cancellation token will inherit the token of its antecedent task.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A variable that specifies where the continuation should execute. This variable is only useful when used in a Windows Store style app. For more information, see [task_continuation_context](../vs140/task_continuation_context-class.md)  
  
## Return Value  
 The newly created continuation task. The result type of the returned task is determined by what <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns.  
  
## Remarks  
 The overloads of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that take a lambda or functor that returns a Windows::Foundation::IAsyncInfo interface, are only available to Windows Store apps.  
  
 For more information on how to use task continuations to compose asynchronous work, see [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../vs140/task-class--concurrency-runtime-.md)
---
title: "task::task Constructor"
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
  - "ppltasks/concurrency::task::task"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "task, constructor"
ms.assetid: 4737d39e-8299-4ffc-81e7-6a54599eaa2d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task::task Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the parameter from which the task is to be constructed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The parameter from which the task is to be constructed. This could be a lambda, a function object, a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, or a Windows::Foundation::IAsyncInfo if you are using tasks in your Windows Store app. The lambda or function object should be a type equivalent to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, where X can be a variable of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or a Windows::Foundation::IAsyncInfo in Windows Store apps.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The task options include cancellation token, scheduler etc  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The default constructor for a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is only present in order to allow tasks to be used within containers. A default constructed task cannot be used until you assign a valid task to it. Methods such as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will throw an [invalid_argument](../vs140/invalid_argument-class.md) exception when called on a default constructed task.  
  
 A task that is created from a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> will complete (and have its continuations scheduled) when the task completion event is set.  
  
 The version of the constructor that takes a cancellation token creates a task that can be canceled using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> the token was obtained from. Tasks created without a cancellation token are not cancelable.  
  
 Tasks created from a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interface or a lambda that returns an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface reach their terminal state when the enclosed Windows Runtime asynchronous operation or action completes. Similarly, tasks created from a lamda that returns a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> reach their terminal state when the inner task reaches its terminal state, and not when the lamda returns.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> behaves like a smart pointer and is safe to pass around by value. It can be accessed by multiple threads without the need for locks.  
  
 The constructor overloads that take a Windows::Foundation::IAsyncInfo interface or a lambda returning such an interface, are only available to Windows Store apps.  
  
 For more information, see [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../vs140/task-class--concurrency-runtime-.md)
---
title: "create_async Function"
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
  - "ppltasks/concurrency::create_async"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "create_async function"
ms.assetid: beadec39-5976-43fb-99b0-aeb9aad344fd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# create_async Function
Creates a Windows Runtime asynchronous construct based on a user supplied lambda or function object. The return type of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is one of either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> based on the signature of the lambda passed to the method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The lambda or function object from which to create a Windows Runtime asynchronous construct.  
  
## Return Value  
 An asynchronous construct represented by an IAsyncAction^, IAsyncActionWithProgress\<TProgress>^, IAsyncOperation\<TResult>^, or an IAsyncOperationWithProgress\<TResult, TProgress>^. The interface returned depends on the signature of the lambda passed into the function.  
  
## Remarks  
 The return type of the lambda determines whether the construct is an action or an operation.  
  
 Lambdas that return void cause the creation of actions. Lambdas that return a result of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> cause the creation of operations of TResult.  
  
 The lambda may also return a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> which encapsulates the aysnchronous work within itself or is the continuation of a chain of tasks that represent the asynchronous work. In this case, the lambda itself is executed inline, since the tasks are the ones that execute asynchronously, and the return type of the lambda is unwrapped to produce the asynchronous construct returned by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This implies that a lambda that returns a task\<void> will cause the creation of actions, and a lambda that returns a task\<TResult> will cause the creation of operations of TResult.  
  
 The lambda may take either zero, one or two arguments. The valid arguments are <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, in that order if both are used. A lambda without arguments causes the creation of an asynchronous construct without the capability for progress reporting. A lambda that takes a progress_reporter\<TProgress> will cause <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to return an asynchronous construct which reports progress of type TProgress each time the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method of the progress_reporter object is called. A lambda that takes a cancellation_token may use that token to check for cancellation, or pass it to tasks that it creates so that cancellation of the asynchronous construct causes cancellation of those tasks.  
  
 If the body of the lambda or function object returns a result (and not a task\<TResult>), the lamdba will be executed asynchronously within the process MTA in the context of a task the Runtime implicitly creates for it. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method will cause cancellation of the implicit task.  
  
 If the body of the lambda returns a task, the lamba executes inline, and by declaring the lambda to take an argument of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> you can trigger cancellation of any tasks you create within the lambda by passing that token in when you create them. You may also use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method on the token to cause the Runtime to invoke a callback when you call <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> on the async operation or action produced..  
  
 This function is only available to Windows Store apps.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task Class](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f)   
 [progress_reporter Class](../vs140/progress_reporter-class.md)   
 [cancelation_token Class](assetId:///f6db2bcb-013b-437b-b5b7-b01709bc4762)
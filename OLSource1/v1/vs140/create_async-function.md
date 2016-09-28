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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# create_async Function
Creates a Windows Runtime asynchronous construct based on a user supplied lambda or function object. The return type of `create_async` is one of either `IAsyncAction^`, `IAsyncActionWithProgress<TProgress>^`, `IAsyncOperation<TResult>^`, or `IAsyncOperationWithProgress<TResult, TProgress>^` based on the signature of the lambda passed to the method.  
  
## Syntax  
  
```  
template<  
   typename _Function  
>  
__declspec(  
   noinline  
) auto create_async(const _Function& _Func) -> decltype(ref new details::_AsyncTaskGeneratorThunk<_Function>(_Func));  
```  
  
#### Parameters  
 `_Function`  
 `_Func`  
 The lambda or function object from which to create a Windows Runtime asynchronous construct.  
  
## Return Value  
 An asynchronous construct represented by an IAsyncAction^, IAsyncActionWithProgress<TProgress\>^, IAsyncOperation<TResult\>^, or an IAsyncOperationWithProgress<TResult, TProgress>^. The interface returned depends on the signature of the lambda passed into the function.  
  
## Remarks  
 The return type of the lambda determines whether the construct is an action or an operation.  
  
 Lambdas that return void cause the creation of actions. Lambdas that return a result of type `TResult` cause the creation of operations of TResult.  
  
 The lambda may also return a `task<TResult>` which encapsulates the aysnchronous work within itself or is the continuation of a chain of tasks that represent the asynchronous work. In this case, the lambda itself is executed inline, since the tasks are the ones that execute asynchronously, and the return type of the lambda is unwrapped to produce the asynchronous construct returned by `create_async`. This implies that a lambda that returns a task<void\> will cause the creation of actions, and a lambda that returns a task<TResult\> will cause the creation of operations of TResult.  
  
 The lambda may take either zero, one or two arguments. The valid arguments are `progress_reporter<TProgress>` and `cancellation_token`, in that order if both are used. A lambda without arguments causes the creation of an asynchronous construct without the capability for progress reporting. A lambda that takes a progress_reporter<TProgress\> will cause `create_async` to return an asynchronous construct which reports progress of type TProgress each time the `report` method of the progress_reporter object is called. A lambda that takes a cancellation_token may use that token to check for cancellation, or pass it to tasks that it creates so that cancellation of the asynchronous construct causes cancellation of those tasks.  
  
 If the body of the lambda or function object returns a result (and not a task<TResult\>), the lamdba will be executed asynchronously within the process MTA in the context of a task the Runtime implicitly creates for it. The `IAsyncInfo::Cancel` method will cause cancellation of the implicit task.  
  
 If the body of the lambda returns a task, the lamba executes inline, and by declaring the lambda to take an argument of type `cancellation_token` you can trigger cancellation of any tasks you create within the lambda by passing that token in when you create them. You may also use the `register_callback` method on the token to cause the Runtime to invoke a callback when you call `IAsyncInfo::Cancel` on the async operation or action produced..  
  
 This function is only available to Windows Store apps.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task Class](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f)   
 [progress_reporter Class](../vs140/progress_reporter-class.md)   
 [cancelation_token Class](assetId:///f6db2bcb-013b-437b-b5b7-b01709bc4762)
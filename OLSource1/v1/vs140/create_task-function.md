---
title: "create_task Function"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ppltasks/concurrency::create_task
dev_langs: 
  - C++
helpviewer_keywords: 
  - create_task function
ms.assetid: 6e364052-c923-4006-9e03-8516bf041482
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# create_task Function
Creates a PPL [task](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f) object. `create_task` can be used anywhere you would have used a task constructor. It is provided mainly for convenience, because it allows use of the `auto` keyword while creating tasks.  
  
## Syntax  
  
```  
template<  
   typename _Ty  
>  
__declspec(  
   noinline  
) auto create_task(_Ty _Param, const task_options& _TaskOptions = task_options()) -> task<typename details::_TaskTypeFromParam<_Ty>::_Type>;  
  
template<  
   typename _ReturnType  
>  
__declspec(  
   noinline  
) task<_ReturnType> create_task(const task<_ReturnType>& _Task);  
```  
  
#### Parameters  
 `_Ty`  
 The type of the parameter from which the task is to be constructed.  
  
 `_ReturnType`  
 `_Param`  
 The parameter from which the task is to be constructed. This could be a lambda or function object, a `task_completion_event` object, a different `task` object, or a Windows::Foundation::IAsyncInfo interface if you are using tasks in your Windows Store app.  
  
 `_TaskOptions`  
 `_Task`  
  
## Return Value  
 A new task of type `T`, that is inferred from `_Param`.  
  
## Remarks  
 The first overload behaves like a task constructor that takes a single parameter.  
  
 The second overload associates the cancellation token provided with the newly created task. If you use this overload you are not allowed to pass in a different `task` object as the first parameter.  
  
 The type of the returned task is inferred from the first parameter to the function. If `_Param` is a `task_completion_event<T>`, a `task<T>`, or a functor that returns either type `T` or `task<T>`, the type of the created task is `task<T>`.  
  
 In a Windows Store app, if `_Param` is of type Windows::Foundation::IAsyncOperation<T\>^ or Windows::Foundation::IAsyncOperationWithProgress<T,P>^, or a functor that returns either of those types, the created task will be of type `task<T>`. If `_Param` is of type Windows::Foundation::IAsyncAction^ or Windows::Foundation::IAsyncActionWithProgress<P\>^, or a functor that returns either of those types, the created task will have type `task<void>`.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task Class](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f)   
 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md)
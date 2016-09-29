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
  
```  
template<  
   typename _Function  
>  
__declspec(  
   noinline  
) auto then(const _Function& _Func) const -> typename details::_ContinuationTypeTraits<_Function, _ReturnType>::_TaskOfType;  
  
template<  
   typename _Function  
>  
__declspec(  
   noinline  
) auto then(const _Function& _Func, const task_options& _TaskOptions) const -> typename details::_ContinuationTypeTraits<_Function, _ReturnType>::_TaskOfType;  
  
template<  
   typename _Function  
>  
__declspec(  
   noinline  
) auto then(const _Function& _Func, cancellation_token _CancellationToken, task_continuation_context _ContinuationContext) const -> typename details::_ContinuationTypeTraits<_Function, _ReturnType>::_TaskOfType;  
  
template<  
   typename _Function  
>  
__declspec(  
   noinline  
) auto then(const _Function& _Func, const task_options& _TaskOptions = task_options()) const -> typename details::_ContinuationTypeTraits<_Function, void>::_TaskOfType;  
  
template<  
   typename _Function  
>  
__declspec(  
   noinline  
) auto then(const _Function& _Func, cancellation_token _CancellationToken, task_continuation_context _ContinuationContext) const -> typename details::_ContinuationTypeTraits<_Function, void>::_TaskOfType;  
```  
  
#### Parameters  
 `_Function`  
 The type of the function object that will be invoked by this task.  
  
 `_Func`  
 The continuation function to execute when this task completes. This continuation function must take as input a variable of either `result_type` or `task<result_type>`, where `result_type` is the type of the result this task produces.  
  
 `_TaskOptions`  
 The task options include cancellation token, scheduler and continuation context. By default the former 3 options are inherited from the antecedent task  
  
 `_CancellationToken`  
 The cancellation token to associate with the continuation task. A continuation task that is created without a cancellation token will inherit the token of its antecedent task.  
  
 `_ContinuationContext`  
 A variable that specifies where the continuation should execute. This variable is only useful when used in a Windows Store style app. For more information, see [task_continuation_context](../vs140/task_continuation_context-class.md)  
  
## Return Value  
 The newly created continuation task. The result type of the returned task is determined by what `_Func` returns.  
  
## Remarks  
 The overloads of `then` that take a lambda or functor that returns a Windows::Foundation::IAsyncInfo interface, are only available to Windows Store apps.  
  
 For more information on how to use task continuations to compose asynchronous work, see [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../vs140/task-class--concurrency-runtime-.md)
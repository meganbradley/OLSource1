---
title: "when_any Function"
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
  - "ppltasks/concurrency::when_any"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "when_any function"
ms.assetid: 26b09c07-4c23-41a5-a1de-d71c91dc9ca2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# when_any Function
Creates a task that will complete successfully when any of the tasks supplied as arguments completes successfully.  
  
## Syntax  
  
```  
template<  
   typename _Iterator  
>  
auto when_any(  
   _Iterator_Begin,  
   _Iterator_End,  
   const task_options& _TaskOptions = task_options()  
) -> decltype (details::_WhenAnyImpl<typename std::iterator_traits<_Iterator>::value_type::result_type, _Iterator>::_Perform(_TaskOptions, _Begin, _End));  
  
template<  
   typename _Iterator  
>  
auto when_any(  
   _Iterator_Begin,  
   _Iterator_End,  
   cancellation_token _CancellationToken  
) -> decltype (details::_WhenAnyImpl<typename std::iterator_traits<_Iterator>::value_type::result_type, _Iterator>::_Perform(_CancellationToken._GetImplValue(), _Begin, _End));  
```  
  
#### Parameters  
 `_Iterator`  
 The type of the input iterator.  
  
 `_Begin`  
 The position of the first element in the range of elements to be combined into the resulting task.  
  
 `_End`  
 The position of the first element beyond the range of elements to be combined into the resulting task.  
  
 `_TaskOptions`  
 `_CancellationToken`  
 The cancellation token which controls cancellation of the returned task. If you do not provide a cancellation token, the resulting task will receive the cancellation token of the task that causes it to complete.  
  
## Return Value  
 A task that completes successfully when any one of the input tasks has completed successfully. If the input tasks are of type `T`, the output of this function will be a `task<std::pair<T, size_t>>>`, where the first element of the pair is the result of the completing task, and the second element is the index of the task that finished. If the input tasks are of type `void` the output is a `task<size_t>`, where the result is the index of the completing task.  
  
## Remarks  
 `when_any` is a non-blocking function that produces a `task` as its result. Unlike [task::wait](../vs140/task--wait-method.md), it is safe to call this function in a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app on the ASTA (Application STA) thread.  
  
 For more information, see [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md)
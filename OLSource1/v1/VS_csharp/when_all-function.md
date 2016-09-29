---
title: "when_all Function"
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
  - "ppltasks/concurrency::when_all"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "when_all function"
ms.assetid: 1c80cc05-8211-43d4-a8d7-1b3415899823
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# when_all Function
Creates a task that will complete successfully when all of the tasks supplied as arguments complete successfully.  
  
## Syntax  
  
```  
template <  
   typename _Iterator  
>  
auto when_all(  
   _Iterator_Begin,  
   _Iterator_End,  
   const task_options& _TaskOptions = task_options()  
) -> decltype (details::_WhenAllImpl<typename std::iterator_traits<_Iterator>::value_type::result_type, _Iterator>::_Perform(_TaskOptions, _Begin, _End));  
```  
  
#### Parameters  
 `_Iterator`  
 The type of the input iterator.  
  
 `_Begin`  
 The position of the first element in the range of elements to be combined into the resulting task.  
  
 `_End`  
 The position of the first element beyond the range of elements to be combined into the resulting task.  
  
 `_TaskOptions`  
  
## Return Value  
 A task that completes sucessfully when all of the input tasks have completed successfully. If the input tasks are of type `T`, the output of this function will be a `task<std::vector<T>>`. If the input tasks are of type `void` the output task will also be a `task<void>`.  
  
## Remarks  
 `when_all` is a non-blocking function that produces a `task` as its result. Unlike [task::wait](../VS_csharp/task--wait-method.md), it is safe to call this function in a [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app on the ASTA (Application STA) thread.  
  
 If one of the tasks is canceled or throws an exception, the returned task will complete early, in the canceled state, and the exception, if one is encoutered, will be thrown if you call [task::get](../VS_csharp/task--get-method.md) or `task::wait` on that task.  
  
 For more information, see [Task Parallelism (Concurrency Runtime)](../VS_csharp/task-parallelism--concurrency-runtime-.md).  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)   
 [Task Parallelism (Concurrency Runtime)](../VS_csharp/task-parallelism--concurrency-runtime-.md)
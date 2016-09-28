---
title: "operator&amp;&amp; Operator"
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
  - "ppltasks/concurrency::operator&&"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator&& operator"
ms.assetid: 1334b94a-c4de-4180-bbab-76849ca44309
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&amp;&amp; Operator
Creates a task that will complete succesfully when both of the tasks supplied as arguments complete successfully.  
  
## Syntax  
  
```  
template<  
   typename _ReturnType  
>  
task<std::vector<_ReturnType>> operator&&(  
   const task<_ReturnType> & _Lhs,  
   const task<_ReturnType> & _Rhs  
);  
  
template<  
   typename _ReturnType  
>  
task<std::vector<_ReturnType>> operator&&(  
   const task<std::vector<_ReturnType>> & _Lhs,  
   const task<_ReturnType> & _Rhs  
);  
  
template<  
   typename _ReturnType  
>  
task<std::vector<_ReturnType>> operator&&(  
   const task<_ReturnType> & _Lhs,  
   const task<std::vector<_ReturnType>> & _Rhs  
);  
  
template<  
   typename _ReturnType  
>  
task<std::vector<_ReturnType>> operator&&(  
   const task<std::vector<_ReturnType>> & _Lhs,  
   const task<std::vector<_ReturnType>> & _Rhs  
);  
  
inline task<void> operator&&(  
   const task<void> & _Lhs,  
   const task<void> & _Rhs  
);  
```  
  
#### Parameters  
 `_ReturnType`  
 The type of the returned task.  
  
 `_Lhs`  
 The first task to combine into the resulting task.  
  
 `_Rhs`  
 The second task to combine into the resulting task.  
  
## Return Value  
 A task that completes successfully when both of the input tasks have completed successfully. If the input tasks are of type `T`, the output of this function will be a `task<std::vector<T>>`. If the input tasks are of type `void` the output task will also be a `task<void>`.  
  
## Remarks  
 If one of the tasks is canceled or throws an exception, the returned task will complete early, in the canceled state, and the exception, if one is encoutered, will be thrown if you call `get()` or `wait()` on that task.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md)
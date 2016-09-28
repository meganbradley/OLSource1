---
title: "make_task Function"
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
  - "ppl/concurrency::make_task"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_task function"
ms.assetid: f8f7cb10-90ca-42ce-9c70-cbf090aa3cf6
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_task Function
A factory method for creating a `task_handle` object.  
  
## Syntax  
  
```  
template <  
   class _Function  
>  
task_handle<_Function> make_task(  
   const _Function& _Func  
);  
```  
  
#### Parameters  
 `_Function`  
 The type of the function object that will be invoked to execute the work represented by the `task_handle` object.  
  
 `_Func`  
 The function that will be invoked to execute the work represented by the `task_handle` object. This may be a lambda functor, a pointer to a function, or any object that supports a version of the function call operator with the signature `void operator()()`.  
  
## Return Value  
 A `task_handle` object.  
  
## Remarks  
 This function is useful when you need to create a `task_handle` object with a lambda expression, because it allows you to create the object without knowing the true type of the lambda functor.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task_handle Class](../vs140/task_handle-class.md)   
 [task_group Class](../vs140/task_group-class.md)   
 [structured_task_group Class](../vs140/structured_task_group-class.md)
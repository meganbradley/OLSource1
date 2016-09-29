---
title: "task_handle::task_handle Constructor"
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
  - "ppl/concurrency::task_handle::task_handle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "task_handle, constructor"
ms.assetid: 0ab97448-8070-495e-9992-7eedfdf2d2f1
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_handle::task_handle Constructor
Constructs a new `task_handle` object. The work of the task is performed by invoking the function specified as a parameter to the constructor.  
  
## Syntax  
  
```  
task_handle(  
   const _Function& _Func  
);  
```  
  
#### Parameters  
 `_Func`  
 The function that will be invoked to execute the work represented by the `task_handle` object. This may be a lambda functor, a pointer to a function, or any object that supports a version of the function call operator with the signature `void operator()()`.  
  
## Remarks  
 The runtime creates a copy of the work function that you pass to the constructor. Therefore, any state changes that occur in a function object that you pass to a `task_handle` object will not appear in your copy of that function object.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_handle Class](../vs140/task_handle-class.md)
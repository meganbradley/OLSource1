---
title: "task_group::~task_group Destructor"
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
  - "ppl/concurrency::task_group::~task_group"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~task_group, destructor"
ms.assetid: 3c394c30-255b-428e-990d-82445627e57e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_group::~task_group Destructor
Destroys a `task_group` object. You are expected to call the either the `wait` or `run_and_wait` method on the object prior to the destructor executing, unless the destructor is executing as the result of stack unwinding due to an exception.  
  
## Syntax  
  
```  
~task_group();  
```  
  
## Remarks  
 If the destructor runs as the result of normal execution (for example, not stack unwinding due to an exception) and neither the `wait` nor `run_and_wait` methods have been called, the destructor may throw a [missing_wait](../VS_csharp/missing_wait-class.md) exception.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_group Class](../VS_csharp/task_group-class.md)   
 [task_group::wait Method](../VS_csharp/task_group--wait-method.md)   
 [task_group::run_and_wait Method](../VS_csharp/task_group--run_and_wait-method.md)
---
title: "task::operator== Operator"
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
  - ppltasks/concurrency::task::operator==
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator== operator
ms.assetid: 2305fa89-021b-4ae3-930b-8136d9e195d5
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# task::operator== Operator
Determines whether two `task` objects represent the same internal task.  
  
## Syntax  
  
```  
bool operator==(  
   const task<_ReturnType>& _Rhs  
) const;  
  
bool operator==(  
   const task<void>& _Rhs  
) const;  
```  
  
#### Parameters  
 `_Rhs`  
  
## Return Value  
 `true` if the objects refer to the same underlying task, and `false` otherwise.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../vs140/task-class--concurrency-runtime-.md)
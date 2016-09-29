---
title: "task::operator!= Operator"
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
  - "ppltasks/concurrency::task::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= operator"
ms.assetid: a56e7541-85ac-4f66-82cd-a205e00004f4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task::operator!= Operator
Determines whether two `task` objects represent different internal tasks.  
  
## Syntax  
  
```  
bool operator!=(  
   const task<_ReturnType>& _Rhs  
) const;  
  
bool operator!=(  
   const task<void>& _Rhs  
) const;  
```  
  
#### Parameters  
 `_Rhs`  
  
## Return Value  
 `true` if the objects refer to different underlying tasks, and `false` otherwise.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task Class (Concurrency Runtime)](../VS_csharp/task-class--concurrency-runtime-.md)
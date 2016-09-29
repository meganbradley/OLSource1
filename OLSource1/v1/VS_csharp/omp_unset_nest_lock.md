---
title: "omp_unset_nest_lock"
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
  - "omp_unset_nest_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_unset_nest_lock OpenMP function"
ms.assetid: 1721d061-3f9c-45d7-b479-a665cd0a121d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_unset_nest_lock
Releases a nestable lock.  
  
## Syntax  
  
```  
void omp_unset_nest_lock(   
   omp_nest_lock_t *lock   
);  
```  
  
## Remarks  
 where,  
  
 `lock`  
 A variable of type [omp_nest_lock_t](../VS_csharp/omp_nest_lock_t.md) that was initialized with [omp_init_nest_lock](../VS_csharp/omp_init_nest_lock.md), owned by the thread and executing in the function.  
  
## Remarks  
 For more information, see [3.2.4 omp_unset_lock and omp_unset_nest_lock Functions](../VS_csharp/3.2.4-omp_unset_lock-and-omp_unset_nest_lock-functions.md).  
  
## Example  
 See [omp_init_nest_lock](../VS_csharp/omp_init_nest_lock.md) for an example of using `omp_unset_nest_lock`.  
  
## See Also  
 [Functions](../VS_csharp/openmp-functions.md)
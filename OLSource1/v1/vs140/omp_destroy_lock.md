---
title: "omp_destroy_lock"
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
  - omp_destroy_lock
dev_langs: 
  - C++
helpviewer_keywords: 
  - omp_destroy_lock OpenMP function
ms.assetid: b73ab036-b76f-4e42-82ff-c89db2edf7c0
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# omp_destroy_lock
Uninitializes a lock.  
  
## Syntax  
  
```  
void omp_destroy_lock(  
   omp_lock_t *lock  
);  
```  
  
## Remarks  
 where,  
  
 `lock`  
 A variable of type [omp_lock_t](../vs140/omp_lock_t.md) that was initialized with [omp_init_lock](../vs140/omp_init_lock.md).  
  
## Remarks  
 For more information, see [3.2.2 omp_destroy_lock and omp_destroy_nest_lock Functions](../vs140/3.2.2-omp_destroy_lock-and-omp_destroy_nest_lock-functions.md).  
  
## Example  
 See [omp_init_lock](../vs140/omp_init_lock.md) for an example of using `omp_destroy_lock`.  
  
## See Also  
 [Functions](../vs140/openmp-functions.md)
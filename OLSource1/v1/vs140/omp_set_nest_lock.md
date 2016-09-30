---
title: "omp_set_nest_lock"
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
  - "omp_set_nest_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_set_nest_lock OpenMP function"
ms.assetid: b98ed889-ff8e-4217-a3e9-3993ed8699af
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_set_nest_lock
Blocks thread execution until a lock is available.  
  
## Syntax  
  
```  
void omp_set_nest_lock(  
   omp_nest_lock_t *lock  
);  
```  
  
## Remarks  
 where,  
  
 `lock`  
 A variable of type [omp_nest_lock_t](../vs140/omp_nest_lock_t.md) that was initialized with [omp_init_nest_lock](../vs140/omp_init_nest_lock.md).  
  
## Remarks  
 For more information, see [3.2.3 omp_set_lock and omp_set_nest_lock Functions](../vs140/3.2.3-omp_set_lock-and-omp_set_nest_lock-functions.md).  
  
## Examples  
 See [omp_init_nest_lock](../vs140/omp_init_nest_lock.md) for an example of using `omp_set_nest_lock`.  
  
## See Also  
 [Functions](../vs140/openmp-functions.md)
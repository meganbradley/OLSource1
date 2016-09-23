---
title: "A.31   Thread-Safe Lock Functions"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 3ad89eb8-076c-405a-be5e-88d3d707a832
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# A.31   Thread-Safe Lock Functions
The following C++ example demonstrates how to initialize an array of locks in a parallel region by using `omp_init_lock` ([Section 3.2.1](../vs140/3.2.1-omp_init_lock-and-omp_init_nest_lock-functions.md) on page 42).  
  
## Example  
  
### Code  
  
```  
// A_13_omp_init_lock.cpp  
// compile with: /openmp  
#include <omp.h>  
  
omp_lock_t *new_locks() {  
   int i;  
   omp_lock_t *lock = new omp_lock_t[1000];  
   #pragma omp parallel for private(i)  
   for (i = 0 ; i < 1000 ; i++)  
      omp_init_lock(&lock[i]);  
  
   return lock;  
}  
  
int main () {}  
```
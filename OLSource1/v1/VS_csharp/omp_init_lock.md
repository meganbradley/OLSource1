---
title: "omp_init_lock"
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
  - "omp_init_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_init_lock OpenMP function"
ms.assetid: 7a65e3e2-2e31-4645-964c-c1e82e2a4d0e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_init_lock
Initializes a simple lock.  
  
## Syntax  
  
```  
void omp_init_lock(  
   omp_lock_t *lock  
);  
```  
  
#### Parameters  
 `lock`  
 A variable of type [omp_lock_t](../VS_csharp/omp_lock_t.md).  
  
## Remarks  
 For more information, see [3.2.1 omp_init_lock and omp_init_nest_lock Functions](../VS_csharp/3.2.1-omp_init_lock-and-omp_init_nest_lock-functions.md).  
  
## Example  
  
```  
// omp_init_lock.cpp  
// compile with: /openmp  
#include <stdio.h>  
#include <omp.h>  
  
omp_lock_t my_lock;  
  
int main() {  
   omp_init_lock(&my_lock);  
  
   #pragma omp parallel num_threads(4)  
   {  
      int tid = omp_get_thread_num( );  
      int i, j;  
  
      for (i = 0; i < 5; ++i) {  
         omp_set_lock(&my_lock);  
         printf_s("Thread %d - starting locked region\n", tid);  
         printf_s("Thread %d - ending locked region\n", tid);  
         omp_unset_lock(&my_lock);  
      }  
   }  
  
   omp_destroy_lock(&my_lock);  
}  
```  
  
 **Thread 0 - starting locked region**  
**Thread 0 - ending locked region**  
**Thread 0 - starting locked region**  
**Thread 0 - ending locked region**  
**Thread 0 - starting locked region**  
**Thread 0 - ending locked region**  
**Thread 0 - starting locked region**  
**Thread 0 - ending locked region**  
**Thread 0 - starting locked region**  
**Thread 0 - ending locked region**  
**Thread 1 - starting locked region**  
**Thread 1 - ending locked region**  
**Thread 1 - starting locked region**  
**Thread 1 - ending locked region**  
**Thread 1 - starting locked region**  
**Thread 1 - ending locked region**  
**Thread 1 - starting locked region**  
**Thread 1 - ending locked region**  
**Thread 1 - starting locked region**  
**Thread 1 - ending locked region**  
**Thread 2 - starting locked region**  
**Thread 2 - ending locked region**  
**Thread 2 - starting locked region**  
**Thread 2 - ending locked region**  
**Thread 2 - starting locked region**  
**Thread 2 - ending locked region**  
**Thread 2 - starting locked region**  
**Thread 2 - ending locked region**  
**Thread 2 - starting locked region**  
**Thread 2 - ending locked region**  
**Thread 3 - starting locked region**  
**Thread 3 - ending locked region**  
**Thread 3 - starting locked region**  
**Thread 3 - ending locked region**  
**Thread 3 - starting locked region**  
**Thread 3 - ending locked region**  
**Thread 3 - starting locked region**  
**Thread 3 - ending locked region**  
**Thread 3 - starting locked region**  
**Thread 3 - ending locked region**   
## See Also  
 [Functions](../VS_csharp/openmp-functions.md)
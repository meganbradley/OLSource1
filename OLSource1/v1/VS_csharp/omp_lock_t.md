---
title: "omp_lock_t"
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
  - "omp_lock_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_lock_t OpenMP data type"
ms.assetid: 51b80629-4ffc-4b8a-95c7-1af048f1f286
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_lock_t
A type that holds the status of a lock, whether the lock is available or if a thread owns a lock.  
  
 The following functions use **omp_lock_t**:  
  
-   [omp_init_lock](../VS_csharp/omp_init_lock.md)  
  
-   [omp_destroy_lock](../VS_csharp/omp_destroy_lock.md)  
  
-   [omp_set_lock](../VS_csharp/omp_set_lock.md)  
  
-   [omp_unset_lock](../VS_csharp/omp_unset_lock.md)  
  
-   [omp_test_lock](../VS_csharp/omp_test_lock.md)  
  
 For more information, see [3.2 Lock Functions](../VS_csharp/3.2-lock-functions.md).  
  
## Example  
 See [omp_init_lock](../VS_csharp/omp_init_lock.md) for an example of using **omp_lock_t**.  
  
## See Also  
 [Data Types](../VS_csharp/openmp-data-types.md)
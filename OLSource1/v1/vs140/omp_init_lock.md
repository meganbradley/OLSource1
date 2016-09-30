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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A variable of type [omp_lock_t](../vs140/omp_lock_t.md).  
  
## Remarks  
 For more information, see [3.2.1 omp_init_lock and omp_init_nest_lock Functions](../vs140/3.2.1-omp_init_lock-and-omp_init_nest_lock-functions.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
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
 [Functions](../vs140/openmp-functions.md)
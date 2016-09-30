---
title: "omp_init_nest_lock"
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
  - "omp_init_nest_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_init_nest_lock OpenMP function"
ms.assetid: cf749ec5-de78-4186-9588-ac7c42b02463
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_init_nest_lock
Initializes a lock.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A variable of type [omp_nest_lock_t](../vs140/omp_nest_lock_t.md).  
  
## Remarks  
 The initial nesting count is zero.  
  
 For more information, see [3.2.1 omp_init_lock and omp_init_nest_lock Functions](../vs140/3.2.1-omp_init_lock-and-omp_init_nest_lock-functions.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Thread 0 - starting nested locked region**  
**Thread 0 - ending nested locked region**  
**Thread 0 - starting nested locked region**  
**Thread 0 - ending nested locked region**  
**Thread 3 - starting nested locked region**  
**Thread 3 - ending nested locked region**  
**Thread 3 - starting nested locked region**  
**Thread 3 - ending nested locked region**  
**Thread 3 - starting nested locked region**  
**Thread 3 - ending nested locked region**  
**Thread 2 - starting nested locked region**  
**Thread 2 - ending nested locked region**  
**Thread 2 - starting nested locked region**  
**Thread 2 - ending nested locked region**  
**Thread 2 - starting nested locked region**  
**Thread 2 - ending nested locked region**  
**Thread 1 - starting nested locked region**  
**Thread 1 - ending nested locked region**  
**Thread 1 - starting nested locked region**  
**Thread 1 - ending nested locked region**  
**Thread 1 - starting nested locked region**  
**Thread 1 - ending nested locked region**  
**Thread 0 - starting nested locked region**  
**Thread 0 - ending nested locked region**   
## See Also  
 [Functions](../vs140/openmp-functions.md)
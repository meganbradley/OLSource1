---
title: "omp_test_lock"
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
  - "omp_test_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_test_lock OpenMP function"
ms.assetid: 314ca85e-0749-4c16-800f-b0f36fed256d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_test_lock
Attempts to set a lock but does not block thread execution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A variable of type [omp_lock_t](../vs140/omp_lock_t.md) that was initialized with [omp_init_lock](../vs140/omp_init_lock.md).  
  
## Remarks  
 For more information, see [3.2.5 omp_test_lock and omp_test_nest_lock Functions](../vs140/3.2.5-omp_test_lock-and-omp_test_nest_lock-functions.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Thread 1 - acquired simple_lock**  
**Thread 1 - released simple_lock**  
**Thread 0 - failed to acquire simple_lock**  
**Thread 3 - failed to acquire simple_lock**  
**Thread 0 - failed to acquire simple_lock**  
**Thread 3 - failed to acquire simple_lock**  
**Thread 2 - acquired simple_lock**  
**Thread 0 - failed to acquire simple_lock**  
**Thread 3 - failed to acquire simple_lock**  
**Thread 0 - failed to acquire simple_lock**  
**Thread 3 - failed to acquire simple_lock**  
**Thread 2 - released simple_lock**  
**Thread 0 - failed to acquire simple_lock**  
**Thread 3 - failed to acquire simple_lock**  
**Thread 0 - acquired simple_lock**  
**Thread 3 - failed to acquire simple_lock**  
**Thread 0 - released simple_lock**  
**Thread 3 - failed to acquire simple_lock**  
**Thread 3 - acquired simple_lock**  
**Thread 3 - released simple_lock**   
## See Also  
 [Functions](../vs140/openmp-functions.md)
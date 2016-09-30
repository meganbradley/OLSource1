---
title: "omp_test_nest_lock"
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
  - "omp_test_nest_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_test_nest_lock OpenMP function"
ms.assetid: 4c909bbe-80e0-4100-aca6-d415d7dc5294
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_test_nest_lock
Attempts to set a nestable lock but does not block thread execution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A variable of type [omp_nest_lock_t](../vs140/omp_nest_lock_t.md) that was initialized with [omp_init_nest_lock](../vs140/omp_init_nest_lock.md).  
  
## Remarks  
 For more information, see [3.2.5 omp_test_lock and omp_test_nest_lock Functions](../vs140/3.2.5-omp_test_lock-and-omp_test_nest_lock-functions.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Thread 1 - acquired nestable_lock**  
**Thread 0 - failed to acquire nestable_lock**  
**Thread 1 - acquired nestable_lock again**  
**Thread 0 - failed to acquire nestable_lock**  
**Thread 1 - released nestable_lock**  
**Thread 0 - failed to acquire nestable_lock**  
**Thread 1 - released nestable_lock**  
**Thread 0 - failed to acquire nestable_lock**  
**Thread 3 - acquired nestable_lock**  
**Thread 0 - failed to acquire nestable_lock**  
**Thread 3 - acquired nestable_lock again**  
**Thread 0 - failed to acquire nestable_lock**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 3 - released nestable_lock**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 3 - released nestable_lock**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 0 - acquired nestable_lock**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 0 - acquired nestable_lock again**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 0 - released nestable_lock**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 0 - released nestable_lock**  
**Thread 2 - failed to acquire nestable_lock**  
**Thread 2 - acquired nestable_lock**  
**Thread 2 - acquired nestable_lock again**  
**Thread 2 - released nestable_lock**  
**Thread 2 - released nestable_lock**   
## See Also  
 [Functions](../vs140/openmp-functions.md)
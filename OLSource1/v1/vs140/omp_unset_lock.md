---
title: "omp_unset_lock"
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
  - "omp_unset_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_unset_lock OpenMP function"
ms.assetid: 68fcb728-040b-4bad-979e-aaecb9097a4e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_unset_lock
Releases a lock.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A variable of type [omp_lock_t](../vs140/omp_lock_t.md) that was initialized with [omp_init_lock](../vs140/omp_init_lock.md), owned by the thread and executing in the function.  
  
## Remarks  
 For more information, see [3.2.4 omp_unset_lock and omp_unset_nest_lock Functions](../vs140/3.2.4-omp_unset_lock-and-omp_unset_nest_lock-functions.md).  
  
## Example  
 See [omp_init_lock](../vs140/omp_init_lock.md) for an example of using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## See Also  
 [Functions](../vs140/openmp-functions.md)
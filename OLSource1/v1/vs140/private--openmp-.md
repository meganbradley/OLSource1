---
title: "private (OpenMP)"
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
  - "private"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "private OpenMP clause"
ms.assetid: 772904a2-1345-4562-90e6-eb4dc85aea1a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# private (OpenMP)
Specifies that each thread should have its own instance of a variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The variable to have instances in each thread.  
  
## Remarks  
 **private** applies to the following directives:  
  
-   [for](../vs140/for--openmp-.md)  
  
-   [parallel](../vs140/parallel.md)  
  
-   [sections](../vs140/sections--openmp-.md)  
  
-   [single](../vs140/single.md)  
  
 For more information, see [2.7.2.1 private](../vs140/2.7.2.1-private.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **These are the variables before entry into the parallel region.**  
**nThreadPrivate = 4**  
 **nPrivate = 4**  
 **nFirstPrivate = 4**  
 **nLastPrivate = 4**  
 **nShared = 4**  
**These are the variables at entry of loop 1 of thread 0.**  
**nThreadPrivate = 4**  
 **nPrivate = 1310720**  
 **nFirstPrivate = 4**  
 **nLastPrivate = 1245104**  
 **nShared = 3**  
**These are the variables at entry of loop 1 of thread 1.**  
**nThreadPrivate = 4**  
 **nPrivate = 4488**  
 **nFirstPrivate = 4**  
 **nLastPrivate = 19748**  
 **nShared = 0**  
**These are the variables at entry of loop 1 of thread 2.**  
**nThreadPrivate = 4**  
 **nPrivate = -132514848**  
 **nFirstPrivate = 4**  
 **nLastPrivate = -513199792**  
 **nShared = 4**  
**These are the variables at entry of loop 1 of thread 3.**  
**nThreadPrivate = 4**  
 **nPrivate = 1206**  
 **nFirstPrivate = 4**  
 **nLastPrivate = 1204**  
 **nShared = 2**  
**These are the variables at entry of loop 2 of thread 0.**  
**nThreadPrivate = 0**  
 **nPrivate = 0**  
 **nFirstPrivate = 3**  
 **nLastPrivate = 0**  
 **nShared = 0**  
**These are the variables at entry of loop 2 of thread 1.**  
**nThreadPrivate = 1**  
 **nPrivate = 1**  
 **nFirstPrivate = 3**  
 **nLastPrivate = 1**  
 **nShared = 1**  
**These are the variables at entry of loop 2 of thread 2.**  
**nThreadPrivate = 2**  
 **nPrivate = 2**  
 **nFirstPrivate = 3**  
 **nLastPrivate = 2**  
 **nShared = 2**  
**These are the variables at entry of loop 2 of thread 3.**  
**nThreadPrivate = 3**  
 **nPrivate = 3**  
 **nFirstPrivate = 3**  
 **nLastPrivate = 3**  
 **nShared = 3**  
**These are the variables after exit from the parallel region.**  
**nThreadPrivate = 0 (The last value in the master thread)**  
 **nPrivate = 4 (The value prior to entering parallel region)**  
 **nFirstPrivate = 4 (The value prior to entering parallel region)**  
 **nLastPrivate = 3 (The value from the last iteration of the loop)**  
 **nShared = 1 (The value assigned, from the delayed thread, 1)**   
## See Also  
 [Clauses](../vs140/openmp-clauses.md)
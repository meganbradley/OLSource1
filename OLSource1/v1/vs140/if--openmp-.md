---
title: "if (OpenMP)"
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
  - "if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "if OpenMP clause"
ms.assetid: db5940b6-2414-4bf8-934d-3edd8393c0f8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# if (OpenMP)
Specifies whether a loop should be executed in parallel or in serial.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An integral expression that, if it evaluates to true (nonzero), causes the code in the parallel region to execute in parallel. If the expression evaluates to false (zero), the parallel region is executed in serial (by a single thread).  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> applies to the following directives:  
  
-   [parallel](../vs140/parallel.md)  
  
-   [for](../vs140/for--openmp-.md)  
  
-   [sections](../vs140/sections--openmp-.md)  
  
 For more information, see [2.3 parallel Construct](../vs140/2.3-parallel-construct.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **val = 0, serialized**  
**val = 2, parallelized with 2 threads**   
## See Also  
 [Clauses](../vs140/openmp-clauses.md)
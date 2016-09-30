---
title: "reduction"
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
  - "reduction"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reduction OpenMP clause"
ms.assetid: a2b051af-5a1b-4c00-9cc7-692bb43653fb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reduction
Specifies that one or more variables that are private to each thread are the subject of a reduction operation at the end of the parallel region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The operator for the operation to perform on the variables (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) at the end of the parallel region.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 One more more variables on which to perform scalar reduction. If more than one variable is specified, separate variable names with a comma.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> applies to the following directives:  
  
-   [for](../vs140/for--openmp-.md)  
  
-   [parallel](../vs140/parallel.md)  
  
-   [sections](../vs140/sections--openmp-.md)  
  
 For more information, see [2.7.2.6 reduction](../vs140/2.7.2.6-reduction.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The parallel section was executed 4 times in parallel.**  
**The sum of the consecutive integers from 1 to 10, is 55**  
**All of the the functions, func1 through func5 succeeded!**   
## See Also  
 [Clauses](../vs140/openmp-clauses.md)
---
title: "for (OpenMP)"
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
  - "for"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "for OpenMP directive"
ms.assetid: 8b54e034-9db2-4c1a-a2b1-72e14e930506
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# for (OpenMP)
Causes the work done in a for loop inside a parallel region to be divided among threads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (optional)  
 Zero or more clauses. See the Remarks section for a list of the clauses supported by **for**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A for loop. Undefined behavior will result if user code in the for loop changes the index variable.  
  
## Remarks  
 The **for** directive supports the following OpenMP clauses:  
  
-   [firstprivate](../vs140/firstprivate.md)  
  
-   [lastprivate](../vs140/lastprivate.md)  
  
-   [nowait](../vs140/nowait.md)  
  
-   [ordered](../vs140/ordered--openmp-directives-.md)  
  
-   [private](../vs140/private--openmp-.md)  
  
-   [reduction](../vs140/reduction.md)  
  
-   [schedule](../vs140/schedule.md)  
  
 If **parallel** is also specified, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be any clause accepted by the **parallel** or **for** directives, except **nowait**.  
  
 For more information, see [2.4.1 for Construct](../vs140/2.4.1-for-construct.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **4 OpenMP threads were used.**  
**The sum of 1 through 10 is 55**   
## See Also  
 [Directives](../vs140/openmp-directives.md)
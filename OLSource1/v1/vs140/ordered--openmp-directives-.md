---
title: "ordered (OpenMP Directives)"
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
  - "ordered"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ordered OpenMP directive"
ms.assetid: e1aa703e-d07d-4f6a-9b2a-f4f25203d850
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ordered (OpenMP Directives)
Specifies that code under a parallelized for loop should be executed like a sequential loop.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **ordered** directive must be within the dynamic extent of a [for](../vs140/for--openmp-.md) or **parallel for** construct with an **ordered** clause.  
  
 The **ordered** directive supports no OpenMP clauses.  
  
 For more information, see [2.6.6 ordered Construct](../vs140/2.6.6-ordered-construct.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **test() iteration 1**  
**test() iteration 3**  
**test() iteration 5**  
**test() iteration 7**  
**test2() iteration 0**  
**test2() iteration 1**  
**test2() iteration 2**  
**test2() iteration 3**  
**test2() iteration 4**   
## See Also  
 [Directives](../vs140/openmp-directives.md)
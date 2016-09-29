---
title: "&#39;ReDim&#39; cannot change the number of dimensions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrArray_RankMismatch"
ms.assetid: 52505298-9985-4682-8f6e-ff7d56077f34
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;ReDim&#39; cannot change the number of dimensions
An operation attempts to use the `ReDim` statement to change the rank (number of dimensions) of an array. `ReDim` can change the size of one or more dimensions of an array that has already been formally declared, but it cannot change an array's rank.  
  
### To correct this error  
  
-   Ensure that you intend to change the array's rank and not the sizes of its dimensions, and if possible, use `Dim` to declare a new array with the desired rank.  
  
## See Also  
 [NOTINBUILD Overview of Arrays in Visual Basic](assetId:///ca50e2f2-b4d2-4c57-9169-9abbcc3392d8)   
 [NOTINBUILD Multidimensional Arrays in Visual Basic](assetId:///d92cad25-07e2-4d79-8ea4-ab269700f5de)   
 [ReDim Statement](../vs140/redim-statement--visual-basic-.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)
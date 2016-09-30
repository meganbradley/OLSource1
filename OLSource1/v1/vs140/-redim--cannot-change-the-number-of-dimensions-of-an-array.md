---
title: "&#39;ReDim&#39; cannot change the number of dimensions of an array"
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
  - "vbc30415"
  - "bc30415"
helpviewer_keywords: 
  - "BC30415"
ms.assetid: 8ce97188-ff96-4e8c-917c-efc2f94173a3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;ReDim&#39; cannot change the number of dimensions of an array
You have attempted to use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to change the rank (number of dimensions) of an array. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement can be used to change the size of one or more dimensions of an array that has already been formally declared, but it cannot change the rank of an array.  
  
 **Error ID:** BC30415  
  
### To correct this error  
  
-   Make sure that you intend the rank instead of the sizes of the array, and if possible, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to declare a new array with the desired rank.  
  
## See Also  
 [ReDim Statement](../vs140/redim-statement--visual-basic-.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [NOTINBUILD Overview of Arrays in Visual Basic](assetId:///ca50e2f2-b4d2-4c57-9169-9abbcc3392d8)
---
title: "Array subscript expression missing"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc30306
  - vbc30306
dev_langs: 
  - VB
helpviewer_keywords: 
  - BC30306
ms.assetid: 3c0d9732-ee37-436f-a1df-29d65712f48a
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array subscript expression missing
An array initialization leaves out one or more of the subscripts that define the array bounds. For example, the statement might contain the expression `myArray (5,5,,10)`, which leaves out the third subscript.  
  
 **Error ID:** BC30306  
  
### To correct this error  
  
-   Supply the missing subscript.  
  
## See Also  
 [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md)
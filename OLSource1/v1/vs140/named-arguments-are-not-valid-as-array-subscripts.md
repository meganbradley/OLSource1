---
title: "Named arguments are not valid as array subscripts"
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
  - "vbc30075"
  - "bc30075"
helpviewer_keywords: 
  - "BC30075"
ms.assetid: a25025c9-0763-4c19-9e9b-cffb9aacaa8a
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Named arguments are not valid as array subscripts
An array index is specified using the syntax for passing a procedure argument by name, for example `Array(Index := 10)`. This syntax is not valid for array subscripts.  
  
 **Error ID:** BC30075  
  
### To correct this error  
  
-   Use an ordinary variable or constant expression as the array index, for example `Array(10)`.  
  
## See Also  
 [NOTINBUILD Overview of Arrays in Visual Basic](assetId:///ca50e2f2-b4d2-4c57-9169-9abbcc3392d8)   
 [Passing Arguments by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)
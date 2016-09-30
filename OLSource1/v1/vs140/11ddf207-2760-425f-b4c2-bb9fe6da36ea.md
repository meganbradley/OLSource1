---
title: "&#39;WithEvents&#39; variables can only be typed as classes, interfaces or type parameters with class constraints"
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
  - "vbc30413"
  - "bc30413"
helpviewer_keywords: 
  - "BC30413"
ms.assetid: 11ddf207-2760-425f-b4c2-bb9fe6da36ea
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;WithEvents&#39; variables can only be typed as classes, interfaces or type parameters with class constraints
You declared a variable that is typed as a structure in conjunction with `WithEvents`, which is not a valid use of the `WithEvents` modifier.  
  
 **Error ID:** BC30413  
  
### To correct this error  
  
1.  Use `AddHandler` to handle events defined in a structure.  
  
## See Also  
 [NOT IN BUILD:WithEvents and the Handles Clause](assetId:///072b9cf6-6298-46f1-849e-4edc1631564c)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [AddHandler Statement](../vs140/addhandler-statement.md)
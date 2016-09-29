---
title: "&#39;ReDim&#39; statements can no longer be used to declare array variables"
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
  - "bc30811"
  - "vbc30811"
helpviewer_keywords: 
  - "BC30811"
ms.assetid: 9227a06e-a997-4b16-9977-19e2bce9035b
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;ReDim&#39; statements can no longer be used to declare array variables
`ReDim` can only be used to change the size of an existing array.  
  
 **Error ID:** BC30811  
  
### To correct this error  
  
-   Specify the size of arrays when they are declared; for example:  
  
    ```  
    Dim X(20) As Integer  
    ```  
  
## See Also  
 [Arrays Summary](../vs140/arrays-summary--visual-basic-.md)   
 [ReDim Statement](../vs140/redim-statement--visual-basic-.md)   
 [ReDim Statement Changes in Visual Basic](assetId:///b4da14db-ff23-490f-b3c6-d7ae1b649532)
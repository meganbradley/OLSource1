---
title: "Explicit initialization is not permitted with multiple variables declared with a single type specifier"
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
  - "bc30671"
  - "vbc30671"
helpviewer_keywords: 
  - "BC30671"
ms.assetid: 57bbdd58-b58d-4144-8fa6-366a7167df27
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit initialization is not permitted with multiple variables declared with a single type specifier
Initialization is not allowed when multiple variables are declared on the same line.  
  
 **Error ID:** BC30671  
  
### To correct this error  
  
1.  Declare and initialize each item separately.  
  
2.  Declare multiple items together and then initialize each item; for example:  
  
    ```  
    Dim x, b, i As Integer  
    x = 9 : b = 9 : i = 9   
    ' ":" is the same as a new line.  
    ```  
  
## See Also  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [Variable Declaration](../vs140/variable-declaration-in-visual-basic.md)
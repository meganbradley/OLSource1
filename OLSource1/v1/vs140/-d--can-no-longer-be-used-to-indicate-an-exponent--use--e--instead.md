---
title: "&#39;D&#39; can no longer be used to indicate an exponent, use &#39;E&#39; instead"
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
  - "vbc30827"
  - "bc30827"
helpviewer_keywords: 
  - "BC30827"
ms.assetid: 577f8c0b-9e8a-433f-b504-9ddaa936c250
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;D&#39; can no longer be used to indicate an exponent, use &#39;E&#39; instead
The 'D' character cannot be used to indicate exponentiation.  
  
 **Error ID:** BC30827  
  
### To correct this error  
  
-   Use the `^` operator or `E+` characters to indicate an exponent is present. For example:  
  
    ```  
    Const Mole = 6.02E+23 ' Same as 6.02D23  
    Const Mole2 = 6.02 * 10 ^ 23 ' Same as 6.02D23  
    ```  
  
## See Also  
 [^ Operator](../vs140/^-operator--visual-basic-.md)   
 [Numeric Data Types](../vs140/numeric-data-types--visual-basic-.md)
---
title: "&#39;&lt;method1&gt;&#39; and &#39;&lt;method2&gt;&#39; cannot overload each other because they differ only by optional parameters"
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
  - "vbc30300"
  - "bc30300"
helpviewer_keywords: 
  - "BC30300"
ms.assetid: adb44ceb-57a0-4123-8fd8-7eb83c3f601f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;method1&gt;&#39; and &#39;&lt;method2&gt;&#39; cannot overload each other because they differ only by optional parameters
You have attempted to overload a method with another method that differs from the first only in its optional parameters. A method with an optional parameter is equivalent to two overloaded methods, one with the optional parameter, and the other without it. Therefore, you cannot overload a method with an argument list corresponding to either of these.  
  
 **Error ID:** BC30300  
  
### To correct this error  
  
-   Ensure that the methods are differentiated by more than optional parameters.  
  
## See Also  
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Considerations in Overloading Procedures](../vs140/considerations-in-overloading-procedures--visual-basic-.md)
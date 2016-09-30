---
title: "&#39;&lt;parametername&gt;&#39; is already declared as a type parameter of this method"
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
  - "bc32089"
  - "vbc32089"
helpviewer_keywords: 
  - "BC32089"
ms.assetid: 5e440b4b-f62b-4ff5-9148-2372d4752bf6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;parametername&gt;&#39; is already declared as a type parameter of this method
A generic procedure defines a normal parameter or a local variable with the same name as a type parameter.  
  
 Every parameter of a procedure, including every type parameter of a generic procedure, must have a name distinct from all other parameters. Because procedure parameters are used as local variables, any local variable declared within the procedure must also have a name distinct from all parameters and type parameters.  
  
 **Error ID:** BC32089  
  
### To correct this error  
  
-   Change the name of the normal parameter or local variable.  
  
## See Also  
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)   
 [Parameter List](../vs140/parameter-list--visual-basic-.md)
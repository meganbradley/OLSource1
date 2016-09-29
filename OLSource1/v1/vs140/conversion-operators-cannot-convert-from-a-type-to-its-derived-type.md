---
title: "Conversion operators cannot convert from a type to its derived type"
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
  - "vbc33027"
  - "bc33027"
helpviewer_keywords: 
  - "BC33027"
ms.assetid: 861954f2-f563-4234-af84-bdd02f39979b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversion operators cannot convert from a type to its derived type
A conversion operator is declared with a return type that derives from the parameter type.  
  
 At compile time, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] considers a predefined conversion to exist from any reference type to any type in its inheritance hierarchy, that is, any type from which it derives or which derives from it. Such a conversion might fail at run time, but the compiler cannot predict run-time results, so it allows any such conversion to compile.  
  
 Because the compiler considers this conversion to be already defined, it does not allow you to redefine it.  
  
 **Error ID:** BC33027  
  
### To correct this error  
  
-   Remove this operator definition entirely. It is already predefined.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)
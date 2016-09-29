---
title: "Conversion operators cannot convert from a base type"
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
  - "bc33030"
  - "vbc33030"
helpviewer_keywords: 
  - "BC33030"
ms.assetid: b19800ab-6a32-473f-b7ee-7de584e4ccae
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversion operators cannot convert from a base type
A conversion operator is declared with a parameter type from which the return type derives.  
  
 At compile time, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] considers a predefined conversion to exist from any reference type to any type in its inheritance hierarchy, that is, any type from which it derives or which derives from it. Such a conversion might fail at run time, but the compiler cannot predict run-time results, so it allows any such conversion to compile.  
  
 Because the compiler considers this conversion to be already defined, it does not allow you to redefine it.  
  
 **Error ID:** BC33030  
  
### To correct this error  
  
-   Remove this operator definition entirely. It is already predefined.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)
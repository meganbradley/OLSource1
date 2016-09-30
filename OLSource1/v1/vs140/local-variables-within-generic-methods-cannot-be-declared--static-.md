---
title: "Local variables within generic methods cannot be declared &#39;Static&#39;"
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
  - "vbc32068"
  - "bc32068"
helpviewer_keywords: 
  - "BC32068"
ms.assetid: cb5df484-76f9-4092-9d19-f26ddcf1c035
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Local variables within generic methods cannot be declared &#39;Static&#39;
The declaration of a local variable within a generic procedure specifies `Static`.  
  
 Visual Basic and the .NET Framework do not currently support any combination of static variables and generic procedures.  
  
 **Error ID:** BC32068  
  
### To correct this error  
  
-   Remove the `Static` keyword from the variable declaration.  
  
## See Also  
 [Static (Visual Basic)](../vs140/static--visual-basic-.md)   
 [NOTINBUILD How to: Lengthen a Variable's Lifetime](assetId:///04e7c56c-1db0-4fe5-a678-859a39ec654b)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)
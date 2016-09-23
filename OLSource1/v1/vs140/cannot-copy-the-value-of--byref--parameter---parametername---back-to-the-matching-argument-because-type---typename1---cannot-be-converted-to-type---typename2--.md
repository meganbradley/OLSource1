---
title: "Cannot copy the value of &#39;ByRef&#39; parameter &#39;&lt;parametername&gt;&#39; back to the matching argument because type &#39;&lt;typename1&gt;&#39; cannot be converted to type &#39;&lt;typename2&gt;&#39;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc33037
  - BC33037
helpviewer_keywords: 
  - BC33037
ms.assetid: 3ff137e2-e062-4e54-abf5-e902e2d18968
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Cannot copy the value of &#39;ByRef&#39; parameter &#39;&lt;parametername&gt;&#39; back to the matching argument because type &#39;&lt;typename1&gt;&#39; cannot be converted to type &#39;&lt;typename2&gt;&#39;
A procedure is declared with a parameter type which cannot be converted back to the calling argument type.  
  
 When you define a class or structure, you can define one or more conversion operators to convert that class or structure type to other types. You can also define reverse conversion operators to convert those other types back to your class or structure type. When you use your class or structure type in a procedure call, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] can use these conversion operators to convert the type of an argument to the type of its corresponding parameter.  
  
 If you pass the argument [ByRef](../vs140/byref--visual-basic-.md), [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] sometimes copies the argument value into a local variable in the procedure instead of passing a reference. In such a case, when the procedure returns, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] must then copy the local variable value back into the argument in the calling code.  
  
 If a `ByRef` argument value is copied into the procedure and the argument and parameter are of the same type, no conversion is necessary. But if the types are different, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] must convert in both directions. If one of the types is your class or structure type, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] must convert it both to and from the other type. This means you must define conversion operators in both directions.  
  
 **Error ID:** BC33037  
  
### To correct this error  
  
-   If possible, use a calling argument of the same type as the procedure parameter, so [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] does not need to do any conversion.  
  
-   If you need to call the procedure with an argument type different from the parameter type but do not need to return a value into the calling argument, define the parameter to be [ByVal](../vs140/byval--visual-basic-.md) instead of `ByRef`.  
  
-   If you need to return a value into the calling argument, define the reverse conversion operator so [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] can convert back to the calling argument type.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Argument Passing ByVal and ByRef](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)
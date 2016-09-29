---
title: "Copying the value of &#39;ByRef&#39; parameter &#39;&lt;parametername&gt;&#39; back to the matching argument narrows from type &#39;&lt;typename1&gt;&#39; to type &#39;&lt;typename2&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc32053"
  - "vbc32053"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC32053"
ms.assetid: 281564b7-99f7-451f-b10d-f985e831bb25
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Copying the value of &#39;ByRef&#39; parameter &#39;&lt;parametername&gt;&#39; back to the matching argument narrows from type &#39;&lt;typename1&gt;&#39; to type &#39;&lt;typename2&gt;&#39;
A procedure is called with an argument that widens to the corresponding parameter type, and the conversion from the parameter to the argument is narrowing.  
  
 When you define a class or structure, you can define one or more conversion operators to convert that class or structure type to other types. You can also define reverse conversion operators to convert those other types back to your class or structure type. When you use your class or structure type in a procedure call, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] can use these conversion operators to convert the type of an argument to the type of its corresponding parameter.  
  
 If you pass the argument [ByRef](../VS_csharp/byref--visual-basic-.md), [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] sometimes copies the argument value into a local variable in the procedure instead of passing a reference. In such a case, when the procedure returns, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] must then copy the local variable value back into the argument in the calling code.  
  
 If a `ByRef` argument value is copied into the procedure and the argument and parameter are of the same type, no conversion is necessary. But if the types are different, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] must convert in both directions. If one of the types is your class or structure type, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] must convert it both to and from the other type. If one of these conversions is widening, the reverse conversion might be narrowing.  
  
 **Error ID:** BC32053  
  
### To correct this error  
  
-   If possible, use a calling argument of the same type as the procedure parameter, so [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] does not need to do any conversion.  
  
-   If you need to call the procedure with an argument type different from the parameter type but do not need to return a value into the calling argument, define the parameter to be [ByVal](../VS_csharp/byval--visual-basic-.md) instead of `ByRef`.  
  
-   If you need to return a value into the calling argument, define the reverse conversion operator as [Widening](../VS_csharp/widening--visual-basic-.md), if possible.  
  
## See Also  
 [Procedures in Visual Basic](../VS_csharp/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../VS_csharp/procedure-parameters-and-arguments--visual-basic-.md)   
 [Argument Passing ByVal and ByRef](../VS_csharp/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md)   
 [Operator Statement](../VS_csharp/operator-statement.md)   
 [How to: Define an Operator](../VS_csharp/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../VS_csharp/how-to--define-a-conversion-operator--visual-basic-.md)   
 [Type Conversions in Visual Basic](../VS_csharp/type-conversions-in-visual-basic.md)   
 [Widening and Narrowing Conversions](../VS_csharp/widening-and-narrowing-conversions--visual-basic-.md)
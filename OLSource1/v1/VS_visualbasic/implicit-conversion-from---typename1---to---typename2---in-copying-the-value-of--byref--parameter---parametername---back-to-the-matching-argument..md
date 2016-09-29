---
title: "Implicit conversion from &#39;&lt;typename1&gt;&#39; to &#39;&lt;typename2&gt;&#39; in copying the value of &#39;ByRef&#39; parameter &#39;&lt;parametername&gt;&#39; back to the matching argument."
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
  - "vbc41999"
  - "bc41999"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC41999"
ms.assetid: ae48c738-dff8-4c0f-8931-bbb70b2c8b03
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implicit conversion from &#39;&lt;typename1&gt;&#39; to &#39;&lt;typename2&gt;&#39; in copying the value of &#39;ByRef&#39; parameter &#39;&lt;parametername&gt;&#39; back to the matching argument.
A procedure is called with a [ByRef](../VS_csharp/byref--visual-basic-.md) argument of a different type than that of its corresponding parameter.  
  
 If you pass an argument `ByRef`, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] sometimes copies the argument value into a local variable in the procedure instead of passing a reference. In such a case, when the procedure returns, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] must then copy the local variable value back into the argument in the calling code.  
  
 If a `ByRef` argument value is copied into the procedure and the argument and parameter are of the same type, no conversion is necessary. But if the types are different, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] must convert in both directions. Because you cannot use `CType` or any of the other conversion keywords on a procedure argument or parameter, such a conversion is always implicit.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../VS_csharp/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC41999  
  
### To correct this error  
  
-   If possible, use a calling argument of the same type as the procedure parameter, so [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] does not need to do any conversion.  
  
-   If you need to call the procedure with an argument type different from the parameter type but do not need to return a value into the calling argument, define the parameter to be [ByVal](../VS_csharp/byval--visual-basic-.md) instead of `ByRef`.  
  
## See Also  
 [Procedures in Visual Basic](../VS_csharp/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../VS_csharp/procedure-parameters-and-arguments--visual-basic-.md)   
 [Argument Passing ByVal and ByRef](../VS_csharp/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Implicit and Explicit Conversions](../VS_csharp/implicit-and-explicit-conversions--visual-basic-.md)
---
title: "Data Types in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "data types [Visual Basic], declaring"
  - "typing"
  - "data types [Visual Basic]"
  - "Visual Basic code, data types"
  - "data types [Visual Basic], improving speed with"
ms.assetid: 5e1b9aaf-c7ca-4b29-9b22-0e82ed8e85e2
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Types in Visual Basic
The *data type* of a programming element refers to what kind of data it can hold and how it stores that data. Data types apply to all values that can be stored in computer memory or participate in the evaluation of an expression. Every variable, literal, constant, enumeration, property, procedure parameter, procedure argument, and procedure return value has a data type.  
  
## Declared Data Types  
 You define a programming element with a declaration statement, and you specify its data type with the `As` clause. The following table shows the statements you use to declare various elements.  
  
|Programming element|Data type declaration|  
|-------------------------|---------------------------|  
|Variable|In a [Dim Statement (Visual Basic)](../VS_csharp/dim-statement--visual-basic-.md)<br /><br /> `Dim`   `amount As Double`<br /><br /> `Static`   `yourName As String`<br /><br /> `Public`   `billsPaid As Decimal = 0`|  
|Literal|With a literal type character; see "Literal Type Characters" in [Type Characters](../VS_csharp/type-characters--visual-basic-.md)<br /><br /> `Dim searchChar As Char = "."`  `C`|  
|Constant|In a [Const Statement (Visual Basic)](../VS_csharp/const-statement--visual-basic-.md)<br /><br /> `Const`   `modulus As Single = 4.17825F`|  
|Enumeration|In an [Enum Statement (Visual Basic)](../VS_csharp/enum-statement--visual-basic-.md)<br /><br /> `Public`   `Enum`   `colors`|  
|Property|In a [Property Statement](../VS_csharp/property-statement.md)<br /><br /> `Property`   `region() As String`|  
|Procedure parameter|In a [Sub Statement (Visual Basic)](../VS_csharp/sub-statement--visual-basic-.md), [Function Statement (Visual Basic)](../VS_csharp/function-statement--visual-basic-.md), or [Operator Statement](../VS_csharp/operator-statement.md)<br /><br /> `Sub addSale(ByVal`   `amount`   `As Double)`|  
|Procedure argument|In the calling code; each argument is a programming element that has already been declared, or an expression containing declared elements<br /><br /> `subString = Left(`  `inputString`  `,`   `5`  `)`|  
|Procedure return value|In a [Function Statement (Visual Basic)](../VS_csharp/function-statement--visual-basic-.md) or [Operator Statement](../VS_csharp/operator-statement.md)<br /><br /> `Function convert(ByVal b As Byte)`   `As String`|  
  
 For a list of Visual Basic data types, see [Data Type Summary (Visual Basic)](../VS_csharp/data-type-summary--visual-basic-.md).  
  
## See Also  
 [Type Characters](../VS_csharp/type-characters--visual-basic-.md)   
 [Elementary Data Types](../VS_csharp/elementary-data-types--visual-basic-.md)   
 [Composite Data Types](../VS_csharp/composite-data-types--visual-basic-.md)   
 [Generic Types in Visual Basic](../VS_csharp/generic-types-in-visual-basic--visual-basic-.md)   
 [Value Types and Reference Types](../VS_csharp/value-types-and-reference-types.md)   
 [Type Conversions in Visual Basic](../VS_csharp/type-conversions-in-visual-basic.md)   
 [Structures](../VS_csharp/structures--visual-basic-.md)   
 [Troubleshooting Data Types](../VS_csharp/troubleshooting-data-types--visual-basic-.md)   
 [Data Types](../VS_csharp/data-type-summary--visual-basic-.md)   
 [Efficient Use of Data Types (Visual Basic)](../VS_csharp/efficient-use-of-data-types--visual-basic-.md)
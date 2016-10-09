---
title: "Data Types in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 28
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Data Types in Visual Basic
The *data type* of a programming element refers to what kind of data it can hold and how it stores that data. Data types apply to all values that can be stored in computer memory or participate in the evaluation of an expression. Every variable, literal, constant, enumeration, property, procedure parameter, procedure argument, and procedure return value has a data type.  
  
## Declared Data Types  
 You define a programming element with a declaration statement, and you specify its data type with the `As` clause. The following table shows the statements you use to declare various elements.  
  
|Programming element|Data type declaration|  
|-------------------------|---------------------------|  
|Variable|In a [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)<br /><br /> `Dim`   `amount As Double`<br /><br /> `Static`   `yourName As String`<br /><br /> `Public`   `billsPaid As Decimal = 0`|  
|Literal|With a literal type character; see "Literal Type Characters" in [Type Characters](../VS_visualbasic/type-characters--visual-basic-.md)<br /><br /> `Dim searchChar As Char = "."`  `C`|  
|Constant|In a [Const Statement](../VS_visualbasic/const-statement--visual-basic-.md)<br /><br /> `Const`   `modulus As Single = 4.17825F`|  
|Enumeration|In an [Enum Statement](../VS_visualbasic/enum-statement--visual-basic-.md)<br /><br /> `Public`   `Enum`   `colors`|  
|Property|In a [Property Statement](../VS_visualbasic/property-statement.md)<br /><br /> `Property`   `region() As String`|  
|Procedure parameter|In a [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md), [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md), or [Operator Statement](../VS_visualbasic/operator-statement.md)<br /><br /> `Sub addSale(ByVal`   `amount`   `As Double)`|  
|Procedure argument|In the calling code; each argument is a programming element that has already been declared, or an expression containing declared elements<br /><br /> `subString = Left(`  `inputString`  `,`   `5`  `)`|  
|Procedure return value|In a [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md) or [Operator Statement](../VS_visualbasic/operator-statement.md)<br /><br /> `Function convert(ByVal b As Byte)`   `As String`|  
  
 For a list of Visual Basic data types, see [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md).  
  
## See Also  
 [Type Characters](../VS_visualbasic/type-characters--visual-basic-.md)   
 [Elementary Data Types](../VS_visualbasic/elementary-data-types--visual-basic-.md)   
 [Composite Data Types](../VS_visualbasic/composite-data-types--visual-basic-.md)   
 [Generic Types in Visual Basic](../VS_visualbasic/generic-types-in-visual-basic--visual-basic-.md)   
 [Value Types and Reference Types](../VS_visualbasic/value-types-and-reference-types.md)   
 [Type Conversions in Visual Basic](../VS_visualbasic/type-conversions-in-visual-basic.md)   
 [Structures](../VS_visualbasic/structures--visual-basic-.md)   
 [Troubleshooting Data Types](../VS_visualbasic/troubleshooting-data-types--visual-basic-.md)   
 [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../VS_visualbasic/efficient-use-of-data-types--visual-basic-.md)
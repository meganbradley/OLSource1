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
|Variable|In a [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md)\<br />\<br /> `Dim`   `amount As Double`\<br />\<br /> `Static`   `yourName As String`\<br />\<br /> `Public`   `billsPaid As Decimal = 0`|  
|Literal|With a literal type character; see "Literal Type Characters" in [Type Characters](../vs140/type-characters--visual-basic-.md)\<br />\<br /> `Dim searchChar As Char = "."`  `C`|  
|Constant|In a [Const Statement (Visual Basic)](../vs140/const-statement--visual-basic-.md)\<br />\<br /> `Const`   `modulus As Single = 4.17825F`|  
|Enumeration|In an [Enum Statement (Visual Basic)](../vs140/enum-statement--visual-basic-.md)\<br />\<br /> `Public`   `Enum`   `colors`|  
|Property|In a [Property Statement](../vs140/property-statement.md)\<br />\<br /> `Property`   `region() As String`|  
|Procedure parameter|In a [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md), [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md), or [Operator Statement](../vs140/operator-statement.md)\<br />\<br /> `Sub addSale(ByVal`   `amount`   `As Double)`|  
|Procedure argument|In the calling code; each argument is a programming element that has already been declared, or an expression containing declared elements\<br />\<br /> `subString = Left(`  `inputString`  `,`   `5`  `)`|  
|Procedure return value|In a [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md) or [Operator Statement](../vs140/operator-statement.md)\<br />\<br /> `Function convert(ByVal b As Byte)`   `As String`|  
  
 For a list of Visual Basic data types, see [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md).  
  
## See Also  
 [Type Characters](../vs140/type-characters--visual-basic-.md)   
 [Elementary Data Types](../vs140/elementary-data-types--visual-basic-.md)   
 [Composite Data Types](../vs140/composite-data-types--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Efficient Use of Data Types (Visual Basic)](../vs140/efficient-use-of-data-types--visual-basic-.md)
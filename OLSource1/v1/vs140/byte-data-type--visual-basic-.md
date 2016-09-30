---
title: "Byte Data Type (Visual Basic)"
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
  - "vb.Byte"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Byte data type"
  - "data types [Visual Basic], assigning"
ms.assetid: eed44dff-eaee-4937-a89f-444e418e74f6
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Byte Data Type (Visual Basic)
Holds unsigned 8-bit (1-byte) integers that range in value from 0 through 255.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> data type to contain binary data.  
  
 The default value of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is 0.  
  
## Programming Tips  
  
-   **Negative Numbers.** Because <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is an unsigned type, it cannot represent a negative number. If you use the unary minus (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) operator on an expression that evaluates to type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, Visual Basic converts the expression to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> first.  
  
-   **Format Conversions.** When Visual Basic reads or writes files, or when it calls DLLs, methods, and properties, it can automatically convert between data formats. Binary data stored in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variables and arrays is preserved during such format conversions. You should not use a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> variable for binary data, because its contents can be corrupted during conversion between ANSI and Unicode formats.  
  
-   **Widening.** The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> data type widens to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. This means you can convert <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to any of these types without encountering a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Type Characters.** <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> has no literal type character or identifier type character.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Byte*?displayProperty=fullName> structure.  
  
## Example  
 In the following example, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> variable. The statements demonstrate the range of the variable and the application of bit-shift operators to it.  
  
 [!code[VbVbalrDataTypes#16](../vs140/codesnippet/VisualBasic/byte-data-type--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:System.Byte*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)
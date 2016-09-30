---
title: "Char Data Type (Visual Basic)"
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
  - "vb.Char"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "literal type characters, C"
  - "Char data type"
  - "C literal type character"
  - "data types [Visual Basic], assigning"
  - "Char data type, character literals"
ms.assetid: cd7547a9-7855-4e8e-b216-35d74a362657
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Char Data Type (Visual Basic)
Holds unsigned 16-bit (2-byte) code points ranging in value from 0 through 65535. Each *code point*, or character code, represents a single Unicode character.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data type when you need to hold only a single character and do not need the overhead of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. In some cases you can use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, an array of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements, to hold multiple characters.  
  
 The default value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the character with a code point of 0.  
  
## Unicode Characters  
 The first 128 code points (0–127) of Unicode correspond to the letters and symbols on a standard U.S. keyboard. These first 128 code points are the same as those the ASCII character set defines. The second 128 code points (128–255) represent special characters, such as Latin-based alphabet letters, accents, currency symbols, and fractions. Unicode uses the remaining code points (256-65535) for a wide variety of symbols, including worldwide textual characters, diacritics, and mathematical and technical symbols.  
  
 You can use methods like \<xref:System.Char.IsDigit*> and \<xref:System.Char.IsPunctuation*> on a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable to determine its Unicode classification.  
  
## Type Conversions  
 Visual Basic does not convert directly between <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the numeric types. You can use the \<xref:Microsoft.VisualBasic.Strings.Asc*> or \<xref:Microsoft.VisualBasic.Strings.AscW*> function to convert a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value to an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that represents its code point. You can use the \<xref:Microsoft.VisualBasic.Strings.Chr*> or \<xref:Microsoft.VisualBasic.Strings.ChrW*> function to convert an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that has that code point.  
  
 If the type checking switch ([Option Strict Statement](../vs140/option-strict-statement.md)) is on, you must append the literal type character to a single-character string literal to identify it as the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> data type. The following example illustrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Programming Tips  
  
-   **Negative Numbers.** <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is an unsigned type and cannot represent a negative value. In any case, you should not use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to hold numeric values.  
  
-   **Interop Considerations.** If you interface with components not written for the .NET Framework, for example Automation or COM objects, remember that character types have a different data width (8 bits) in other environments. If you pass an 8-bit argument to such a component, declare it as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in your new Visual Basic code.  
  
-   **Widening.** The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> data type widens to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. This means you can convert <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and will not encounter a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
-   **Type Characters.** Appending the literal type character <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to a single-character string literal forces it to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> data type. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> has no identifier type character.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Char*?displayProperty=fullName> structure.  
  
## See Also  
 \<xref:System.Char*?displayProperty=fullName>   
 \<xref:Microsoft.VisualBasic.Strings.Asc*>   
 \<xref:Microsoft.VisualBasic.Strings.AscW*>   
 \<xref:Microsoft.VisualBasic.Strings.Chr*>   
 \<xref:Microsoft.VisualBasic.Strings.ChrW*>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [How to: Call a Windows Function that Takes Unsigned Types](../vs140/how-to--call-a-windows-function-that-takes-unsigned-types--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)
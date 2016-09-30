---
title: "String Data Type (Visual Basic)"
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
  - "vb.String"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "strings [Visual Basic], character"
  - "strings [Visual Basic], fixed-length"
  - "string keyword [Visual Basic]"
  - "fixed-length strings, string data type"
  - "literals, string"
  - "text [Visual Basic], String data type"
  - "$ identifier type character"
  - "String data type"
  - "fixed-length strings"
  - "string literals"
  - "data types [Visual Basic], assigning"
  - "" String literals"
  - "identifier type characters, $"
ms.assetid: 15ac03f5-cabd-42cc-a754-1df3893c25d9
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String Data Type (Visual Basic)
Holds sequences of unsigned 16-bit (2-byte) code points that range in value from 0 through 65535. Each *code point*, or character code, represents a single Unicode character. A string can contain from 0 to approximately two billion (2 ^ 31) Unicode characters.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data type to hold multiple characters without the array management overhead of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, an array of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements.  
  
 The default value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (a null reference). Note that this is not the same as the empty string (value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Unicode Characters  
 The first 128 code points (0–127) of Unicode correspond to the letters and symbols on a standard U.S. keyboard. These first 128 code points are the same as those the ASCII character set defines. The second 128 code points (128–255) represent special characters, such as Latin-based alphabet letters, accents, currency symbols, and fractions. Unicode uses the remaining code points (256-65535) for a wide variety of symbols. This includes worldwide textual characters, diacritics, and mathematical and technical symbols.  
  
 You can use methods such as \<xref:System.Char.IsDigit*> and \<xref:System.Char.IsPunctuation*> on an individual character in a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variable to determine its Unicode classification.  
  
## Format Requirements  
 You must enclose a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> literal within quotation marks (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>). If you must include a quotation mark as one of the characters in the string, you use two contiguous quotation marks (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>). The following example illustrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that the contiguous quotation marks that represent a quotation mark in the string are independent of the quotation marks that begin and end the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> literal.  
  
## String Manipulations  
 Once you assign a string to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> variable, that string is *immutable*, which means you cannot change its length or contents. When you alter a string in any way, Visual Basic creates a new string and abandons the previous one. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> variable then points to the new string.  
  
 You can manipulate the contents of a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> variable by using a variety of string functions. The following example illustrates the \<xref:Microsoft.VisualBasic.Strings.Left*> function  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string created by another component might be padded with leading or trailing spaces. If you receive such a string, you can use the \<xref:Microsoft.VisualBasic.Strings.Trim*>, \<xref:Microsoft.VisualBasic.Strings.LTrim*>, and \<xref:Microsoft.VisualBasic.Strings.RTrim*> functions to remove these spaces.  
  
 For more information about string manipulations, see [Strings in Visual Basic](../vs140/strings-in-visual-basic.md).  
  
## Programming Tips  
  
-   **Negative Numbers.** Remember that the characters held by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are unsigned and cannot represent negative values. In any case, you should not use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to hold numeric values.  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, remember that string characters have a different data width (8 bits) in other environments. If you are passing a string argument of 8-bit characters to such a component, declare it as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, an array of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> elements, instead of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in your new Visual Basic code.  
  
-   **Type Characters.** Appending the identifier type character <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to any identifier forces it to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> data type. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> has no literal type character. However, the compiler treats literals enclosed in quotation marks (<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) as <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.String*?displayProperty=fullName> class.  
  
## See Also  
 \<xref:System.String*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Char Data Type (Visual Basic)](../vs140/char-data-type--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [How to: Call a Windows Function that Takes Unsigned Types](../vs140/how-to--call-a-windows-function-that-takes-unsigned-types--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)
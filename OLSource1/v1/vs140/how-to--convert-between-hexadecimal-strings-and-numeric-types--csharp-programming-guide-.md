---
title: "How to: Convert Between Hexadecimal Strings and Numeric Types (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "hexadecimal strings [C#], converting to numeric type"
  - "conversions [C#], hexidecimal strings"
  - "strings [C#], converting hexadecimal strings"
  - "hexadecimal strings [C#]"
ms.assetid: 7115c49f-7d1d-40c3-8bd9-aae0cc1d46b6
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert Between Hexadecimal Strings and Numeric Types (C# Programming Guide)
These examples show you how to perform the following tasks:  
  
-   Obtain the hexadecimal value of each character in a [string](../vs140/string--csharp-reference-.md).  
  
-   Obtain the [char](../vs140/char--csharp-reference-.md) that corresponds to each value in a hexadecimal string.  
  
-   Convert a hexadecimal `string` to an [int](../vs140/int--csharp-reference-.md).  
  
-   Convert a hexadecimal `string` to a [float](../vs140/float--csharp-reference-.md).  
  
-   Convert a [byte](../vs140/byte--csharp-reference-.md) array to a hexadecimal `string`.  
  
## Example  
 This example outputs the hexadecimal value of each character in a `string`. First it parses the `string` to an array of characters. Then it calls \<xref:System.Convert.ToInt32(System.Char)> on each character to obtain its numeric value. Finally, it formats the number as its hexadecimal representation in a `string`.  
  
 [!code[csProgGuideTypes#30](../vs140/codesnippet/CSharp/how-to--convert-between-hexadecimal-strings-and-numeric-types--csharp-programming-guide-_1.cs)]  
  
## Example  
 This example parses a `string` of hexadecimal values and outputs the character corresponding to each hexadecimal value. First it calls the [Split(Char\[\])](assetId:///M:System.String.Split(System.Char[])?qualifyHint=False&autoUpgrade=False) method to obtain each hexadecimal value as an individual `string` in an array. Then it calls \<xref:System.Convert.ToInt32(System.String,System.Int32)> to convert the hexadecimal value to a decimal value represented as an [int](../vs140/int--csharp-reference-.md). It shows two different ways to obtain the character corresponding to that character code. The first technique uses \<xref:System.Char.ConvertFromUtf32(System.Int32)>, which returns the character corresponding to the integer argument as a `string`. The second technique explicitly casts the `int` to a [char](../vs140/char--csharp-reference-.md).  
  
 [!code[csProgGuideTypes#31](../vs140/codesnippet/CSharp/how-to--convert-between-hexadecimal-strings-and-numeric-types--csharp-programming-guide-_2.cs)]  
  
## Example  
 This example shows another way to convert a hexadecimal `string` to an integer, by calling the \<xref:System.Int32.Parse(System.String,System.Globalization.NumberStyles)> method.  
  
 [!code[csProgGuideTypes#32](../vs140/codesnippet/CSharp/how-to--convert-between-hexadecimal-strings-and-numeric-types--csharp-programming-guide-_3.cs)]  
  
## Example  
 The following example shows how to convert a hexadecimal `string` to a [float](../vs140/float--csharp-reference-.md) by using the \<xref:System.BitConverter*?displayProperty=fullName> class and the \<xref:System.Int32.Parse*?displayProperty=fullName> method.  
  
 [!code[csProgGuideTypes#39](../vs140/codesnippet/CSharp/how-to--convert-between-hexadecimal-strings-and-numeric-types--csharp-programming-guide-_4.cs)]  
  
## Example  
 The following example shows how to convert a [byte](../vs140/byte--csharp-reference-.md) array to a hexadecimal string by using the \<xref:System.BitConverter*?displayProperty=fullName> class.  
  
 [!code[csProgGuideTypes#38](../vs140/codesnippet/CSharp/how-to--convert-between-hexadecimal-strings-and-numeric-types--csharp-programming-guide-_5.cs)]  
  
## See Also  
 [Standard Numeric Format Strings](assetId:///580e57eb-ac47-4ffd-bccd-3a1637c2f467)   
 [Data Types (C# Programming Guide)](../vs140/types--csharp-programming-guide-.md)   
 [How To: Determine Whether a String Contains a Numeric Value (C# Programming Guide)](../vs140/how-to--determine-whether-a-string-represents-a-numeric-value--csharp-programming-guide-.md)
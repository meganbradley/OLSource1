---
title: "How to: Convert a String to a Number (C# Programming Guide)"
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
  - "conversions [C#]"
  - "conversions [C#], string to int"
  - "converting strings to int [C#]"
  - "strings [C#], converting to int"
ms.assetid: 467b9979-86ee-4afd-b734-30299cda91e3
caps.latest.revision: 38
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert a String to a Number (C# Programming Guide)
You can convert a [string](../vs140/string--csharp-reference-.md) to a number by using methods in the <xref:System.Convert*> class or by using the `TryParse` method found on the various numeric types (int, long, float, etc.).  
  
 If you have a string, it is slightly more efficient and straightforward to call a `TryParse` method (for example, `int.TryParse(“11”)`).  Using a `Convert` method is more useful for general objects that implement <xref:System.IConvertible*>.  
  
 You can use `Parse` or `TryParse` methods on the numeric type you expect the string contains, such as the <xref:System.Int32*?displayProperty=fullName> type.  The [Convert.ToUInt32](assetId:///M:System.Convert.ToUInt32(System.String)?qualifyHint=True&autoUpgrade=True) method uses [Parse](assetId:///M:System.Int32.Parse(System.String)?qualifyHint=False&autoUpgrade=True) internally.  If the string is not in a valid format, `Parse` throws an exception whereas `TryParse` returns [false](../vs140/false--csharp-reference-.md).  
  
## Example  
 The `Parse` and `TryParse` methods ignore whitespace at the beginning and at the end of the string, but all other characters must be characters that form the appropriate numeric type (int, long, ulong, float, decimal, etc.).  Any whitespace within the characters that form the number cause an error.  For example, you can use `decimal.TryParse` to parse “10”, “10.3”, “  10  “, but you cannot use this method to parse 10 from “10X”, “1 0” (note space), “10 .3” (note space), “10e1” (`float.TryParse` works here), and so on.  
  
 The examples below demonstrate both successful and unsuccessful calls to `Parse` and `TryParse`.  
  
 [!code[csProgGuideTypes#5555](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_1.cs)]  
[!code[csProgGuideTypes#25](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_2.cs)]  
[!code[csProgGuideTypes#26](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_3.cs)]  
[!code[csProgGuideTypes#27](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_4.cs)]  
[!code[csProgGuideTypes#28](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_5.cs)]  
[!code[csProgGuideTypes#100](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_6.cs)]  
  
## Example  
 The following table lists some of the methods from the <xref:System.Convert*> class that you can use.  
  
|Numeric Type|Method|  
|------------------|------------|  
|`decimal`|<xref:System.Convert.ToDecimal(System.String)>|  
|`float`|<xref:System.Convert.ToSingle(System.String)>|  
|`double`|<xref:System.Convert.ToDouble(System.String)>|  
|`short`|<xref:System.Convert.ToInt16(System.String)>|  
|`int`|<xref:System.Convert.ToInt32(System.String)>|  
|`long`|<xref:System.Convert.ToInt64(System.String)>|  
|`ushort`|<xref:System.Convert.ToUInt16(System.String)>|  
|`uint`|<xref:System.Convert.ToUInt32(System.String)>|  
|`ulong`|<xref:System.Convert.ToUInt64(System.String)>|  
  
 This example calls the <xref:System.Convert.ToInt32(System.String)?displayProperty=fullName> method to convert an input [string](../vs140/string--csharp-reference-.md) to an [int](../vs140/int--csharp-reference-.md) . The code catches the two most common exceptions that can be thrown by this method, <xref:System.FormatException*> and <xref:System.OverflowException*>. If the number can be incremented without overflowing the integer storage location, the program adds 1 to the result and prints the output.  
  
 [!code[csProgGuideTypes#5555](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_1.cs)]  
[!code[csProgGuideTypes#24](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_7.cs)]  
  
## See Also  
 [Data Types (C# Programming Guide)](../vs140/types--csharp-programming-guide-.md)   
 [How To: Determine Whether a String Contains a Numeric Value (C# Programming Guide)](../vs140/how-to--determine-whether-a-string-represents-a-numeric-value--csharp-programming-guide-.md)   
 [.NET Framework 4 Formatting Utility](http://code.msdn.microsoft.com/NET-Framework-4-Formatting-9c4dae8d)
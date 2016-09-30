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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert a String to a Number (C# Programming Guide)
You can convert a [string](../vs140/string--csharp-reference-.md) to a number by using methods in the \<xref:System.Convert*> class or by using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method found on the various numeric types (int, long, float, etc.).  
  
 If you have a string, it is slightly more efficient and straightforward to call a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method (for example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  Using a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method is more useful for general objects that implement \<xref:System.IConvertible*>.  
  
 You can use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> methods on the numeric type you expect the string contains, such as the \<xref:System.Int32*?displayProperty=fullName> type.  The \<xref:System.Convert.ToUInt32*?displayProperty=fullName> method uses \<xref:System.Int32.Parse*> internally.  If the string is not in a valid format, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> throws an exception whereas <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns [false](../vs140/false--csharp-reference-.md).  
  
## Example  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> methods ignore whitespace at the beginning and at the end of the string, but all other characters must be characters that form the appropriate numeric type (int, long, ulong, float, decimal, etc.).  Any whitespace within the characters that form the number cause an error.  For example, you can use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to parse “10”, “10.3”, “  10  “, but you cannot use this method to parse 10 from “10X”, “1 0” (note space), “10 .3” (note space), “10e1” (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> works here), and so on.  
  
 The examples below demonstrate both successful and unsuccessful calls to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 [!code[csProgGuideTypes#5555](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_1.cs)]  
[!code[csProgGuideTypes#25](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_2.cs)]  
[!code[csProgGuideTypes#26](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_3.cs)]  
[!code[csProgGuideTypes#27](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_4.cs)]  
[!code[csProgGuideTypes#28](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_5.cs)]  
[!code[csProgGuideTypes#100](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_6.cs)]  
  
## Example  
 The following table lists some of the methods from the \<xref:System.Convert*> class that you can use.  
  
|Numeric Type|Method|  
|------------------|------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<xref:System.Convert.ToDecimal(System.String)>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<xref:System.Convert.ToSingle(System.String)>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<xref:System.Convert.ToDouble(System.String)>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<xref:System.Convert.ToInt16(System.String)>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<xref:System.Convert.ToInt32(System.String)>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<xref:System.Convert.ToInt64(System.String)>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<xref:System.Convert.ToUInt16(System.String)>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<xref:System.Convert.ToUInt32(System.String)>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<xref:System.Convert.ToUInt64(System.String)>|  
  
 This example calls the \<xref:System.Convert.ToInt32(System.String)?displayProperty=fullName> method to convert an input [string](../vs140/string--csharp-reference-.md) to an [int](../vs140/int--csharp-reference-.md) . The code catches the two most common exceptions that can be thrown by this method, \<xref:System.FormatException*> and \<xref:System.OverflowException*>. If the number can be incremented without overflowing the integer storage location, the program adds 1 to the result and prints the output.  
  
 [!code[csProgGuideTypes#5555](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_1.cs)]  
[!code[csProgGuideTypes#24](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-number--csharp-programming-guide-_7.cs)]  
  
## See Also  
 [Data Types (C# Programming Guide)](../vs140/types--csharp-programming-guide-.md)   
 [How To: Determine Whether a String Contains a Numeric Value (C# Programming Guide)](../vs140/how-to--determine-whether-a-string-represents-a-numeric-value--csharp-programming-guide-.md)   
 [.NET Framework 4 Formatting Utility](http://code.msdn.microsoft.com/NET-Framework-4-Formatting-9c4dae8d)
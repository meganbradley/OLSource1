---
title: "Using Conversion Operators (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - conversions [C#], operators
  - conversion operators [C#]
  - operators [C#], conversion
  - user-defined conversions [C#]
  - implicit conversion operators [C#]
  - explicit conversion operators [C#]
ms.assetid: caf36e89-c6c0-4b87-9f9e-85780a45c9a4
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Using Conversion Operators (C# Programming Guide)
You can use `implicit` conversion operators, which are easier to use, or `explicit` conversion operators, which clearly indicate to anyone reading the code that you're converting a type. This topic demonstrates both types of conversion operator.  
  
> [!NOTE]
>  For information about simple type conversions, see [How to: Convert a String to a Number (C# Programming Guide)](../vs140/how-to--convert-a-string-to-a-number--csharp-programming-guide-.md), [How to: Convert a byte Array to an int (C# Programming Guide)](../vs140/how-to--convert-a-byte-array-to-an-int--csharp-programming-guide-.md), [How to: Convert Between Hexadecimal Strings and Numeric Types (C# Programming Guide)](../vs140/how-to--convert-between-hexadecimal-strings-and-numeric-types--csharp-programming-guide-.md), or <xref:System.Convert?qualifyHint=False>.  
  
## Example  
 This is an example of an explicit conversion operator. This operator converts from the type <xref:System.Byte?qualifyHint=False> to a value type called `Digit`. Because not all bytes can be converted to a digit, the conversion is explicit, meaning that a cast must be used, as shown in the `Main` method.  
  
 [!code[csProgGuideStatements#11](../vs140/codesnippet/CSharp/using-conversion-operators--csharp-programming-guide-_1.cs)]
  
  
## Example  
 This example demonstrates an implicit conversion operator by defining a conversion operator that undoes what the previous example did: it converts from a value class called `Digit` to the integral <xref:System.Byte?qualifyHint=False> type. Because any digit can be converted to a <xref:System.Byte?qualifyHint=False>, there's no need to force users to be explicit about the conversion.  
  
 [!code[csProgGuideStatements#12](../vs140/codesnippet/CSharp/using-conversion-operators--csharp-programming-guide-_2.cs)]
  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Conversion Operators (C#)](../vs140/conversion-operators--csharp-programming-guide-.md)   
 [is (C# Reference)](../vs140/is--csharp-reference-.md)
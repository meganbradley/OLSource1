---
title: "How to: Determine Whether a String Represents a Numeric Value (C# Programming Guide)"
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
  - "numeric strings [C#]"
  - "validating numeric input [C#]"
  - "strings [C#], numeric"
ms.assetid: a4e84e10-ea0a-489f-a868-503dded9d85f
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Determine Whether a String Represents a Numeric Value (C# Programming Guide)
To determine whether a string is a valid representation of a specified numeric type, use the static `TryParse` method that is implemented by all primitive numeric types and also by types such as <xref:System.DateTime*> and <xref:System.Net.IPAddress*>. The following example shows how to determine whether "108" is a valid [int](../vs140/int--csharp-reference-.md).  
  
```  
int i = 0;   
string s = "108";  
bool result = int.TryParse(s, out i); //i now = 108  
```  
  
 If the string contains nonnumeric characters or the numeric value is too large or too small for the particular type you have specified, `TryParse` returns false and sets the out parameter to zero. Otherwise, it returns true and sets the out parameter to the numeric value of the string.  
  
> [!NOTE]
>  A string may contain only numeric characters and still not be valid for the type whose `TryParse` method that you use. For example, "256" is not a valid value for `byte` but it is valid for `int`. "98.6" is not a valid value for `int` but it is a valid `decimal`.  
  
## Example  
 The following examples show how to use `TryParse` with string representations of `long`, `byte`, and `decimal` values.  
  
 [!code[csProgGuideStrings#14](../vs140/codesnippet/CSharp/how-to--determine-whether-a-string-represents-a-numeric-value--csharp-programming-guide-_1.cs)]  
  
## Robust Programming  
 Primitive numeric types also implement the `Parse` static method, which throws an exception if the string is not a valid number. `TryParse` is generally more efficient because it just returns false if the number is not valid.  
  
## .NET Framework Security  
 Always use the `TryParse` or `Parse` methods to validate user input from controls such as text boxes and combo boxes.  
  
## See Also  
 [How to: Convert a byte array to an int (C# Programming Guide)](../vs140/how-to--convert-a-byte-array-to-an-int--csharp-programming-guide-.md)   
 [How to: Convert a string to an int (C# Programming Guide)](../vs140/how-to--convert-a-string-to-a-number--csharp-programming-guide-.md)   
 [How to: Convert hexadecimal strings (C# Programming Guide)](../vs140/how-to--convert-between-hexadecimal-strings-and-numeric-types--csharp-programming-guide-.md)   
 [Parsing Numeric Strings](assetId:///e39324ee-72e5-42d4-a80d-bf3ee7fc6c59)   
 [Formatting Types](assetId:///0d1364da-5b30-4d42-8e6b-03378343343f)
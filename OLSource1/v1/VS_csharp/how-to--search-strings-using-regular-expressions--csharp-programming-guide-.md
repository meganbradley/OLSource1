---
title: "How to: Search Strings Using Regular Expressions (C# Programming Guide)"
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
  - "searching strings [C#]"
  - "strings [C#], searching with RegEx"
ms.assetid: dcab2150-a4a2-4fe4-87e3-83b83b58d84a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Search Strings Using Regular Expressions (C# Programming Guide)
The <xref:System.Text.RegularExpressions.Regex*?displayProperty=fullName> class can be used to search strings. These searches can range in complexity from very simple to making full use of regular expressions. The following are two examples of string searching by using the <xref:System.Text.RegularExpressions.Regex*> class. For more information, see [.NET Framework Regular Expressions](assetId:///521b3f6d-f869-42e1-93e5-158c54a6895d).  
  
## Example  
 The following code is a console application that performs a simple case-insensitive search of the strings in an array. The static method <xref:System.Text.RegularExpressions.Regex.IsMatch*?displayProperty=fullName> performs the search given the string to search and a string that contains the search pattern. In this case, a third argument is used to indicate that case should be ignored. For more information, see <xref:System.Text.RegularExpressions.RegexOptions*?displayProperty=fullName>.  
  
 [!code[csProgGuideStrings#17](../VS_csharp/codesnippet/CSharp/how-to--search-strings-using-regular-expressions--csharp-programming-guide-_1.cs)]  
  
## Example  
 The following code is a console application that uses regular expressions to validate the format of each string in an array. The validation requires that each string take the form of a telephone number in which three groups of digits are separated by dashes, the first two groups contain three digits, and the third group contains four digits. This is done by using the regular expression `^\\d{3}-\\d{3}-\\d{4}$`. For more information, see [Regular Expression Language Elements](assetId:///930653a6-95d2-4697-9d5a-52d11bb6fd4c).  
  
 [!code[csProgGuideStrings#18](../VS_csharp/codesnippet/CSharp/how-to--search-strings-using-regular-expressions--csharp-programming-guide-_2.cs)]  
  
## See Also  
 <xref:System.Text.RegularExpressions.Regex*?displayProperty=fullName>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Strings Overview (C# Programmer's Reference)](../VS_csharp/strings--csharp-programming-guide-.md)   
 [.NET Framework Regular Expressions](assetId:///521b3f6d-f869-42e1-93e5-158c54a6895d)   
 [Regular Expression Language Elements](assetId:///930653a6-95d2-4697-9d5a-52d11bb6fd4c)
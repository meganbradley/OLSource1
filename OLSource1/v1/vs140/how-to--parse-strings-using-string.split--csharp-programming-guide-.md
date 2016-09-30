---
title: "How to: Parse Strings Using String.Split (C# Programming Guide)"
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
  - "splitting strings [C#]"
  - "Split method [C#]"
  - "strings [C#], splitting"
  - "parse strings"
ms.assetid: 729c2923-4169-41c6-9c90-ef176c1e2953
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Parse Strings Using String.Split (C# Programming Guide)
The following code example demonstrates how a string can be parsed using the \<xref:System.String.Split*?displayProperty=fullName> method. As input, \<xref:System.String.Split*> takes an array of characters that indicate which characters separate interesting sub strings of the target string.  The function returns an array of the sub strings.  
  
 This example uses spaces, commas, periods, colons, and tabs, all passed in an array containing these separating characters to \<xref:System.String.Split*>.  Each word in the target string's sentence displays separately from the resulting array of strings.  
  
## Example  
 [!code[csProgGuideStrings#16](../vs140/codesnippet/CSharp/how-to--parse-strings-using-string.split--csharp-programming-guide-_1.cs)]  
  
## Example  
 By default, String.Split returns empty strings when two separating characters appear contiguously in the target string.  You can pass an optional StringSplitOptions.RemoveEmptyEntries parameter to exclude any empty strings in the output.  
  
 String.Split can take an array of strings (character sequences that act as separators for parsing the target string, instead of single characters).  
  
```c#  
class TestStringSplit  
{  
    static void Main()  
    {  
        char[] separatingChars = { "<<", "..." };  
  
        string text = "one<<two......three<four";  
        System.Console.WriteLine("Original text: '{0}'", text);  
  
        string[] words = text.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries );  
        System.Console.WriteLine("{0} substrings in text:", words.Length);  
  
        foreach (string s in words)  
        {  
            System.Console.WriteLine(s);  
        }  
  
        // Keep the console window open in debug mode.  
        System.Console.WriteLine("Press any key to exit.");  
        System.Console.ReadKey();  
    }  
}  
/* Output:  
    Original text: 'one<<two......three<four'  
    3 words in text:  
    one  
    two  
    three<four  
*/  
  
```  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Strings Overview (C# Programmer's Reference)](../vs140/strings--csharp-programming-guide-.md)   
 [.NET Framework Regular Expressions](assetId:///521b3f6d-f869-42e1-93e5-158c54a6895d)
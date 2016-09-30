---
title: "string (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "string"
  - "string_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "strings [C#], reference"
  - "@ string literal"
  - "string literals [C#]"
  - "string keyword [C#]"
ms.assetid: 3037e558-fb22-494d-bca1-a15ade11b11a
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# string (C# Reference)
The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type represents a sequence of zero or more Unicode characters. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is an alias for \<xref:System.String*> in the .NET Framework.  
  
 Although <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a reference type, the equality operators (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) are defined to compare the values of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> objects, not references. This makes testing for string equality more intuitive. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This displays "True" and then "False" because the content of the strings are equivalent, but <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> do not refer to the same string instance.  
  
 The + operator concatenates strings:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This creates a string object that contains "good morning".  
  
 Strings are *immutable*--the contents of a string object cannot be changed after the object is created, although the syntax makes it appear as if you can do this. For example, when you write this code, the compiler actually creates a new string object to hold the new sequence of characters, and that new object is assigned to b. The string "h" is then eligible for garbage collection.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [] operator can be used for readonly access to individual characters of a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 String literals are of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and can be written in two forms, quoted and @-quoted. Quoted string literals are enclosed in double quotation marks ("):  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 String literals can contain any character literal. Escape sequences are included. The following example uses escape sequence <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> for backslash, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> for the letter f, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> for newline.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
> [!NOTE]
>  The escape code <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>u<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (where <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a four-digit number) represents the Unicode character U+<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Eight-digit Unicode escape codes are also recognized: <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 Verbatim string literals start with @ and are also enclosed in double quotation marks. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The advantage of verbatim strings is that escape sequences are *not* processed, which makes it easy to write, for example, a fully qualified file name:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 To include a double quotation mark in an @-quoted string, double it:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Another use of the @ symbol is to use referenced ([/reference](../vs140/-reference--csharp-compiler-options-.md)) identifiers that are C# keywords.  
  
 For more information about strings in C#, see [Strings Overview (C# Programming Guide)](../vs140/strings--csharp-programming-guide-.md).  
  
## Example  
 [!code[csrefKeywordsTypes#17](../vs140/codesnippet/CSharp/string--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Best Practices for Using Strings in the .NET Framework](assetId:///b9f0bf53-e2de-4116-8ce9-d4f91a1df4f7)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Reference Types](../vs140/reference-types--csharp-reference-.md)   
 [Value Types](../vs140/value-types--csharp-reference-.md)   
 [Basic String Operations](assetId:///8133d357-90b5-4b62-9927-43323d99b6b6)   
 [Creating New Strings](assetId:///06fdf123-2fac-4459-8904-eb48ab908a30)   
 [Formatting Numeric Results Table](../vs140/formatting-numeric-results-table--csharp-reference-.md)
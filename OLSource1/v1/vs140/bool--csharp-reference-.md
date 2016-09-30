---
title: "bool (C# Reference)"
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
  - "bool_CSharpKeyword"
  - "bool"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "bool keyword [C#]"
ms.assetid: 551cfe35-2632-4343-af49-33ad12da08e2
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bool (C# Reference)
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword is an alias of \<xref:System.Boolean*?displayProperty=fullName>. It is used to declare variables to store the Boolean values, [true](../vs140/true--csharp-reference-.md) and [false](../vs140/false--csharp-reference-.md).  
  
> [!NOTE]
>  If you require a Boolean variable that can also have a value of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [Nullable Types (C# Programmer's Reference)](../vs140/nullable-types--csharp-programming-guide-.md).  
  
## Literals  
 You can assign a Boolean value to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable. You can also assign an expression that evaluates to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable.  
  
 [!code[csrefKeywordsTypes#1](../vs140/codesnippet/CSharp/bool--csharp-reference-_1.cs)]  
  
 The default value of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The default value of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variable is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Conversions  
 In C++, a value of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can be converted to a value of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; in other words, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is equivalent to zero and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is equivalent to nonzero values. In C#, there is no conversion between the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> type and other types. For example, the following <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement is invalid in C#:  
  
 [!code[csrefKeywordsTypes#2](../vs140/codesnippet/CSharp/bool--csharp-reference-_2.cs)]  
  
 To test a variable of the type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, you have to explicitly compare it to a value, such as zero, as follows:  
  
 [!code[csrefKeywordsTypes#3](../vs140/codesnippet/CSharp/bool--csharp-reference-_3.cs)]  
  
## Example  
 In this example, you enter a character from the keyboard and the program checks if the input character is a letter. If it is a letter, it checks if it is lowercase or uppercase. These checks are performed with the \<xref:System.Char.IsLetter*>, and \<xref:System.Char.IsLower*>, both of which return the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> type:  
  
 [!code[csrefKeywordsTypes#4](../vs140/codesnippet/CSharp/bool--csharp-reference-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)
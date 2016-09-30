---
title: "=&gt; Operator (C# Reference)"
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
  - "=>_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "lambda operator [C#]"
  - "=> operator [C#]"
  - "lambda expressions [C#], => operator"
ms.assetid: 8c899251-dafa-4594-bec7-243b39072880
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# =&gt; Operator (C# Reference)
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> token is called the lambda operator. It is used in *lambda expressions* to separate the input variables on the left side from the lambda body on the right side. Lambda expressions are inline expressions similar to anonymous methods but more flexible; they are used extensively in LINQ queries that are expressed in method syntax. For more information, see [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md).  
  
 The following example shows two ways to find and display the length of the shortest string in an array of strings. The first part of the example applies a lambda expression (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) to each element of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array and then uses the \<xref:System.Linq.Enumerable.Min*> method to find the smallest length. For comparison, the second part of the example shows a longer solution that uses query syntax to do the same thing.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator has the same precedence as the assignment operator (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) and is right-associative.  
  
 You can specify the type of the input variable explicitly or let the compiler infer it; in either case, the variable is strongly typed at compile time. When you specify a type, you must enclose the type name and the variable name in parentheses, as the following example shows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to write a lambda expression for the overload of the standard query operator \<xref:System.Linq.Enumerable.Where*?displayProperty=fullName> that takes two arguments. Because the lambda expression has more than one parameter, the parameters must be enclosed in parentheses. The second parameter, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, represents the index of the current element in the collection. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression returns all the strings whose lengths are less than their index positions in the array.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)
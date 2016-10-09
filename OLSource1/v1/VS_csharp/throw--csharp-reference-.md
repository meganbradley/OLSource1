---
title: "throw (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "throw"
  - "throw_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "throw statement [C#]"
  - "throw keyword [C#]"
ms.assetid: 5ac4feef-4b1a-4c61-aeb4-61d549e5dd42
caps.latest.revision: 22
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# throw (C# Reference)
The `throw` statement is used to signal the occurrence of an anomalous situation (exception) during the program execution.  
  
## Remarks  
 The thrown exception is an object whose class is derived from \<xref:System.Exception?displayProperty=fullName>, as shown in the following example.  
  
```  
class MyException : System.Exception {}  
// ...  
throw new MyException();  
```  
  
 Usually the `throw` statement is used with `try-catch` or `try-finally` statements.  A [throw](../VS_csharp/throw--csharp-reference-.md) statement can be used in a `catch` block to re-throw the exception that the `catch` block caught.  In this case, the [throw](../VS_csharp/throw--csharp-reference-.md) statement does not take an exception operand.  For more information and examples, see [try-catch](../VS_csharp/try-catch--csharp-reference-.md) and [How to: Explicitly Throw Exceptions](../Topic/How%20to:%20Explicitly%20Throw%20Exceptions.md).  
  
## Example  
 This example demonstrates how to throw an exception using the `throw` statement.  
  
 [!code[csrefKeywordsExceptions#5](../VS_csharp/codesnippet/CSharp/throw--csharp-reference-_1.cs)]  
  
## Code Example  
 See the examples in [try-catch](../VS_csharp/try-catch--csharp-reference-.md) and [How to: Explicitly Throw Exceptions](../Topic/How%20to:%20Explicitly%20Throw%20Exceptions.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [try-catch](../VS_csharp/try-catch--csharp-reference-.md)   
 [The try, catch, and throw Statements in C++](../VS_csharp/try-catch--csharp-reference-.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Exception Handling Statements](../VS_csharp/exception-handling-statements--csharp-reference-.md)   
 [How to: Explicitly Throw Exceptions](../Topic/How%20to:%20Explicitly%20Throw%20Exceptions.md)
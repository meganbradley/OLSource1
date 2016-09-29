---
title: "throw (C# Reference)"
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
  - "throw"
  - "throw_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "throw statement [C#]"
  - "throw keyword [C#]"
ms.assetid: 5ac4feef-4b1a-4c61-aeb4-61d549e5dd42
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# throw (C# Reference)
The `throw` statement is used to signal the occurrence of an anomalous situation (exception) during the program execution.  
  
## Remarks  
 The thrown exception is an object whose class is derived from <xref:System.Exception*?displayProperty=fullName>, as shown in the following example.  
  
```  
class MyException : System.Exception {}  
// ...  
throw new MyException();  
```  
  
 Usually the `throw` statement is used with `try-catch` or `try-finally` statements.  A [throw](../vs140/throw--csharp-reference-.md) statement can be used in a `catch` block to re-throw the exception that the `catch` block caught.  In this case, the [throw](../vs140/throw--csharp-reference-.md) statement does not take an exception operand.  For more information and examples, see [try-catch (C# Reference)](../vs140/try-catch--csharp-reference-.md) and [How to: Explicitly Throw Exceptions](assetId:///72bdd157-caa9-4478-9ee3-cb4500b84528).  
  
## Example  
 This example demonstrates how to throw an exception using the `throw` statement.  
  
 [!code[csrefKeywordsExceptions#5](../vs140/codesnippet/CSharp/throw--csharp-reference-_1.cs)]  
  
## Code Example  
 See the examples in [try-catch (C# Reference)](../vs140/try-catch--csharp-reference-.md) and [How to: Explicitly Throw Exceptions](assetId:///72bdd157-caa9-4478-9ee3-cb4500b84528).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [try-catch (C# Reference)](../vs140/try-catch--csharp-reference-.md)   
 [The try, catch, and throw Statements in C++](../vs140/try-catch--csharp-reference-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Exception Handling Statements](../vs140/exception-handling-statements--csharp-reference-.md)   
 [Throwing Exceptions](assetId:///72bdd157-caa9-4478-9ee3-cb4500b84528)
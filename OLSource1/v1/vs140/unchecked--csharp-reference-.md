---
title: "unchecked (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - unchecked_CSharpKeyword
  - unchecked
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - unchecked keyword [C#]
ms.assetid: 0c021f7c-923f-4b3d-a58f-55336f5ac27e
caps.latest.revision: 27
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unchecked (C# Reference)
The `unchecked` keyword is used to suppress overflow-checking for integral-type arithmetic operations and conversions.  
  
 In an unchecked context, if an expression produces a value that is outside the range of the destination type, the overflow is not flagged. For example, because the calculation in the following example is performed in an `unchecked` block or expression, the fact that the result is too large for an integer is ignored, and `int1` is assigned the value -2,147,483,639.  
  
 [!code[csrefKeywordsChecked#5](../vs140/codesnippet/CSharp/unchecked--csharp-reference-_1.cs)]
  
  
 If the `unchecked` environment is removed, a compilation error occurs. The overflow can be detected at compile time because all the terms of the expression are constants.  
  
 Expressions that contain non-constant terms are unchecked by default at compile time and run time. See [checked (C# Reference)](../vs140/checked--csharp-reference-.md) for information about enabling a checked environment.  
  
 Because checking for overflow takes time, the use of unchecked code in situations where there is no danger of overflow might improve performance. However, if overflow is a possibility, a checked environment should be used.  
  
## Example  
 This sample shows how to use the `unchecked` keyword.  
  
 [!code[csrefKeywordsChecked#2](../vs140/codesnippet/CSharp/unchecked--csharp-reference-_2.cs)]
  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Checked and Unchecked](../vs140/checked-and-unchecked--csharp-reference-.md)   
 [checked](../vs140/checked--csharp-reference-.md)
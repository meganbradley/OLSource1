---
title: "Anonymous Functions (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "lambda expressions [C#], as anonymus functions"
  - "anonymous functions [C#]"
  - "anonymous methods [C#]"
ms.assetid: 6ce3f04d-0c71-4728-9127-634c7e9a8365
caps.latest.revision: 14
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
# Anonymous Functions (C# Programming Guide)
An anonymous function is an "inline" statement or expression that can be used wherever a delegate type is expected. You can use it to initialize a named delegate or pass it instead of a named delegate type as a method parameter.  
  
 There are two kinds of anonymous functions, which are discussed individually in the following topics:  
  
-   [Lambda Expressions](../VS_csharp/lambda-expressions--csharp-programming-guide-.md).  
  
-   [Anonymous Methods](../VS_csharp/anonymous-methods--csharp-programming-guide-.md)  
  
    > [!NOTE]
    >  Lambda expressions can be bound to expression trees and also to delegates.  
  
## The Evolution of Delegates in C#  
 In C# 1.0, you created an instance of a delegate by explicitly initializing it with a method that was defined elsewhere in the code. C# 2.0 introduced the concept of anonymous methods as a way to write unnamed inline statement blocks that can be executed in a delegate invocation. C# 3.0 introduced lambda expressions, which are similar in concept to anonymous methods but more expressive and concise. These two features are known collectively as *anonymous functions*. In general, applications that target version 3.5 and later of the [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] should use lambda expressions.  
  
 The following example demonstrates the evolution of delegate creation from C# 1.0 to C# 3.0:  
  
 [!code[csProgGuideLINQ#65](../VS_csharp/codesnippet/CSharp/anonymous-functions--csharp-programming-guide-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [Statements, Expressions, and Operators](../VS_csharp/statements--expressions--and-operators--csharp-programming-guide-.md)   
 [Lambda Expressions](../VS_csharp/lambda-expressions--csharp-programming-guide-.md)   
 [Delegates](../VS_csharp/delegates--csharp-programming-guide-.md)   
 [Expression Trees](../Topic/Expression%20Trees%20\(C%23%20and%20Visual%20Basic\).md)
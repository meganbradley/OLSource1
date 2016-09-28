---
title: "params (C# Reference)"
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
  - "params_CSharpKeyword"
  - "params"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "parameters [C#], params"
  - "params keyword [C#]"
ms.assetid: 1690815e-b52b-4967-8380-5780aff08012
caps.latest.revision: 28
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# params (C# Reference)
By using the `params` keyword, you can specify a [method parameter](../vs140/method-parameters--csharp-reference-.md) that takes a variable number of arguments.  
  
 You can send a comma-separated list of arguments of the type specified in the parameter declaration or an array of arguments of the specified type. You also can send no arguments. If you send no arguments, the length of the `params` list is zero.  
  
 No additional parameters are permitted after the `params` keyword in a method declaration, and only one `params` keyword is permitted in a method declaration.  
  
## Example  
 The following example demonstrates various ways in which arguments can be sent to a `params` parameter.  
  
 [!code[csrefKeywordsMethodParams#5](../vs140/codesnippet/CSharp/params--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Method Parameters](../vs140/method-parameters--csharp-reference-.md)
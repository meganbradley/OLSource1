---
title: "Passing Parameters (C# Programming Guide)"
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
  - "parameters [C#], passing"
  - "passing parameters [C#]"
  - "arguments [C#]"
  - "methods [C#], passing parameters"
  - "C# language, method parameters"
ms.assetid: a5c3003f-7441-4710-b8b1-c79de77e0b77
caps.latest.revision: 17
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
# Passing Parameters (C# Programming Guide)
In C#, arguments can be passed to parameters either by value or by reference. Passing by reference enables function members, methods, properties, indexers, operators, and constructors to change the value of the parameters and have that change persist in the calling environment. To pass a parameter by reference, use the `ref` or `out` keyword. For simplicity, only the `ref` keyword is used in the examples in this topic. For more information about the difference between `ref` and `out`, see [ref](../VS_csharp/ref--csharp-reference-.md), [out](../VS_csharp/out--csharp-reference-.md), and [Passing Arrays Using ref and out](../VS_csharp/passing-arrays-using-ref-and-out--csharp-programming-guide-.md).  
  
 The following example illustrates the difference between value and reference parameters.  
  
 [!code[csProgGuideParameters#10](../VS_csharp/codesnippet/CSharp/passing-parameters--csharp-programming-guide-_1.cs)]  
  
 For more information, see the following topics:  
  
-   [Passing Value-Type Parameters](../VS_csharp/passing-value-type-parameters--csharp-programming-guide-.md)  
  
-   [Passing Reference-Type Parameters](../VS_csharp/passing-reference-type-parameters--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Methods](../VS_csharp/methods--csharp-programming-guide-.md)
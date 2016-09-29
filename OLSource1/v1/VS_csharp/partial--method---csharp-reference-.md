---
title: "partial (Method) (C# Reference)"
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
  - "partialmethod_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "partial methods [C#]"
ms.assetid: 43f40242-17e0-4452-8573-090503ad3137
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partial (Method) (C# Reference)
A partial method has its signature defined in one part of a partial type, and its implementation defined in another part of the type. Partial methods enable class designers to provide method hooks, similar to event handlers, that developers may decide to implement or not. If the developer does not supply an implementation, the compiler removes the signature at compile time. The following conditions apply to partial methods:  
  
-   Signatures in both parts of the partial type must match.  
  
-   The method must return void.  
  
-   No access modifiers are allowed. Partial methods are implicitly private.  
  
 The following example shows a partial method defined in two parts of a partial class:  
  
 [!code[csrefKeywordsContextual#9](../VS_csharp/codesnippet/CSharp/partial--method---csharp-reference-_1.cs)]  
  
 For more information, see [Partial Classes and Methods (C# Programming Guide)](../VS_csharp/partial-classes-and-methods--csharp-programming-guide-.md).  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [partial (Type) (C# Reference)](../VS_csharp/partial--type---csharp-reference-.md)
---
title: "delegate (C# Reference)"
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
  - "delegate_CSharpKeyword"
  - "delegate"
  - "CS0123"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "delegate keyword [C#]"
  - "function pointers [C#]"
ms.assetid: 0bb8cb6d-2f87-47c7-9d1f-d65c1cd01e9f
caps.latest.revision: 24
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
# delegate (C# Reference)
The declaration of a delegate type is similar to a method signature. It has a return value and any number of parameters of any type:  
  
```  
public delegate void TestDelegate(string message);  
public delegate int TestDelegate(MyType m, long num);  
```  
  
 A `delegate` is a reference type that can be used to encapsulate a named or an anonymous method. Delegates are similar to function pointers in C++; however, delegates are type-safe and secure. For applications of delegates, see [Delegates](../VS_csharp/delegates--csharp-programming-guide-.md) and [Generic Delegates](../VS_csharp/generic-delegates--csharp-programming-guide-.md).  
  
## Remarks  
 Delegates are the basis for [Events](../VS_csharp/events--csharp-programming-guide-.md).  
  
 A delegate can be instantiated by associating it either with a named or anonymous method. For more information, see [Named Methods](../VS_csharp/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md) and [Anonymous Methods](../VS_csharp/anonymous-methods--csharp-programming-guide-.md).  
  
 The delegate must be instantiated with a method or lambda expression that has a compatible return type and input parameters. For more information on the degree of variance that is allowed in the method signature, see [Variance in Delegates](../Topic/Variance%20in%20Delegates%20\(C%23%20and%20Visual%20Basic\).md). For use with anonymous methods, the delegate and the code to be associated with it are declared together. Both ways of instantiating delegates are discussed in this section.  
  
## Example  
 [!code[csrefKeywordsTypes#8](../VS_csharp/codesnippet/CSharp/delegate--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Reference Types](../VS_csharp/reference-types--csharp-reference-.md)   
 [Delegates](../VS_csharp/delegates--csharp-programming-guide-.md)   
 [Events](../VS_csharp/events--csharp-programming-guide-.md)   
 [Delegates with Named vs. Anonymous Methods](../VS_csharp/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md)   
 [Anonymous Methods](../VS_csharp/anonymous-methods--csharp-programming-guide-.md)
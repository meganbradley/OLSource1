---
title: "delegate (C# Reference)"
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
  - delegate_CSharpKeyword
  - delegate
  - CS0123
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - delegate keyword [C#]
  - function pointers [C#]
ms.assetid: 0bb8cb6d-2f87-47c7-9d1f-d65c1cd01e9f
caps.latest.revision: 28
translation.priority.ht: 
  - de-de
  - ja-jp
---
# delegate (C# Reference)
The declaration of a delegate type is similar to a method signature. It has a return value and any number of parameters of any type:  
  
```  
public delegate void TestDelegate(string message);  
public delegate int TestDelegate(MyType m, long num);  
```  
  
 A `delegate` is a reference type that can be used to encapsulate a named or an anonymous method. Delegates are similar to function pointers in C++; however, delegates are type-safe and secure. For applications of delegates, see [Delegates](../vs140/delegates--csharp-programming-guide-.md) and [Generic Delegates](../vs140/generic-delegates--csharp-programming-guide-.md).  
  
## Remarks  
 Delegates are the basis for [Events](../vs140/events--csharp-programming-guide-.md).  
  
 A delegate can be instantiated by associating it either with a named or anonymous method. For more information, see [Named Methods](../vs140/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md) and [Anonymous Methods](../vs140/anonymous-methods--csharp-programming-guide-.md).  
  
 The delegate must be instantiated with a method or lambda expression that has a compatible return type and input parameters. For more information on the degree of variance that is allowed in the method signature, see [Variance in Generic Delegates](../vs140/variance-in-delegates--csharp-and-visual-basic-.md). For use with anonymous methods, the delegate and the code to be associated with it are declared together. Both ways of instantiating delegates are discussed in this section.  
  
## Example  
 [!code[csrefKeywordsTypes#8](../vs140/codesnippet/CSharp/delegate--csharp-reference-_1.cs)]
  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Reference Types](../vs140/reference-types--csharp-reference-.md)   
 [Delegates (Visual C#)](../vs140/delegates--csharp-programming-guide-.md)   
 [Events (C#)](../vs140/events--csharp-programming-guide-.md)   
 [Named Methods](../vs140/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md)   
 [Anonymous Methods](../vs140/anonymous-methods--csharp-programming-guide-.md)
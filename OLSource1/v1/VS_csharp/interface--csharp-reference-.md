---
title: "interface (C# Reference)"
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
  - "interface_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "interface keyword [C#]"
ms.assetid: 7da38e81-4f99-4bc5-b07d-c986b687eeba
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# interface (C# Reference)
An interface contains only the signatures of [methods](../VS_csharp/methods--csharp-programming-guide-.md), [properties](../VS_csharp/properties--csharp-programming-guide-.md), [events](../VS_csharp/events--csharp-programming-guide-.md) or [indexers](../VS_csharp/indexers--csharp-programming-guide-.md). A class or struct that implements the interface must implement the members of the interface that are specified in the interface definition. In the following example, class `ImplementationClass` must implement a method named `SampleMethod` that has no parameters and returns `void`.  
  
 For more information and examples, see [Interfaces (C# Programming Guide)](../VS_csharp/interfaces--csharp-programming-guide-.md).  
  
## Example  
 [!code[csrefKeywordsTypes#14](../VS_csharp/codesnippet/CSharp/interface--csharp-reference-_1.cs)]  
  
 An interface can be a member of a namespace or a class and can contain signatures of the following members:  
  
-   [Methods](../VS_csharp/methods--csharp-programming-guide-.md)  
  
-   [Properties](../VS_csharp/using-properties--csharp-programming-guide-.md)  
  
-   [Indexers](../VS_csharp/using-indexers--csharp-programming-guide-.md)  
  
-   [Events](../VS_csharp/event--csharp-reference-.md)  
  
 An interface can inherit from one or more base interfaces.  
  
 When a base type list contains a base class and interfaces, the base class must come first in the list.  
  
 A class that implements an interface can explicitly implement members of that interface. An explicitly implemented member cannot be accessed through a class instance, but only through an instance of the interface.  
  
 For more details and code examples on explicit interface implementation, see [Explicit Interface Implementation (Visual C#)](../VS_csharp/explicit-interface-implementation--csharp-programming-guide-.md).  
  
## Example  
 The following example demonstrates interface implementation. In this example, the interface contains the property declaration and the class contains the implementation. Any instance of a class that implements `IPoint` has integer properties `x` and `y`.  
  
 [!code[csrefKeywordsTypes#15](../VS_csharp/codesnippet/CSharp/interface--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Reference Types](../VS_csharp/reference-types--csharp-reference-.md)   
 [Interfaces](../VS_csharp/interfaces--csharp-programming-guide-.md)   
 [Using Properties](../VS_csharp/using-properties--csharp-programming-guide-.md)   
 [Using Indexers](../VS_csharp/using-indexers--csharp-programming-guide-.md)   
 [class](../VS_csharp/class--csharp-reference-.md)   
 [struct](../VS_csharp/struct--csharp-reference-.md)   
 [Interfaces (C# Programming Guide)](../VS_csharp/interfaces--csharp-programming-guide-.md)
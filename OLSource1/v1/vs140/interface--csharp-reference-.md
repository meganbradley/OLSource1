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
An interface contains only the signatures of [methods](../vs140/methods--csharp-programming-guide-.md), [properties](../vs140/properties--csharp-programming-guide-.md), [events](../vs140/events--csharp-programming-guide-.md) or [indexers](../vs140/indexers--csharp-programming-guide-.md). A class or struct that implements the interface must implement the members of the interface that are specified in the interface definition. In the following example, class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> must implement a method named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that has no parameters and returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 For more information and examples, see [Interfaces (C# Programming Guide)](../vs140/interfaces--csharp-programming-guide-.md).  
  
## Example  
 [!code[csrefKeywordsTypes#14](../vs140/codesnippet/CSharp/interface--csharp-reference-_1.cs)]  
  
 An interface can be a member of a namespace or a class and can contain signatures of the following members:  
  
-   [Methods](../vs140/methods--csharp-programming-guide-.md)  
  
-   [Properties](../vs140/using-properties--csharp-programming-guide-.md)  
  
-   [Indexers](../vs140/using-indexers--csharp-programming-guide-.md)  
  
-   [Events](../vs140/event--csharp-reference-.md)  
  
 An interface can inherit from one or more base interfaces.  
  
 When a base type list contains a base class and interfaces, the base class must come first in the list.  
  
 A class that implements an interface can explicitly implement members of that interface. An explicitly implemented member cannot be accessed through a class instance, but only through an instance of the interface.  
  
 For more details and code examples on explicit interface implementation, see [Explicit Interface Implementation (Visual C#)](../vs140/explicit-interface-implementation--csharp-programming-guide-.md).  
  
## Example  
 The following example demonstrates interface implementation. In this example, the interface contains the property declaration and the class contains the implementation. Any instance of a class that implements <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has integer properties <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [!code[csrefKeywordsTypes#15](../vs140/codesnippet/CSharp/interface--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Reference Types](../vs140/reference-types--csharp-reference-.md)   
 [Interfaces](../vs140/interfaces--csharp-programming-guide-.md)   
 [Using Properties](../vs140/using-properties--csharp-programming-guide-.md)   
 [Using Indexers](../vs140/using-indexers--csharp-programming-guide-.md)   
 [class](../vs140/class--csharp-reference-.md)   
 [struct](../vs140/struct--csharp-reference-.md)   
 [Interfaces (C# Programming Guide)](../vs140/interfaces--csharp-programming-guide-.md)
---
title: "base (C# Reference)"
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
  - "base"
  - "BaseClass.BaseClass"
  - "base_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "base keyword [C#]"
ms.assetid: 8b645dbe-1a33-49b8-8716-1c401f9a5ea5
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# base (C# Reference)
The `base` keyword is used to access members of the base class from within a derived class:  
  
-   Call a method on the base class that has been overridden by another method.  
  
-   Specify which base-class constructor should be called when creating instances of the derived class.  
  
 A base class access is permitted only in a constructor, an instance method, or an instance property accessor.  
  
 It is an error to use the `base` keyword from within a static method.  
  
 The base class that is accessed is the base class specified in the class declaration. For example, if you specify `class ClassB : ClassA`, the members of ClassA are accessed from ClassB, regardless of the base class of ClassA.  
  
## Example  
 In this example, both the base class, `Person`, and the derived class, `Employee`, have a method named `Getinfo`. By using the `base` keyword, it is possible to call the `Getinfo` method on the base class, from within the derived class.  
  
 [!code[csrefKeywordsAccess#1](../vs140/codesnippet/CSharp/base--csharp-reference-_1.cs)]  
  
 For additional examples, see [new](../vs140/new--csharp-reference-.md), [virtual](../vs140/virtual--csharp-reference-.md), and [override](../vs140/override--csharp-reference-.md).  
  
## Example  
 This example shows how to specify the base-class constructor called when creating instances of a derived class.  
  
 [!code[csrefKeywordsAccess#2](../vs140/codesnippet/CSharp/base--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [this](../vs140/this--csharp-reference-.md)
---
title: "base (C# Reference)"
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
  - "base"
  - "BaseClass.BaseClass"
  - "base_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "base keyword [C#]"
ms.assetid: 8b645dbe-1a33-49b8-8716-1c401f9a5ea5
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
# base (C# Reference)
The `base` keyword is used to access members of the base class from within a derived class:  
  
-   Call a method on the base class that has been overridden by another method.  
  
-   Specify which base-class constructor should be called when creating instances of the derived class.  
  
 A base class access is permitted only in a constructor, an instance method, or an instance property accessor.  
  
 It is an error to use the `base` keyword from within a static method.  
  
 The base class that is accessed is the base class specified in the class declaration. For example, if you specify `class ClassB : ClassA`, the members of ClassA are accessed from ClassB, regardless of the base class of ClassA.  
  
## Example  
 In this example, both the base class, `Person`, and the derived class, `Employee`, have a method named `Getinfo`. By using the `base` keyword, it is possible to call the `Getinfo` method on the base class, from within the derived class.  
  
 [!code[csrefKeywordsAccess#1](../VS_csharp/codesnippet/CSharp/base--csharp-reference-_1.cs)]  
  
 For additional examples, see [new](../VS_csharp/new--csharp-reference-.md), [virtual](../VS_csharp/virtual--csharp-reference-.md), and [override](../VS_csharp/override--csharp-reference-.md).  
  
## Example  
 This example shows how to specify the base-class constructor called when creating instances of a derived class.  
  
 [!code[csrefKeywordsAccess#2](../VS_csharp/codesnippet/CSharp/base--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [this](../VS_csharp/this--csharp-reference-.md)
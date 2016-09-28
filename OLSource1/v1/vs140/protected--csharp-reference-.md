---
title: "protected (C# Reference)"
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
  - "protected"
  - "protected_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "protected keyword [C#]"
ms.assetid: 05ce3794-6675-4025-bddb-eaaa0ec22892
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# protected (C# Reference)
The `protected` keyword is a member access modifier. A protected member is accessible within its class and by derived class instances. For a comparison of `protected` with the other access modifiers, see [Accessibility Levels](../vs140/accessibility-levels--csharp-reference-.md).  
  
## Example  
 A protected member of a base class is accessible in a derived class only if the access occurs through the derived class type. For example, consider the following code segment:  
  
 [!code[csrefKeywordsModifiers#11](../vs140/codesnippet/CSharp/protected--csharp-reference-_1.cs)]  
  
 The statement `a.x = 10` generates an error because it is made within the static method Main, and not an instance of class B.  
  
 Struct members cannot be protected because the struct cannot be inherited.  
  
## Example  
 In this example, the class `DerivedPoint` is derived from `Point`. Therefore, you can access the protected members of the base class directly from the derived class.  
  
 [!code[csrefKeywordsModifiers#12](../vs140/codesnippet/CSharp/protected--csharp-reference-_2.cs)]  
  
 If you change the access levels of `x` and `y` to [private](../vs140/private--csharp-reference-.md), the compiler will issue the error messages:  
  
 `'Point.y' is inaccessible due to its protection level.`  
  
 `'Point.x' is inaccessible due to its protection level.`  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Access Modifiers](../vs140/access-modifiers--csharp-reference-.md)   
 [Accessibility Levels](../vs140/accessibility-levels--csharp-reference-.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [public (C# Programmer's Reference)](../vs140/public--csharp-reference-.md)   
 [private (C# Programmer's Reference)](../vs140/private--csharp-reference-.md)   
 [internal (C# Programmer's Reference)](../vs140/internal--csharp-reference-.md)
---
title: "protected (C# Reference)"
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
  - "protected"
  - "protected_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "protected keyword [C#]"
ms.assetid: 05ce3794-6675-4025-bddb-eaaa0ec22892
caps.latest.revision: 20
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
# protected (C# Reference)
The `protected` keyword is a member access modifier. A protected member is accessible within its class and by derived class instances. For a comparison of `protected` with the other access modifiers, see [Accessibility Levels](../VS_csharp/accessibility-levels--csharp-reference-.md).  
  
## Example  
 A protected member of a base class is accessible in a derived class only if the access occurs through the derived class type. For example, consider the following code segment:  
  
 [!code[csrefKeywordsModifiers#11](../VS_csharp/codesnippet/CSharp/protected--csharp-reference-_1.cs)]  
  
 The statement `a.x = 10` generates an error because it is made within the static method Main, and not an instance of class B.  
  
 Struct members cannot be protected because the struct cannot be inherited.  
  
## Example  
 In this example, the class `DerivedPoint` is derived from `Point`. Therefore, you can access the protected members of the base class directly from the derived class.  
  
 [!code[csrefKeywordsModifiers#12](../VS_csharp/codesnippet/CSharp/protected--csharp-reference-_2.cs)]  
  
 If you change the access levels of `x` and `y` to [private](../VS_csharp/private--csharp-reference-.md), the compiler will issue the error messages:  
  
 `'Point.y' is inaccessible due to its protection level.`  
  
 `'Point.x' is inaccessible due to its protection level.`  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Access Modifiers](../VS_csharp/access-modifiers--csharp-reference-.md)   
 [Accessibility Levels](../VS_csharp/accessibility-levels--csharp-reference-.md)   
 [Modifiers](../VS_csharp/modifiers--csharp-reference-.md)   
 [public](../VS_csharp/public--csharp-reference-.md)   
 [private](../VS_csharp/private--csharp-reference-.md)   
 [internal](../VS_csharp/internal--csharp-reference-.md)
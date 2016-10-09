---
title: "Implicitly Typed Arrays (C# Programming Guide)"
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
  - "arrays [C#], implicity-typed"
  - "implicitly-typed arrays [C#]"
  - "C# language, implicitly typed arrays"
ms.assetid: e05be95c-6732-403d-ae42-b35f057cbbea
caps.latest.revision: 13
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
# Implicitly Typed Arrays (C# Programming Guide)
You can create an implicitly-typed array in which the type of the array instance is inferred from the elements specified in the array initializer. The rules for any implicitly-typed variable also apply to implicitly-typed arrays. For more information, see [Implicitly Typed Local Variables](../VS_csharp/implicitly-typed-local-variables--csharp-programming-guide-.md).  
  
 Implicitly-typed arrays are usually used in query expressions together with anonymous types and object and collection initializers.  
  
 The following examples show how to create an implicitly-typed array:  
  
 [!code[csProgGuideLINQ#37](../VS_csharp/codesnippet/CSharp/implicitly-typed-arrays--csharp-programming-guide-_1.cs)]  
  
 In the previous example, notice that with implicitly-typed arrays, no square brackets are used on the left side of the initialization statement. Note also that jagged arrays are initialized by using `new []` just like single-dimension arrays.  
  
## Implicitly-typed Arrays in Object Initializers  
 When you create an anonymous type that contains an array, the array must be implicitly typed in the type's object initializer. In the following example, `contacts` is an implicitly-typed array of anonymous types, each of which contains an array named `PhoneNumbers`. Note that the `var` keyword is not used inside the object initializers.  
  
 [!code[csProgGuideLINQ#38](../VS_csharp/codesnippet/CSharp/implicitly-typed-arrays--csharp-programming-guide-_2.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Implicitly Typed Local Variables](../VS_csharp/implicitly-typed-local-variables--csharp-programming-guide-.md)   
 [Arrays](../VS_csharp/arrays--csharp-programming-guide-.md)   
 [Anonymous Types](../VS_csharp/anonymous-types--csharp-programming-guide-.md)   
 [Object and Collection Initializers](../VS_csharp/object-and-collection-initializers--csharp-programming-guide-.md)   
 [var](../VS_csharp/var--csharp-reference-.md)   
 [LINQ Query Expressions](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)
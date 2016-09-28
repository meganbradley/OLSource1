---
title: "this (C# Reference)"
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
  - "this"
  - "this_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "this keyword [C#]"
ms.assetid: d4f827fe-4710-410b-89b8-867dad44b8a3
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# this (C# Reference)
The `this` keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method.  
  
> [!NOTE]
>  This article discusses the use of `this` with class instances. For more information about its use in extension methods, see [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md).  
  
 The following are common uses of `this`:  
  
-   To qualify members hidden by similar names, for example:  
  
 [!code[csrefKeywordsAccess#4](../vs140/codesnippet/CSharp/this--csharp-reference-_1.cs)]  
  
-   To pass an object as a parameter to other methods, for example:  
  
    ```  
    CalcTax(this);  
    ```  
  
-   To declare indexers, for example:  
  
 [!code[csrefKeywordsAccess#5](../vs140/codesnippet/CSharp/this--csharp-reference-_2.cs)]  
  
 Static member functions, because they exist at the class level and not as part of an object, do not have a `this` pointer. It is an error to refer to `this` in a static method.  
  
## Example  
 In this example, `this` is used to qualify the `Employee` class members, `name` and `alias`, which are hidden by similar names. It is also used to pass an object to the method `CalcTax`, which belongs to another class.  
  
 [!code[csrefKeywordsAccess#3](../vs140/codesnippet/CSharp/this--csharp-reference-_3.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [base](../vs140/base--csharp-reference-.md)   
 [Class and Struct Methods (C# Programmers Reference)](../vs140/methods--csharp-programming-guide-.md)
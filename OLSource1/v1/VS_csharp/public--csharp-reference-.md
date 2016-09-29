---
title: "public (C# Reference)"
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
  - "public"
  - "public_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "public keyword [C#]"
ms.assetid: 0ae45d16-a551-4b74-9845-57208de1328e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# public (C# Reference)
The `public` keyword is an access modifier for types and type members. Public access is the most permissive access level. There are no restrictions on accessing public members, as in this example:  
  
```  
class SampleClass  
{  
    public int x; // No access restrictions.  
}  
```  
  
 See [Access Modifiers (C# Programming Guide)](../VS_csharp/access-modifiers--csharp-programming-guide-.md) and [Accessibility Levels](../VS_csharp/accessibility-levels--csharp-reference-.md) for more information.  
  
## Example  
 In the following example, two classes are declared, `PointTest` and `MainClass`. The public members `x` and `y` of `PointTest` are accessed directly from `MainClass`.  
  
 [!code[csrefKeywordsModifiers#13](../VS_csharp/codesnippet/CSharp/public--csharp-reference-_1.cs)]  
  
 If you change the `public` access level to [private](../VS_csharp/private--csharp-reference-.md) or [protected](../VS_csharp/protected--csharp-reference-.md), you will get the error message:  
  
 'PointTest.y' is inaccessible due to its protection level.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Access Modifiers (C# Programming Guide)](../VS_csharp/access-modifiers--csharp-programming-guide-.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Access Modifiers](../VS_csharp/access-modifiers--csharp-reference-.md)   
 [Accessibility Levels](../VS_csharp/accessibility-levels--csharp-reference-.md)   
 [Modifiers](../VS_csharp/modifiers--csharp-reference-.md)   
 [private (C# Programmer's Reference)](../VS_csharp/private--csharp-reference-.md)   
 [protected (C# Programmer's Reference)](../VS_csharp/protected--csharp-reference-.md)   
 [internal (C# Programmer's Reference)](../VS_csharp/internal--csharp-reference-.md)
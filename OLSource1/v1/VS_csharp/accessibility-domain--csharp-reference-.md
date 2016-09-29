---
title: "Accessibility Domain (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
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
  - "accessibility domain [C#]"
ms.assetid: 8af779c1-275b-44be-a864-9edfbca71bcc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessibility Domain (C# Reference)
The accessibility domain of a member specifies in which program sections a member can be referenced. If the member is nested within another type, its accessibility domain is determined by both the [accessibility level](../VS_csharp/accessibility-levels--csharp-reference-.md) of the member and the accessibility domain of the immediately containing type.  
  
 The accessibility domain of a top-level type is at least the program text of the project that it is declared in. That is, the domain includes all of the source files of this project. The accessibility domain of a nested type is at least the program text of the type in which it is declared. That is, the domain is the type body, which includes all nested types. The accessibility domain of a nested type never exceeds that of the containing type. These concepts are demonstrated in the following example.  
  
## Example  
 This example contains a top-level type, `T1`, and two nested classes, `M1` and `M2`. The classes contain fields that have different declared accessibilities. In the `Main` method, a comment follows each statement to indicate the accessibility domain of each member. Notice that the statements that try to reference the inaccessible members are commented out. If you want to see the compiler errors caused by referencing an inaccessible member, remove the comments one at a time.  
  
 [!code[csrefKeywordsModifiers#4](../VS_csharp/codesnippet/CSharp/accessibility-domain--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Access Modifiers](../VS_csharp/access-modifiers--csharp-reference-.md)   
 [Accessibility Levels](../VS_csharp/accessibility-levels--csharp-reference-.md)   
 [Restrictions on Using Accessibility Levels](../VS_csharp/restrictions-on-using-accessibility-levels--csharp-reference-.md)   
 [Access Modifiers (Visual C#)](../VS_csharp/access-modifiers--csharp-programming-guide-.md)   
 [public (C# Programmer's Reference)](../VS_csharp/public--csharp-reference-.md)   
 [private (C# Programmer's Reference)](../VS_csharp/private--csharp-reference-.md)   
 [protected (C# Programmer's Reference)](../VS_csharp/protected--csharp-reference-.md)   
 [internal (C# Programmer's Reference)](../VS_csharp/internal--csharp-reference-.md)
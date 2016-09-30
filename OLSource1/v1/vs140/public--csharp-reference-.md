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
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword is an access modifier for types and type members. Public access is the most permissive access level. There are no restrictions on accessing public members, as in this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 See [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md) and [Accessibility Levels](../vs140/accessibility-levels--csharp-reference-.md) for more information.  
  
## Example  
 In the following example, two classes are declared, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The public members <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are accessed directly from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [!code[csrefKeywordsModifiers#13](../vs140/codesnippet/CSharp/public--csharp-reference-_1.cs)]  
  
 If you change the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> access level to [private](../vs140/private--csharp-reference-.md) or [protected](../vs140/protected--csharp-reference-.md), you will get the error message:  
  
 'PointTest.y' is inaccessible due to its protection level.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Access Modifiers](../vs140/access-modifiers--csharp-reference-.md)   
 [Accessibility Levels](../vs140/accessibility-levels--csharp-reference-.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [private (C# Programmer's Reference)](../vs140/private--csharp-reference-.md)   
 [protected (C# Programmer's Reference)](../vs140/protected--csharp-reference-.md)   
 [internal (C# Programmer's Reference)](../vs140/internal--csharp-reference-.md)
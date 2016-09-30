---
title: "private (C# Reference)"
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
  - "private_CSharpKeyword"
  - "private"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "private keyword [C#]"
ms.assetid: 654c0bb8-e6ac-4086-bf96-7474fa6aa1c8
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# private (C# Reference)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword is a member access modifier. Private access is the least permissive access level. Private members are accessible only within the body of the class or the struct in which they are declared, as in this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Nested types in the same body can also access those private members.  
  
 It is a compile-time error to reference a private member outside the class or the struct in which it is declared.  
  
 For a comparison of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with the other access modifiers, see [Accessibility Levels](../vs140/accessibility-levels--csharp-reference-.md) and [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
## Example  
 In this example, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class contains two private data members, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. As private members, they cannot be accessed except by member methods. Public methods named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are added to allow controlled access to the private members. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member is accessed by way of a public method, and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member is accessed by way of a public read-only property. (See [Properties (C# Programming Guide)](../vs140/properties--csharp-programming-guide-.md) for more information.)  
  
 [!code[csrefKeywordsModifiers#10](../vs140/codesnippet/CSharp/private--csharp-reference-_1.cs)]  
  
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
 [protected (C# Programmer's Reference)](../vs140/protected--csharp-reference-.md)   
 [internal (C# Programmer's Reference)](../vs140/internal--csharp-reference-.md)
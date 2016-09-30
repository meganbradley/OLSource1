---
title: "internal (C# Reference)"
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
  - "internal_CSharpKeyword"
  - "internal"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "internal keyword [C#]"
ms.assetid: 6ee0785c-d7c8-49b8-bb72-0a4dfbcb6461
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# internal (C# Reference)
The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword is an [access modifier](../vs140/access-modifiers--csharp-reference-.md) for types and type members. Internal types or members are accessible only within files in the same assembly, as in this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Types or members that have access modifier <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be accessed from the current assembly or from types that are derived from the containing class.  
  
 For a comparison of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with the other access modifiers, see [Accessibility Levels](../vs140/accessibility-levels--csharp-reference-.md) and [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
 For more information about assemblies, see [Assemblies and the Global Assembly Cache (C#)](../vs140/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md).  
  
 A common use of internal access is in component-based development because it enables a group of components to cooperate in a private manner without being exposed to the rest of the application code. For example, a framework for building graphical user interfaces could provide <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> classes that cooperate by using members with internal access. Since these members are internal, they are not exposed to code that is using the framework.  
  
 It is an error to reference a type or a member with internal access outside the assembly within which it was defined.  
  
## Example  
 This example contains two files, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>_<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The first file contains an internal base class, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. In the second file, an attempt to instantiate <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will produce an error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 In this example, use the same files you used in example 1, and change the accessibility level of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Also change the accessibility level of the member <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. In this case, you can instantiate the class, but you cannot access the internal member.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
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
 [protected (C# Programmer's Reference)](../vs140/protected--csharp-reference-.md)
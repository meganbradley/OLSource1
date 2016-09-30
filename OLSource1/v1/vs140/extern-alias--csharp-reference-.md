---
title: "extern alias (C# Reference)"
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
  - "alias_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "extern alias keyword [C#]"
  - "aliases [C#], extern keyword"
  - "aliases, extern keyword"
ms.assetid: f487bf4f-c943-4fca-851b-e540c83d9027
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extern alias (C# Reference)
You might have to reference two versions of assemblies that have the same fully-qualified type names. For example, you might have to use two or more versions of an assembly in the same application. By using an external assembly alias, the namespaces from each assembly can be wrapped inside root-level namespaces named by the alias, which enables them to be used in the same file.  
  
> [!NOTE]
>  The [extern](../vs140/extern--csharp-reference-.md) keyword is also used as a method modifier, declaring a method written in unmanaged code.  
  
 To reference two assemblies with the same fully-qualified type names, an alias must be specified at a command prompt, as follows:  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 This creates the external aliases <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. To use these aliases from within a program, reference them by using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword. For example:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 Each extern alias declaration introduces an additional root-level namespace that parallels (but does not lie within) the global namespace. Thus types from each assembly can be referred to without ambiguity by using their fully qualified name, rooted in the appropriate namespace-alias.  
  
 In the previous example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> would be the grid control from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> would be the grid control from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Namespace Keywords](../vs140/namespace-keywords--csharp-reference-.md)   
 [:: Operator](../vs140/---operator--csharp-reference-.md)   
 [/reference (Import Metadata) (C# Compiler Options)](../vs140/-reference--csharp-compiler-options-.md)
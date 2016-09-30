---
title: "How to: Access a Collection Class with foreach (C# Programming Guide)"
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
  - "collection classes [C#], foreach statement"
ms.assetid: a6b9cf5c-6c8d-4223-b12c-288949434493
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access a Collection Class with foreach (C# Programming Guide)
The following code example illustrates how to write a non-generic collection class that can be used with [foreach](../vs140/foreach--in--csharp-reference-.md). The example defines a string tokenizer class.  
  
> [!NOTE]
>  This example represents recommended practice only when you cannot use a generic collection class. For an example of how to implement a type-safe generic collection class that supports <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>Tokens<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Tokens<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Tokens<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>Current<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>Current<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>foreach` statements, or equivalent statements, of other common language runtime languages.  
  
## See Also  
 \<xref:System.Collections.Generic*>   
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Arrays (Visual C#)](../vs140/arrays--csharp-programming-guide-.md)   
 [Collection Classes (C#)](../vs140/collections--csharp-and-visual-basic-.md)
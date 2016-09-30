---
title: "where (generic type constraint) (C# Reference)"
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
  - "whereconstraint"
  - "whereconstraint_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "where (generic type constraint) [C#]"
ms.assetid: d7aa871b-0714-416a-bab2-96f87ada4310
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# where (generic type constraint) (C# Reference)
In a generic type definition, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause is used to specify constraints on the types that can be used as arguments for a type parameter defined in a generic declaration. For example, you can declare a generic class, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, such that the type parameter <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> implements the <xref:System.IComparable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>where<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>where<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>new()<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>new()<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>where<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>where` clause for each type parameter, for example:  
  
 [!code[csrefKeywordsContextual#8](../vs140/codesnippet/CSharp/where--generic-type-constraint---csharp-reference-_3.cs)]  
  
 You can also attach constraints to type parameters of generic methods, like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice that the syntax to describe type parameter constraints on delegates is the same as that of methods:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For information on generic delegates, see [Generic Delegates](../vs140/generic-delegates--csharp-programming-guide-.md).  
  
 For details on the syntax and use of constraints, see [Constraints on Type Parameters](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Introduction to Generics](../vs140/introduction-to-generics--csharp-programming-guide-.md)   
 [new Constraint](../vs140/new-constraint--csharp-reference-.md)   
 [Constraints on Type Parameters (C# Programmers Reference)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md)
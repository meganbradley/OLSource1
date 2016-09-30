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
In a generic type definition, the `where` clause is used to specify constraints on the types that can be used as arguments for a type parameter defined in a generic declaration. For example, you can declare a generic class, `MyGenericClass`, such that the type parameter `T` implements the <xref:System.IComparable`1*> interface:  
  
<CodeContentPlaceHolder>0</CodeContentPlaceHolder>  
> [!NOTE]
>  For more information on the where clause in a query expression, see [where clause (C# Reference)](../vs140/where-clause--csharp-reference-.md).  
  
 In addition to interface constraints, a `where` clause can include a base class constraint, which states that a type must have the specified class as a base class (or be that class itself) in order to be used as a type argument for that generic type. If such a constraint is used, it must appear before any other constraints on that type parameter.  
  
 [!code[csrefKeywordsContextual#6](../vs140/codesnippet/CSharp/where--generic-type-constraint---csharp-reference-_1.cs)]  
  
 The `where` clause may also include a constructor constraint. It is possible to create an instance of a type parameter using the new operator; however, in order to do so the type parameter must be constrained by the constructor constraint, `new()`. The [new() Constraint](../vs140/new-constraint--csharp-reference-.md) lets the compiler know that any type argument supplied must have an accessible parameterless--or default-- constructor. For example:  
  
 [!code[csrefKeywordsContextual#7](../vs140/codesnippet/CSharp/where--generic-type-constraint---csharp-reference-_2.cs)]  
  
 The `new()` constraint appears last in the `where` clause.  
  
 With multiple type parameters, use one `where` clause for each type parameter, for example:  
  
 [!code[csrefKeywordsContextual#8](../vs140/codesnippet/CSharp/where--generic-type-constraint---csharp-reference-_3.cs)]  
  
 You can also attach constraints to type parameters of generic methods, like this:  
  
```  
public bool MyMethod<T>(T t) where T : IMyInterface { }  
```  
  
 Notice that the syntax to describe type parameter constraints on delegates is the same as that of methods:  
  
```  
delegate T MyDelegate<T>() where T : new()  
```  
  
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
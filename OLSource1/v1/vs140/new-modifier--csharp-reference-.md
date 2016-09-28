---
title: "new Modifier (C# Reference)"
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
  - "new modifier keyword [C#]"
ms.assetid: a2e20856-33b9-4620-b535-a60dbce8349b
caps.latest.revision: 32
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# new Modifier (C# Reference)
When used as a declaration modifier, the `new` keyword explicitly hides a member that is inherited from a base class. When you hide an inherited member, the derived version of the member replaces the base class version. Although you can hide members without using the `new` modifier, you get a compiler warning. If you use `new` to explicitly hide a member, it suppresses this warning.  
  
 To hide an inherited member, declare it in the derived class by using the same member name, and modify it with the `new` keyword. For example:  
  
 [!code[csrefKeywordsOperator#8](../vs140/codesnippet/CSharp/new-modifier--csharp-reference-_1.cs)]  
  
 In this example, `BaseC.Invoke` is hidden by `DerivedC.Invoke`. The field `x` is not affected because it is not hidden by a similar name.  
  
 Name hiding through inheritance takes one of the following forms:  
  
-   Generally, a constant, field, property, or type that is introduced in a class or struct hides all base class members that share its name.  There are special cases.  For example, if you declare a new field with name `N` to have a type that is not invocable, and a base type declares `N` to be a method, the new field does not hide the base declaration in invocation syntax.  See the [C# language specification](http://go.microsoft.com/fwlink/?LinkId=199552) for details (see section "Member Lookup" in section "Expressions").  
  
-   A method introduced in a class or struct hides properties, fields, and types that share that name in the base class. It also hides all base class methods that have the same signature.  
  
-   An indexer introduced in a class or struct hides all base class indexers that have the same signature.  
  
 It is an error to use both `new` and [override](../vs140/override--csharp-reference-.md) on the same member, because the two modifiers have mutually exclusive meanings. The `new` modifier creates a new member with the same name and causes the original member to become hidden. The `override` modifier extends the implementation for an inherited member.  
  
 Using the `new` modifier in a declaration that does not hide an inherited member generates a warning.  
  
## Example  
 In this example, a base class, `BaseC`, and a derived class, `DerivedC`, use the same field name `x`, which hides the value of the inherited field. The example demonstrates the use of the `new` modifier. It also demonstrates how to access the hidden members of the base class by using their fully qualified names.  
  
 [!code[csrefKeywordsOperator#9](../vs140/codesnippet/CSharp/new-modifier--csharp-reference-_2.cs)]  
  
## Example  
 In this example, a nested class hides a class that has the same name in the base class. The example demonstrates how to use the `new` modifier to eliminate the warning message and how to access the hidden class members by using their fully qualified names.  
  
 [!code[csrefKeywordsOperator#10](../vs140/codesnippet/CSharp/new-modifier--csharp-reference-_3.cs)]  
  
 If you remove the `new` modifier, the program will still compile and run, but you will get the following warning:  
  
```  
The keyword new is required on 'MyDerivedC.x' because it hides inherited member 'MyBaseC.x'.  
```  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Operator Keywords](../vs140/operator-keywords--csharp-reference-.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [Versioning with the Override and New Keywords](../vs140/versioning-with-the-override-and-new-keywords--csharp-programming-guide-.md)   
 [Knowing When to Use Override and New Keywords](../vs140/knowing-when-to-use-override-and-new-keywords--csharp-programming-guide-.md)
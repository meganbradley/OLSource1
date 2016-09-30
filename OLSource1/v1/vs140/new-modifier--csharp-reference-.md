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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# new Modifier (C# Reference)
When used as a declaration modifier, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword explicitly hides a member that is inherited from a base class. When you hide an inherited member, the derived version of the member replaces the base class version. Although you can hide members without using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier, you get a compiler warning. If you use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to explicitly hide a member, it suppresses this warning.  
  
 To hide an inherited member, declare it in the derived class by using the same member name, and modify it with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword. For example:  
  
 [!code[csrefKeywordsOperator#8](../vs140/codesnippet/CSharp/new-modifier--csharp-reference-_1.cs)]  
  
 In this example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is hidden by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The field <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not affected because it is not hidden by a similar name.  
  
 Name hiding through inheritance takes one of the following forms:  
  
-   Generally, a constant, field, property, or type that is introduced in a class or struct hides all base class members that share its name.  There are special cases.  For example, if you declare a new field with name <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to have a type that is not invocable, and a base type declares <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to be a method, the new field does not hide the base declaration in invocation syntax.  See the [C# language specification](http://go.microsoft.com/fwlink/?LinkId=199552) for details (see section "Member Lookup" in section "Expressions").  
  
-   A method introduced in a class or struct hides properties, fields, and types that share that name in the base class. It also hides all base class methods that have the same signature.  
  
-   An indexer introduced in a class or struct hides all base class indexers that have the same signature.  
  
 It is an error to use both <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and [override](../vs140/override--csharp-reference-.md) on the same member, because the two modifiers have mutually exclusive meanings. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> modifier creates a new member with the same name and causes the original member to become hidden. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> modifier extends the implementation for an inherited member.  
  
 Using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> modifier in a declaration that does not hide an inherited member generates a warning.  
  
## Example  
 In this example, a base class, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and a derived class, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, use the same field name <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which hides the value of the inherited field. The example demonstrates the use of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> modifier. It also demonstrates how to access the hidden members of the base class by using their fully qualified names.  
  
 [!code[csrefKeywordsOperator#9](../vs140/codesnippet/CSharp/new-modifier--csharp-reference-_2.cs)]  
  
## Example  
 In this example, a nested class hides a class that has the same name in the base class. The example demonstrates how to use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> modifier to eliminate the warning message and how to access the hidden class members by using their fully qualified names.  
  
 [!code[csrefKeywordsOperator#10](../vs140/codesnippet/CSharp/new-modifier--csharp-reference-_3.cs)]  
  
 If you remove the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> modifier, the program will still compile and run, but you will get the following warning:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
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
---
title: "virtual (C# Reference)"
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
  - "virtual_CSharpKeyword"
  - "virtual"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "virtual keyword [C#]"
ms.assetid: 5da9abae-bc1e-434f-8bea-3601b8dcb3b2
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# virtual (C# Reference)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class. For example, this method can be overridden by any class that inherits it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The implementation of a virtual member can be changed by an [overriding member](../vs140/override--csharp-reference-.md) in a derived class. For more information about how to use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword, see [Versioning with the Override and New Keywords (C#)](../vs140/versioning-with-the-override-and-new-keywords--csharp-programming-guide-.md) and [Knowing when to use Override and New Keywords](../vs140/knowing-when-to-use-override-and-new-keywords--csharp-programming-guide-.md).  
  
## Remarks  
 When a virtual method is invoked, the run-time type of the object is checked for an overriding member. The overriding member in the most derived class is called, which might be the original member, if no derived class has overridden the member.  
  
 By default, methods are non-virtual. You cannot override a non-virtual method.  
  
 You cannot use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> modifier with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> modifiers. The following example shows a virtual property:  
  
 [!code[csrefKeywordsModifiers#26](../vs140/codesnippet/CSharp/virtual--csharp-reference-_1.cs)]  
  
 Virtual properties behave like abstract methods, except for the differences in declaration and invocation syntax.  
  
-   It is an error to use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> modifier on a static property.  
  
-   A virtual inherited property can be overridden in a derived class by including a property declaration that uses the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> modifier.  
  
## Example  
 In this example, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class contains the two coordinates <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> virtual method. Different shape classes such as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> inherit the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class, and the surface area is calculated for each figure. Each derived class has it own override implementation of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 Notice that the inherited classes <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> all use constructors that initialize the base class, as shown in the following declaration.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following program calculates and displays the appropriate area for each figure by invoking the appropriate implementation of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method, according to the object that is associated with the method.  
  
 [!code[csrefKeywordsModifiers#23](../vs140/codesnippet/CSharp/virtual--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Polymorphism (Visual C#)](../vs140/polymorphism--csharp-programming-guide-.md)   
 [abstract](../vs140/abstract--csharp-reference-.md)   
 [override (C# Programmer's Reference)](../vs140/override--csharp-reference-.md)   
 [new (C# Programmer's Reference)](../vs140/new--csharp-reference-.md)
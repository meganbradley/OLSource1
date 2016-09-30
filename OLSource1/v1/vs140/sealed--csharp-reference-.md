---
title: "sealed (C# Reference)"
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
  - "sealed"
  - "sealed_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "sealed keyword [C#]"
ms.assetid: 8e4ed5d3-10be-47db-9488-0da2008e6f3f
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sealed (C# Reference)
When applied to a class, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier prevents other classes from inheriting from it. In the following example, class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> inherits from class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, but no class can inherit from class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can also use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> modifier on a method or property that overrides a virtual method or property in a base class. This enables you to allow classes to derive from your class and prevent them from overriding specific virtual methods or properties.  
  
## Example  
 In the following example, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> inherits from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> but <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> cannot override the virtual function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that is declared in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and sealed in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [!code[csrefKeywordsModifiers#16](../vs140/codesnippet/CSharp/sealed--csharp-reference-_1.cs)]  
  
 When you define new methods or properties in a class, you can prevent deriving classes from overriding them by not declaring them as [virtual](../vs140/virtual--csharp-reference-.md).  
  
 It is an error to use the [abstract](../vs140/abstract--csharp-reference-.md) modifier with a sealed class, because an abstract class must be inherited by a class that provides an implementation of the abstract methods or properties.  
  
 When applied to a method or property, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> modifier must always be used with [override](../vs140/override--csharp-reference-.md).  
  
 Because structs are implicitly sealed, they cannot be inherited.  
  
 For more information, see [Inheritance (Visual C#)](../vs140/inheritance--csharp-programming-guide-.md).  
  
 For more examples, see [Abstract and Sealed Classes and Class Members (C# Programming Guide)](../vs140/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md).  
  
## Example  
 [!code[csrefKeywordsModifiers#17](../vs140/codesnippet/CSharp/sealed--csharp-reference-_2.cs)]  
  
 In the previous example, you might try to inherit from the sealed class by using the following statement:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 The result is an error message:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## Remarks  
 To determine whether to seal a class, method, or property, you should generally consider the following two points:  
  
-   The potential benefits that deriving classes might gain through the ability to customize your class.  
  
-   The potential that deriving classes could modify your classes in such a way that they would no longer work correctly or as expected.  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Static Classes and Static Class Members](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md)   
 [Abstract and Sealed Classes and Class Members (Visual C#)](../vs140/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md)   
 [Access Modifiers (Visual C#)](../vs140/access-modifiers--csharp-programming-guide-.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [override (C# Reference)](../vs140/override--csharp-reference-.md)   
 [virtual (C# Reference)](../vs140/virtual--csharp-reference-.md)
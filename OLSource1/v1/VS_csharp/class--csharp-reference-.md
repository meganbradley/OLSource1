---
title: "class (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "class_CSharpKeyword"
  - "class"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "class keyword [C#]"
ms.assetid: b95d8815-de18-4c3f-a8cc-a0a53bdf8690
caps.latest.revision: 30
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# class (C# Reference)
Classes are declared using the keyword `class`, as shown in the following example:  
  
```  
  
      class TestClass  
{  
    // Methods, properties, fields, events, delegates   
    // and nested classes go here.  
}  
```  
  
## Remarks  
 Only single inheritance is allowed in C#. In other words, a class can inherit implementation from one base class only. However, a class can implement more than one interface. The following table shows examples of class inheritance and interface implementation:  
  
|Inheritance|Example|  
|-----------------|-------------|  
|None|`class ClassA { }`|  
|Single|`class DerivedClass: BaseClass { }`|  
|None, implements two interfaces|`class ImplClass: IFace1, IFace2 { }`|  
|Single, implements one interface|`class ImplDerivedClass: BaseClass, IFace1 { }`|  
  
 Classes that you declare directly within a namespace, not nested within other classes, can be either [public](../VS_csharp/public--csharp-reference-.md) or [internal](../VS_csharp/internal--csharp-reference-.md). Classes are `internal` by default.  
  
 Class members, including nested classes, can be [public](../VS_csharp/public--csharp-reference-.md), `protected internal`, [protected](../VS_csharp/protected--csharp-reference-.md), [internal](../VS_csharp/internal--csharp-reference-.md), or [private](../VS_csharp/private--csharp-reference-.md). Members are [private](../VS_csharp/private--csharp-reference-.md) by default.  
  
 For more information, see [Access Modifiers](../VS_csharp/access-modifiers--csharp-programming-guide-.md).  
  
 You can declare generic classes that have type parameters. For more information, see [Generic Classes](../VS_csharp/generic-classes--csharp-programming-guide-.md).  
  
 A class can contain declarations of the following members:  
  
-   [Constructors](../VS_csharp/constructors--csharp-programming-guide-.md)  
  
-   [Destructors](../VS_csharp/destructors--csharp-programming-guide-.md)  
  
-   [Constants](../VS_csharp/constants--csharp-programming-guide-.md)  
  
-   [Fields](../VS_csharp/fields--csharp-programming-guide-.md)  
  
-   [Methods](../VS_csharp/methods--csharp-programming-guide-.md)  
  
-   [Properties](../VS_csharp/properties--csharp-programming-guide-.md)  
  
-   [Indexers](../VS_csharp/indexers--csharp-programming-guide-.md)  
  
-   [Operators](../VS_csharp/operators--csharp-programming-guide-.md)  
  
-   [Events](../VS_csharp/events--csharp-programming-guide-.md)  
  
-   [Delegates](../VS_csharp/delegates--csharp-programming-guide-.md)  
  
-   [Classes](../VS_csharp/classes--csharp-programming-guide-.md)  
  
-   [Interfaces](../VS_csharp/interfaces--csharp-programming-guide-.md)  
  
-   [Structs](../VS_csharp/structs--csharp-programming-guide-.md)  
  
## Example  
 The following example demonstrates declaring class fields, constructors, and methods. It also demonstrates object instantiation and printing instance data. In this example, two classes are declared, the `Child` class, which contains two private fields (`name` and `age`) and two public methods. The second class, `StringTest`, is used to contain `Main`.  
  
 [!code[csrefKeywordsTypes#5](../VS_csharp/codesnippet/CSharp/class--csharp-reference-_1.cs)]  
  
## Comments  
 Notice, in the preceding example, that the private fields (`name` and `age`) can only be accessed through the public methods of the `Child` class. For example, you cannot print the child's name, from the `Main` method, using a statement like this:  
  
```  
Console.Write(child1.name);   // Error  
```  
  
 Accessing private members of `Child` from `Main` would only be possible if `Main` were a member of the class.  
  
 Types declared inside a class without an access modifier default to `private`, so the data members in this example would still be `private` if the keyword were removed.  
  
 Finally, notice that for the object created using the default constructor (`child3`), the age field was initialized to zero by default.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Reference Types](../VS_csharp/reference-types--csharp-reference-.md)
---
title: "class (C# Reference)"
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
  - "class_CSharpKeyword"
  - "class"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "class keyword [C#]"
ms.assetid: b95d8815-de18-4c3f-a8cc-a0a53bdf8690
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# class (C# Reference)
Classes are declared using the keyword <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, as shown in the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Only single inheritance is allowed in C#. In other words, a class can inherit implementation from one base class only. However, a class can implement more than one interface. The following table shows examples of class inheritance and interface implementation:  
  
|Inheritance|Example|  
|-----------------|-------------|  
|None|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|Single|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|None, implements two interfaces|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|Single, implements one interface|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
  
 Classes that you declare directly within a namespace, not nested within other classes, can be either [public](../vs140/public--csharp-reference-.md) or [internal](../vs140/internal--csharp-reference-.md). Classes are <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> by default.  
  
 Class members, including nested classes, can be [public](../vs140/public--csharp-reference-.md), <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, [protected](../vs140/protected--csharp-reference-.md), [internal](../vs140/internal--csharp-reference-.md), or [private](../vs140/private--csharp-reference-.md). Members are [private](../vs140/private--csharp-reference-.md) by default.  
  
 For more information, see [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
 You can declare generic classes that have type parameters. For more information, see [Generic Classes](../vs140/generic-classes--csharp-programming-guide-.md).  
  
 A class can contain declarations of the following members:  
  
-   [Constructors](../vs140/constructors--csharp-programming-guide-.md)  
  
-   [Destructors](../vs140/destructors--csharp-programming-guide-.md)  
  
-   [Constants](../vs140/constants--csharp-programming-guide-.md)  
  
-   [Fields](../vs140/fields--csharp-programming-guide-.md)  
  
-   [Methods](../vs140/methods--csharp-programming-guide-.md)  
  
-   [Properties](../vs140/properties--csharp-programming-guide-.md)  
  
-   [Indexers](../vs140/indexers--csharp-programming-guide-.md)  
  
-   [Operators](../vs140/operators--csharp-programming-guide-.md)  
  
-   [Events](../vs140/events--csharp-programming-guide-.md)  
  
-   [Delegates](../vs140/delegates--csharp-programming-guide-.md)  
  
-   [Classes](../vs140/classes--csharp-programming-guide-.md)  
  
-   [Interfaces](../vs140/interfaces--csharp-programming-guide-.md)  
  
-   [Structs](../vs140/structs--csharp-programming-guide-.md)  
  
## Example  
 The following example demonstrates declaring class fields, constructors, and methods. It also demonstrates object instantiation and printing instance data. In this example, two classes are declared, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class, which contains two private fields (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) and two public methods. The second class, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, is used to contain <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 [!code[csrefKeywordsTypes#5](../vs140/codesnippet/CSharp/class--csharp-reference-_1.cs)]  
  
## Comments  
 Notice, in the preceding example, that the private fields (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) can only be accessed through the public methods of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class. For example, you cannot print the child's name, from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method, using a statement like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Accessing private members of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> would only be possible if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> were a member of the class.  
  
 Types declared inside a class without an access modifier default to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, so the data members in this example would still be <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if the keyword were removed.  
  
 Finally, notice that for the object created using the default constructor (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>), the age field was initialized to zero by default.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Reference Types](../vs140/reference-types--csharp-reference-.md)
---
title: "Using Constructors (C# Programming Guide)"
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
  - "constructors [C#], about constructors"
ms.assetid: 464253b2-fd5d-469a-836d-df0fdf2a43f7
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Constructors (C# Programming Guide)
When a [class](../vs140/class--csharp-reference-.md) or [struct](../vs140/struct--csharp-reference-.md) is created, its constructor is called. Constructors have the same name as the class or struct, and they usually initialize the data members of the new object.  
  
 In the following example, a class named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is defined by using a simple constructor. This class is then instantiated with the [new](../vs140/new--csharp-reference-.md) operator. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> constructor is invoked by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator immediately after memory is allocated for the new object.  
  
 [!code[csProgGuideObjects#53](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_1.cs)]  
  
 A constructor that takes no parameters is called a *default constructor*. Default constructors are invoked whenever an object is instantiated by using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator and no arguments are provided to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For more information, see [Instance Constructors](../vs140/instance-constructors--csharp-programming-guide-.md).  
  
 Unless the class is [static](../vs140/static--csharp-reference-.md), classes without constructors are given a public default constructor by the C# compiler in order to enable class instantiation. For more information, see [Static Classes and Static Class Members](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
 You can prevent a class from being instantiated by making the constructor private, as follows:  
  
 [!code[csProgGuideObjects#11](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_2.cs)]  
  
 For more information, see [Private Constructors](../vs140/private-constructors--csharp-programming-guide-.md).  
  
 Constructors for [struct](../vs140/struct--csharp-reference-.md) types resemble class constructors, but <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> cannot contain an explicit default constructor because one is provided automatically by the compiler. This constructor initializes each field in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the default values. For more information, see [Default Values Table](../vs140/default-values-table--csharp-reference-.md). However, this default constructor is only invoked if the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is instantiated with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For example, this code uses the default constructor for \<xref:System.Int32*>, so that you are assured that the integer is initialized:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following code, however, causes a compiler error because it does not use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and because it tries to use an object that has not been initialized:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Alternatively, objects based on <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (including all built-in numeric types) can be initialized or assigned and then used as in the following example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 So calling the default constructor for a value type is not required.  
  
 Both classes and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can define constructors that take parameters. Constructors that take parameters must be called through a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement or a [base](../vs140/base--csharp-reference-.md) statement. Classes and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can also define multiple constructors, and neither is required to define a default constructor. For example:  
  
 [!code[csProgGuideObjects#54](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_3.cs)]  
  
 This class can be created by using either of the following statements:  
  
 [!code[csProgGuideObjects#55](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_4.cs)]  
  
 A constructor can use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword to call the constructor of a base class. For example:  
  
 [!code[csProgGuideObjects#56](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_5.cs)]  
  
 In this example, the constructor for the base class is called before the block for the constructor is executed. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword can be used with or without parameters. Any parameters to the constructor can be used as parameters to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, or as part of an expression. For more information, see [base](../vs140/base--csharp-reference-.md).  
  
 In a derived class, if a base-class constructor is not called explicitly by using the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keyword, the default constructor, if there is one, is called implicitly. This means that the following constructor declarations are effectively the same:  
  
 [!code[csProgGuideObjects#58](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_6.cs)]  
  
 [!code[csProgGuideObjects#57](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_7.cs)]  
  
 If a base class does not offer a default constructor, the derived class must make an explicit call to a base constructor by using <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 A constructor can invoke another constructor in the same object by using the [this](../vs140/this--csharp-reference-.md) keyword. Like <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can be used with or without parameters, and any parameters in the constructor are available as parameters to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, or as part of an expression. For example, the second constructor in the previous example can be rewritten using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>:  
  
 [!code[csProgGuideObjects#59](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_8.cs)]  
  
 The use of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> keyword in the previous example causes this constructor to be called:  
  
 [!code[csProgGuideObjects#60](../vs140/codesnippet/CSharp/using-constructors--csharp-programming-guide-_9.cs)]  
  
 Constructors can be marked as [public](../vs140/public--csharp-reference-.md), [private](../vs140/private--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), [internal](../vs140/internal--csharp-reference-.md), or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. These access modifiers define how users of the class can construct the class. For more information, see [Access Modifiers](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
 A constructor can be declared static by using the [static](../vs140/static--csharp-reference-.md) keyword. Static constructors are called automatically, immediately before any static fields are accessed, and are generally used to initialize static class members. For more information, see [Static Constructors](../vs140/static-constructors--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (Visual C#)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Constructors](../vs140/constructors--csharp-programming-guide-.md)   
 [Destructors (C# Programmer's Reference)](../vs140/destructors--csharp-programming-guide-.md)
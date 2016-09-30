---
title: "Constants (C# Programming Guide)"
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
  - "C# language, constants"
  - "constants [C#]"
ms.assetid: 1fb39621-1738-49b1-a1b3-8587f109123f
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constants (C# Programming Guide)
Constants are immutable values which are known at compile time and do not change for the life of the program. Constants are declared with the [const](../vs140/const--csharp-reference-.md) modifier. Only the C# built-in types (excluding \<xref:System.Object*?displayProperty=fullName>) may be declared as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. For a list of the built-in types, see [Built-In Types Table (C# Reference)](../vs140/built-in-types-table--csharp-reference-.md). User-defined types, including classes, structs, and arrays, cannot be <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Use the [readonly](../vs140/readonly--csharp-reference-.md) modifier to create a class, struct, or array that is initialized one time at runtime (for example in a constructor) and thereafter cannot be changed.  
  
 C# does not support <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> methods, properties, or events.  
  
 The enum type enables you to define named constants for integral built-in types (for example <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and so on). For more information, see [enum (C# Reference)](../vs140/enum--csharp-reference-.md).  
  
 Constants must be initialized as they are declared. For example:  
  
 [!code[csProgGuideObjects#64](../vs140/codesnippet/CSharp/constants--csharp-programming-guide-_1.cs)]  
  
 In this example, the constant <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is always 12, and it cannot be changed even by the class itself. In fact, when the compiler encounters a constant identifier in C# source code (for example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), it substitutes the literal value directly into the intermediate language (IL) code that it produces. Because there is no variable address associated with a constant at run time, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> fields cannot be passed by reference and cannot appear as an l-value in an expression.  
  
> [!NOTE]
>  Use caution when you refer to constant values defined in other code such as DLLs. If a new version of the DLL defines a new value for the constant, your program will still hold the old literal value until it is recompiled against the new version.  
  
 Multiple constants of the same type can be declared at the same time, for example:  
  
 [!code[csProgGuideObjects#65](../vs140/codesnippet/CSharp/constants--csharp-programming-guide-_2.cs)]  
  
 The expression that is used to initialize a constant can refer to another constant if it does not create a circular reference. For example:  
  
 [!code[csProgGuideObjects#66](../vs140/codesnippet/CSharp/constants--csharp-programming-guide-_3.cs)]  
  
 Constants can be marked as [public](../vs140/public--csharp-reference-.md), [private](../vs140/private--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), [internal](../vs140/internal--csharp-reference-.md), or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. These access modifiers define how users of the class can access the constant. For more information, see [Access Modifiers (Visual C#)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
 Constants are accessed as if they were [static](../vs140/static--csharp-reference-.md) fields because the value of the constant is the same for all instances of the type. You do not use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword to declare them. Expressions that are not in the class that defines the constant must use the class name, a period, and the name of the constant to access the constant. For example:  
  
 [!code[csProgGuideObjects#67](../vs140/codesnippet/CSharp/constants--csharp-programming-guide-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Classes and Structs (Visual C#)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Properties (C# Programming Guide)](../vs140/properties--csharp-programming-guide-.md)   
 [Data Types (C# Programming Guide)](../vs140/types--csharp-programming-guide-.md)   
 [readonly (C# Reference)](../vs140/readonly--csharp-reference-.md)   
 [Immutability in C# Part One: Kinds of Immutability](http://go.microsoft.com/fwlink/?LinkId=112379)
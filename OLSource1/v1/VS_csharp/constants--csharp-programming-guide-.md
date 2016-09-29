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
Constants are immutable values which are known at compile time and do not change for the life of the program. Constants are declared with the [const](../VS_csharp/const--csharp-reference-.md) modifier. Only the C# built-in types (excluding <xref:System.Object*?displayProperty=fullName>) may be declared as `const`. For a list of the built-in types, see [Built-In Types Table (C# Reference)](../VS_csharp/built-in-types-table--csharp-reference-.md). User-defined types, including classes, structs, and arrays, cannot be `const`. Use the [readonly](../VS_csharp/readonly--csharp-reference-.md) modifier to create a class, struct, or array that is initialized one time at runtime (for example in a constructor) and thereafter cannot be changed.  
  
 C# does not support `const` methods, properties, or events.  
  
 The enum type enables you to define named constants for integral built-in types (for example `int`, `uint`, `long`, and so on). For more information, see [enum (C# Reference)](../VS_csharp/enum--csharp-reference-.md).  
  
 Constants must be initialized as they are declared. For example:  
  
 [!code[csProgGuideObjects#64](../VS_csharp/codesnippet/CSharp/constants--csharp-programming-guide-_1.cs)]  
  
 In this example, the constant `months` is always 12, and it cannot be changed even by the class itself. In fact, when the compiler encounters a constant identifier in C# source code (for example, `months`), it substitutes the literal value directly into the intermediate language (IL) code that it produces. Because there is no variable address associated with a constant at run time, `const` fields cannot be passed by reference and cannot appear as an l-value in an expression.  
  
> [!NOTE]
>  Use caution when you refer to constant values defined in other code such as DLLs. If a new version of the DLL defines a new value for the constant, your program will still hold the old literal value until it is recompiled against the new version.  
  
 Multiple constants of the same type can be declared at the same time, for example:  
  
 [!code[csProgGuideObjects#65](../VS_csharp/codesnippet/CSharp/constants--csharp-programming-guide-_2.cs)]  
  
 The expression that is used to initialize a constant can refer to another constant if it does not create a circular reference. For example:  
  
 [!code[csProgGuideObjects#66](../VS_csharp/codesnippet/CSharp/constants--csharp-programming-guide-_3.cs)]  
  
 Constants can be marked as [public](../VS_csharp/public--csharp-reference-.md), [private](../VS_csharp/private--csharp-reference-.md), [protected](../VS_csharp/protected--csharp-reference-.md), [internal](../VS_csharp/internal--csharp-reference-.md), or `protected``internal`. These access modifiers define how users of the class can access the constant. For more information, see [Access Modifiers (Visual C#)](../VS_csharp/access-modifiers--csharp-programming-guide-.md).  
  
 Constants are accessed as if they were [static](../VS_csharp/static--csharp-reference-.md) fields because the value of the constant is the same for all instances of the type. You do not use the `static` keyword to declare them. Expressions that are not in the class that defines the constant must use the class name, a period, and the name of the constant to access the constant. For example:  
  
 [!code[csProgGuideObjects#67](../VS_csharp/codesnippet/CSharp/constants--csharp-programming-guide-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Classes and Structs (Visual C#)](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)   
 [Properties (C# Programming Guide)](../VS_csharp/properties--csharp-programming-guide-.md)   
 [Data Types (C# Programming Guide)](../VS_csharp/types--csharp-programming-guide-.md)   
 [readonly (C# Reference)](../VS_csharp/readonly--csharp-reference-.md)   
 [Immutability in C# Part One: Kinds of Immutability](http://go.microsoft.com/fwlink/?LinkId=112379)
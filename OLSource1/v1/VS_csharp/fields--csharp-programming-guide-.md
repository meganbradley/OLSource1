---
title: "Fields (C# Programming Guide)"
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
  - "fields [C#]"
ms.assetid: 3cbb2f61-75f8-4cce-b4ef-f5d1b3de0db7
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fields (C# Programming Guide)
A *field* is a variable of any type that is declared directly in a [class](../VS_csharp/class--csharp-reference-.md) or [struct](../VS_csharp/struct--csharp-reference-.md). Fields are *members* of their containing type.  
  
 A class or struct may have instance fields or static fields or both. Instance fields are specific to an instance of a type. If you have a class T, with an instance field F, you can create two objects of type T, and modify the value of F in each object without affecting the value in the other object. By contrast, a static field belongs to the class itself, and is shared among all instances of that class. Changes made from instance A will be visibly immediately to instances B and C if they access the field.  
  
 Generally, you should use fields only for variables that have private or protected accessibility. Data that your class exposes to client code should be provided through [methods](../VS_csharp/methods--csharp-programming-guide-.md), [properties](../VS_csharp/properties--csharp-programming-guide-.md) and [indexers](../VS_csharp/indexers--csharp-programming-guide-.md). By using these constructs for indirect access to internal fields, you can guard against invalid input values. A private field that stores the data exposed by a public property is called a *backing store* or *backing field*.  
  
 Fields typically store the data that must be accessible to more than one class method and must be stored for longer than the lifetime of any single method. For example, a class that represents a calendar date might have three integer fields: one for the month, one for the day, and one for the year. Variables that are not used outside the scope of a single method should be declared as *local variables* within the method body itself.  
  
 Fields are declared in the class block by specifying the access level of the field, followed by the type of the field, followed by the name of the field. For example:  
  
 [!code[csProgGuideObjects#61](../VS_csharp/codesnippet/CSharp/fields--csharp-programming-guide-_1.cs)]  
  
 To access a field in an object, add a period after the object name, followed by the name of the field, as in `objectname.fieldname`. For example:  
  
 [!code[csProgGuideObjects#62](../VS_csharp/codesnippet/CSharp/fields--csharp-programming-guide-_2.cs)]  
  
 A field can be given an initial value by using the assignment operator when the field is declared. To automatically assign the `day` field to `"Monday"`, for example, you would declare `day` as in the following example:  
  
 [!code[csProgGuideObjects#63](../VS_csharp/codesnippet/CSharp/fields--csharp-programming-guide-_3.cs)]  
  
 Fields are initialized immediately before the constructor for the object instance is called. If the constructor assigns the value of a field, it will overwrite any value given during field declaration. For more information, see [Using Constructors](../VS_csharp/using-constructors--csharp-programming-guide-.md).  
  
> [!NOTE]
>  A field initializer cannot refer to other instance fields.  
  
 Fields can be marked as [public](../VS_csharp/public--csharp-reference-.md), [private](../VS_csharp/private--csharp-reference-.md), [protected](../VS_csharp/protected--csharp-reference-.md), [internal](../VS_csharp/internal--csharp-reference-.md), or `protected internal`. These access modifiers define how users of the class can access the fields. For more information, see [Access Modifiers](../VS_csharp/access-modifiers--csharp-programming-guide-.md).  
  
 A field can optionally be declared [static](../VS_csharp/static--csharp-reference-.md). This makes the field available to callers at any time, even if no instance of the class exists. For more information, see [Static Classes and Static Class Members](../VS_csharp/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
 A field can be declared [readonly](../VS_csharp/readonly--csharp-reference-.md). A read-only field can only be assigned a value during initialization or in a constructor. A `static``readonly` field is very similar to a constant, except that the C# compiler does not have access to the value of a static read-only field at compile time, only at run time. For more information, see [Constants](../VS_csharp/constants--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Classes and Structs (Visual C#)](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)   
 [Constructors and Destructors (Visual C#)](../VS_csharp/using-constructors--csharp-programming-guide-.md)   
 [Inheritance (Visual C#)](../VS_csharp/inheritance--csharp-programming-guide-.md)   
 [Access Modifiers (Visual C#)](../VS_csharp/access-modifiers--csharp-programming-guide-.md)   
 [Abstract and Sealed Classes and Class Members (Visual C#)](../VS_csharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md)
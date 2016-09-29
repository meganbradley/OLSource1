---
title: "Private Constructors (C# Programming Guide)"
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
  - "C# language, private constructors"
  - "private constructors [C#]"
ms.assetid: 29eeaa7d-8d81-453c-94b9-0e2800172621
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Private Constructors (C# Programming Guide)
A private constructor is a special instance constructor. It is generally used in classes that contain static members only. If a class has one or more private constructors and no public constructors, other classes (except nested classes) cannot create instances of this class. For example:  
  
 [!code[csProgGuideObjects#11](../VS_csharp/codesnippet/CSharp/private-constructors--csharp-programming-guide-_1.cs)]  
  
 The declaration of the empty constructor prevents the automatic generation of a default constructor. Note that if you do not use an access modifier with the constructor it will still be private by default. However, the [private](../VS_csharp/private--csharp-reference-.md) modifier is usually used explicitly to make it clear that the class cannot be instantiated.  
  
 Private constructors are used to prevent creating instances of a class when there are no instance fields or methods, such as the <xref:System.Math*> class, or when a method is called to obtain an instance of a class. If all the methods in the class are static, consider making the complete class static. For more information see [Static Classes and Static Class Members](../VS_csharp/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
## Example  
 The following is an example of a class using a private constructor.  
  
 [!code[csProgGuideObjects#12](../VS_csharp/codesnippet/CSharp/private-constructors--csharp-programming-guide-_2.cs)]  
  
 Notice that if you uncomment the following statement from the example, it will generate an error because the constructor is inaccessible because of its protection level:  
  
 [!code[csProgGuideObjects#13](../VS_csharp/codesnippet/CSharp/private-constructors--csharp-programming-guide-_3.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Objects, Classes, and Structs (Visual C#)](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)   
 [Constructors](../VS_csharp/constructors--csharp-programming-guide-.md)   
 [Destructors (C# Programmer's Reference)](../VS_csharp/destructors--csharp-programming-guide-.md)   
 [private (C# Programmer's Reference)](../VS_csharp/private--csharp-reference-.md)   
 [public (C# Reference)](../VS_csharp/public--csharp-reference-.md)
---
title: "Classes and Structs (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Visual C++, classes"
  - "structures, C++ classes"
  - "user-defined types"
  - "classes [C++]"
  - "user-defined types, C++ classes"
ms.assetid: 516dd496-13fb-4f17-845a-e9ca45437873
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Classes and Structs (C++)
This section introduces C++ classes and structs. The two constructs are identical in C++ except that in structs the default accessibility is public, whereas in classes the default is private.  
  
 Classes and structs are the constructs whereby you define your own types. Classes and structs can both contain data members and member functions, which enable you to describe the type's state and behavior.  
  
 The following topics are included:  
  
-   [class (C++)](../VS_csharp/class--c---.md)  
  
-   [struct (C++)](../VS_csharp/struct--c---.md)  
  
-   [Class Member Overview](../VS_csharp/class-member-overview.md)  
  
-   [Member Access Control (C++)](../VS_csharp/member-access-control--c---.md)  
  
-   [Inheritance  (C++)](../VS_csharp/inheritance---c---.md)  
  
-   [Static Members (C++)](../VS_csharp/static-members--c---.md)  
  
-   [User-Defined Type Conversions (C++)](../VS_csharp/user-defined-type-conversions--c---.md)  
  
-   [Mutable Data Members (C++)](../VS_csharp/mutable-data-members--c---.md)  
  
-   [Nested Class Declarations](../VS_csharp/nested-class-declarations.md)  
  
-   [Anonymous Class Types](../VS_csharp/anonymous-class-types.md)  
  
-   [Pointers to Members](../VS_csharp/pointers-to-members.md)  
  
-   [this Pointer](../VS_csharp/this-pointer.md)  
  
-   [C++ Bit Fields](../VS_csharp/c---bit-fields.md)  
  
 The three class types are structure, class, and union. They are declared using the [struct](../VS_csharp/struct--c---.md), [class](../VS_csharp/class--c---.md), and [union](../VS_csharp/unions.md) keywords (see [Defining Class Types](assetId:///e8c65425-0f3a-4dca-afc2-418c3b1e57da)). The following table shows the differences among the three class types.  
  
 For more information on unions, see [Unions](../VS_csharp/unions.md). For information on managed classes and structs, see [Classes and Structs](../VS_csharp/classes-and-structs---c---component-extensions-.md).  
  
### Access Control and Constraints of Structures, Classes and Unions  
  
|Structures|Classes|Unions|  
|----------------|-------------|------------|  
|class key is `struct`|class key is **class**|class key is **union**|  
|Default access is public|Default access is private|Default access is public|  
|No usage constraints|No usage constraints|Use only one member at a time|  
  
## See Also  
 [C++ Language Reference](../VS_csharp/c---language-reference.md)
---
title: "Trivial, standard-layout, and POD types"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2b23a7be-9bad-49fc-8298-31a9a7c556b0
caps.latest.revision: 17
---
# Trivial, standard-layout, and POD types
The term *layout* refers to how the members of an object of class, struct or union type are arranged in memory. In some cases, the layout is well-defined by the language specification. But when a class or struct contains certain C++ language features such as virtual base classes, virtual functions, members with different access control, then the compiler is free to choose a layout. That layout may vary depending on what optimizations are being performed and in many cases object might not even occupy a contiguous area of memory. For example, if a class has virtual functions, all the instances of that class might share a single virtual function table. Such types are of course very useful, but they also have limitations. Because the layout is undefined they cannot be passed to programs written in other languages, such as C, and because they might be non-contiguous they cannot be reliably copied with fast low-level functions such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or serialized over a network.  
  
 To enable compilers as well as C++ programs and metaprograms to reason about the suitability of any given type for operations that depend on a particular memory layout, C++14 introduced three categories of simple classes and structs: *trivial*, *standard-layout*, and *POD* or Plain Old Data. The Standard Library has the function templates <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that determine whether a given type belongs to a given category.  
  
## Trivial types  
 When a class or struct in C++ has compiler-provided or explicitly defaulted special member functions, then it is a trivial type. It occupies a contiguous memory area. It can have members with different access specifiers. In C++, the compiler is free to choose how to order  members in this situation. Therefore, you can memcopy such objects but you cannot reliably consume them from a C program. A trivial type T can be copied into an array of char or unsigned char, and safely copied back into a T variable. Note that because of alignment requirements, there might be padding bytes between type members.  
  
 Trivial types have a trivial default constructor, trivial copy constructor, trivial copy assignment operator and trivial destructor. In each case, *trivial* means the constructor/operator/destructor is not user-provided and belongs to a class that has  
  
-   no virtual functions or virtual base classes,  
  
-   no base classes with a corresponding non-trivial constructor/operator/destructor  
  
-   no data members of class type with a corresponding non-trivial constructor/operator/destructor  
  
 The following examples show trivial types. In Trivial2, the presence of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> constructor requires that you provide a default constructor. For the type to qualify as trivial, you must explicitly default that constructor.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Standard layout types  
 When a class or struct does not contain certain C++ language features such as virtual functions which are not found in the C language, and all members have the same access control, it is a standard-layout type. It is memcopy-able and the layout is sufficiently defined that it can be consumed by C programs. Standard-layout types can have user-defined special member functions. In addition, standard layout types have these characteristics:  
  
-   no virtual functions or virtual base classes  
  
-   all non-static data members have the same access control  
  
-   all non-static members of class type are standard-layout  
  
-   any base classes are standard-layout  
  
-   has no base classes of the same type as the first non-static data member.  
  
-   meets one of these conditions:  
  
    -   no non-static data member in the most-derived class and no more than one base class with non-static data members, or  
  
    -   has no base classes with non-static data members  
  
 The following code shows one example of a standard-layout type:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The last two requirements can perhaps be better illustrated with code. In the next example, even though Base is standard-layout, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not standard layout because both it (the most derived class) and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> have non-static data members:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In this example <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is standard-layout because <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has no non-static data members:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Derived would also be standard-layout if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> had the data members and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> had only member functions.  
  
## POD types  
 When a class or struct is both trivial and standard-layout, it is a POD (Plain Old Data) type. The memory layout of POD types is therefore contiguous and each member has a higher address than the member that was declared before it, so that byte for byte copies and binary I/O can be performed on these types.  Scalar types such as int are also POD types. POD types that are classes can have only POD types as non-static data members.  
  
## Example  
 The following example shows the distinctions between trivial, standard-layout, and POD types:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Basic Concepts](../vs140/basic-concepts---c---.md)
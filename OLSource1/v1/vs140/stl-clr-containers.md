---
title: "STL-CLR Containers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "STL/CLR Containers"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "STL/CLR, containers"
  - "containers, STL/CLR"
ms.assetid: 34ca8031-2041-46b9-aed9-29082d1972ea
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# STL-CLR Containers
The STL/CLR Library has the same containers that are found in the Standard C++ Library, but it runs within the managed environment of the .NET Framework. If you are already familiar with the Standard Template Library (STL), STL/CLR is the best way to continue to use the skills that you have already developed while upgrading your code to target the common language runtime (CLR).  
  
 This document provides an overview of the containers in STL/CLR, such as the requirements for container elements, the types of elements that you can insert into the containers, and ownership issues with the elements in the containers. Where appropriate, differences between the native Standard Template Library and STL/CLR are mentioned.  
  
## Requirements for Container Elements  
 All elements inserted into STL containers must obey certain guidelines. For more information, see [Requirements for STL and STL/CLR Container Elements](../vs140/requirements-for-stl-clr-container-elements.md).  
  
## Valid Container Elements  
 STL/CLR containers can hold one of two types of elements:  
  
-   Handles to reference types.  
  
-   Reference types.  
  
-   Unboxed value types.  
  
 You cannot insert boxed value types into any of the STL/CLR containers.  
  
### Handles to Reference Types  
 You can insert a handle to a reference type into an STL/CLR container. A handle in C++ that targets the CLR is analogous to a pointer in native C++. For more information, see [^ (Handle to Object on Managed Heap)](../vs140/handle-to-object-operator--^----c---component-extensions-.md).  
  
#### Example  
 The following example shows how to insert a handle to an Employee object into a [cliext::set](../vs140/set--stl-clr-.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Reference Types  
 It is also possible to insert a reference type (rather than a handle to a reference type) into a STL/CLR container. The main difference here is that when a container of reference types is deleted, the destructor is called for all elements inside that container. In a container of handles to reference types, the destructors for these elements would not be called.  
  
#### Example  
 The following example shows how to insert an Employee object into a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Unboxed Value Types  
 You can also insert an unboxed value type into an STL/CLR container. An unboxed value type is a value type that has not been *boxed* into a reference type.  
  
 A value type element can be one of the standard value types, such as an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or it can be a user-defined value type, such as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information, see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)  
  
#### Example  
 The following example modifies the first example by making the Employee class a value type. This value type is then inserted into a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> just as in the first example.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If you attempt to insert a handle to a value type into a container, [Compiler Error C3225](../vs140/compiler-error-c3225.md) is generated.  
  
### Performance and Memory Implications  
 You must consider several factors when determining whether to use handles to reference types or value types as container elements. If you decide to use value types, remember that a copy of the element is made every time an element is inserted into the container. For small objects, this should not be a problem, but if the objects being inserted are large, performance might suffer. Also, if you are using value types, it is impossible to store one element in multiple containers at the same time because each container would have its own copy of the element.  
  
 If you decide to use handles to reference types instead, performance might increase because it is not necessary to make a copy of the element when it is inserted in the container. Also, unlike with value types, the same element can exist in multiple containers. However, if you decide to use handles, you must take care to ensure that the handle is valid and that the object it refers to has not been deleted elsewhere in the program.  
  
## Ownership Issues with Containers  
 Containers in STL/CLR work on value semantics. Every time you insert an element into a container, a copy of that element is inserted. If you want to get reference-like semantics, you can insert a handle to an object rather than the object itself.  
  
 When you call the clear or erase method of a container of handle objects, the objects that the handles refer to are not freed from memory. You must either explicitly delete the object, or, because these objects reside on the managed heap, allow the garbage collector to free the memory once it determines that the object is no longer being used.  
  
## See Also  
 [Standard Template Library Conventions](../vs140/standard-template-library.md)
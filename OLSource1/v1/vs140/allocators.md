---
title: "Allocators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocators"
  - "Standard C++ Library, allocators"
ms.assetid: ac95023b-9e7d-49f5-861a-bf7a9a340746
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Allocators
Allocators are used by the Standard Template Library to handle the allocation and deallocation of elements stored in containers. All STL containers except std::array have a template parameter of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> represents the type of the container element. For example, the vector class is declared as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The Standard Template Library provides a default implementation for an allocator. In C++11 and later, the default allocator is updated to expose a smaller interface; the new allocator is called a *minimal allocator*. In particular, the minimal allocator's <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member supports move semantics, which can greatly improve performance. In most cases, this default allocator should be sufficient. In C++11 all the Standard Library types and functions that take an allocator type parameter support the minimal allocator interface, including <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  For more information on the default allocator, see [allocator Class](../vs140/allocator-class.md).  
  
## Writing Your Own Allocator (C++11)  
 The default allocator uses <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to allocate and deallocate memory. If you want to use a different method of memory allocation, such as using shared memory, then you must create your own allocator. If you are targeting C++11 and you need to write a new custom allocator, make it a minimal allocator if possible. Even if you have already implemented an old-style allocator, consider modifying it to be a *minimal allocator* in order to take advantage of the more efficient <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method that will be provided for you automatically.  
  
 A minimal allocator requires much less boilerplate and enable you to focus on the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member functions which do all of the work. When creating a minimal allocator, do not implement any members except the ones shown in the example below:  
  
1.  a converting copy constructor (see example)  
  
2.  operator==  
  
3.  operator!=  
  
4.  allocate  
  
5.  deallocate  
  
 The C++11 default <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member that will be provided for you does perfect forwarding and enables move semantics; it is much more efficient in many cases than the older version.  
  
> [!WARNING]
>  At compile time, the STL uses the allocator_traits class to detect which members you have explicitly provided and provides a default implementation for any members that are not present. Do not interfere with this mechanism by providing a specialization of allocator_traits for your allocator!  
  
 The following example shows a minimal implementation of an allocator that uses <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Note the use of the new exception type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> which is thrown if the array size is less than zero or greater than the maximum allowed size.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Writing Your Own Allocator (C++03)  
 In C++03, any allocator used with STL containers must implement the following type definitions:  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
  
 In addition, any allocator used with STL containers must implement the following methods:  
  
|||  
|-|-|  
|Constructor|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|Copy constructor|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|Destructor|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>||  
  
 For more information on these type definitions and methods, see [allocator Class](../vs140/allocator-class.md).  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)
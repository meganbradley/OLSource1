---
title: "new and delete Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "delete_cpp"
  - "new_cpp"
  - "new"
  - "delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "new keyword [C++], dynamic allocation of objects"
  - "nothrownew.obj"
  - "delete keyword [C++], syntax"
ms.assetid: fa721b9e-0374-4f04-bb87-032ea775bcc8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# new and delete Operators
C++ supports dynamic allocation and deallocation of objects using the [new](../vs140/new-operator--c---.md) and [delete](../vs140/delete-operator--c---.md) operators. These operators allocate memory for objects from a pool called the free store. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator calls the special function [operator new](../vs140/operator-new-function.md), and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator calls the special function [operator delete](../vs140/operator-delete-function.md).  
  
 In [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] .NET 2002, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function in the Standard C++ Library will support the behavior specified in the C++ standard, which is to throw a std::bad_alloc exception if the memory allocation fails.  
  
 The C Runtime Library's <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function will also throw a std::bad_alloc exception if the memory allocation fails.  
  
 If you still want the non-throwing version of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for the C Runtime Library, link your program with nothrownew.obj.  However, when you link with nothrownew.obj, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in the Standard C++ Library will no longer function.  
  
 For a list of the library files that comprise the C Runtime Library and the Standard C++ Library, see [C Run-Time Libraries](../vs140/crt-library-features.md).  
  
## The new operator  
 When a statement such as the following is encountered in a program, it translates into a call to the function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If the request is for zero bytes of storage, **operator new** returns a pointer to a distinct object (that is, repeated calls to **operator new** return different pointers). If there is insufficient memory for the allocation request, **operator new** returns **NULL** or throws an exception (see [The new and delete Operators](../vs140/new-and-delete-operators.md) for more information).  
  
 You can write a routine that attempts to free memory and retry the allocation; see [_set_new_handler](../vs140/_set_new_handler.md) for more information. For more details on the recovery scheme, see the following topic, [Handling Insufficient Memory Conditions](../vs140/handling-insufficient-memory-conditions.md).  
  
 The two scopes for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions are described in the following table.  
  
### Scope for operator new Functions  
  
|Operator|Scope|  
|--------------|-----------|  
|**::operator new**|Global|  
|*class-name* **::operator new**|Class|  
  
 The first argument to **operator new** must be of type **size_t** (a type defined in STDDEF.H), and the return type is always **void \***.  
  
 The global **operator new** function is called when the **new** operator is used to allocate objects of built-in types, objects of class type that do not contain user-defined **operator new** functions, and arrays of any type. When the **new** operator is used to allocate objects of a class type where an **operator new** is defined, that class's **operator new** is called.  
  
 An **operator new** function defined for a class is a static member function (which cannot, therefore, be virtual) that hides the global **operator new** function for objects of that class type. Consider the case where **new** is used to allocate and set memory to a given value:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The argument supplied in parentheses to **new** is passed to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> as the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument. However, the global **operator new** function is hidden, causing code such as the following to generate an error:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In Visual C++ 5.0 and earlier, nonclass types and all arrays (regardless of whether they were of **class** type) allocated using the **new** operator always used the global **operator new** function.  
  
 Beginning with Visual C++ 5.0, the compiler supports member array **new** and **delete** operators in a class declaration. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Handling insufficient memory  
 Testing for failed memory allocation can be done with code such as the following:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 There is another ways to handle failed memory allocation requests: write a custom recovery routine to handle such a failure, then register your function by calling the [_set_new_handler](../vs140/_set_new_handler.md) run-time function.  
  
## The delete operator  
 Memory that is dynamically allocated using the **new** operator can be freed using the **delete** operator. The delete operator calls the **operator delete** function, which frees memory back to the available pool. Using the **delete** operator also causes the class destructor (if there is one) to be called.  
  
 There are global and class-scoped **operator delete** functions. Only one **operator delete** function can be defined for a given class; if defined, it hides the global **operator delete** function. The global **operator delete** function is always called for arrays of any type.  
  
 The global **operator delete** function. Two forms exist for the  global **operator delete**  and class-member **operator delete** functions:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Only one of the preceding two forms can be present for a given class. The first form takes a single argument of type **void \***, which contains a pointer to the object to deallocate. The second form—sized deallocation—takes two arguments, the first of which is a pointer to the memory block to deallocate and the second of which is the number of bytes to deallocate. The return type of both forms is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (**operator delete** cannot return a value).  
  
 The intent of the second form is to speed up searching for the correct size category of the object to be deleted, which is often not stored near the allocation itself and likely uncached; the second form is particularly useful when an **operator delete** function from a base class is used to delete an object of a derived class.  
  
 The **operator delete** function is static; therefore, it cannot be virtual. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function obeys access control, as described in [Member-Access Control](../vs140/member-access-control--c---.md).  
  
 The following example shows user-defined **operator new** and **operator delete** functions designed to log allocations and deallocations of memory:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The preceding code can be used to detect "memory leakage" — that is, memory that is allocated on the free store but never freed. To perform this detection, the global **new** and **delete** operators are redefined to count allocation and deallocation of memory.  
  
 Beginning with Visual C++ 5.0, the compiler supports member array **new** and **delete** operators in a class declaration. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [Special Member Functions](../vs140/special-member-functions--c---.md)
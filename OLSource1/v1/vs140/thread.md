---
title: "thread"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "thread"
  - "thread_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "thread local storage (TLS)"
  - "thread __declspec keyword"
  - "TLS (thread local storage), compiler implementation"
  - "__declspec keyword [C++], thread"
ms.assetid: 667f2a77-6d1f-4b41-bee8-05e67324fab8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# thread
**Microsoft Specific**  
  
 The **thread** extended storage-class modifier is used to declare a thread local variable. For the portable equivalent in C++11, use the [thread_local](../vs140/storage-classes--c---.md#thread_local) storage class specifier.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Thread Local Storage (TLS) is the mechanism by which each thread in a multithreaded process allocates storage for thread-specific data. In standard multithreaded programs, data is shared among all threads of a given process, whereas thread local storage is the mechanism for allocating per-thread data. For a complete discussion of threads, see [Multithreading](../vs140/multithreading-support-for-older-code--visual-c---.md).  
  
 Declarations of thread local variables must use [extended attribute syntax](../vs140/__declspec.md) and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword with the **thread** keyword. For example, the following code declares an integer thread local variable and initializes it with a value:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You must observe these guidelines when declaring thread local objects and variables:  
  
-   You can apply the **thread** attribute only to class and data declarations and definitions; **thread** cannot be used on function declarations or definitions.  
  
-   The use of the **thread** attribute may interfere with [delay loading](../vs140/linker-support-for-delay-loaded-dlls.md) of DLL imports**.**  
  
-   On XP systems, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> may not function correctly if a DLL uses __declspec(thread) data and it is loaded dynamically via LoadLibrary.  
  
-   You can specify the **thread** attribute only on data items with static storage duration. This includes global data objects (both **static** and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), local static objects, and static data members of classes. You cannot declare automatic data objects with the **thread** attribute.  
  
-   You must use the **thread** attribute for the declaration and the definition of a thread local object, whether the declaration and definition occur in the same file or separate files.  
  
-   You cannot use the **thread** attribute as a type modifier.  
  
-   Because the declaration of objects that use the **thread** attribute is permitted, these two examples are semantically equivalent:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Standard C permits initialization of an object or variable with an expression involving a reference to itself, but only for objects of nonstatic extent. Although C++ normally permits such dynamic initialization of an object with an expression involving a reference to itself, this type of initialization is not permitted with thread local objects. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Note that a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> expression that includes the object being initialized does not constitute a reference to itself and is allowed in C and C++.  
  
 **END Microsoft Specific**  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [Thread Local Storage (TLS)](../vs140/thread-local-storage--tls-.md)
---
title: "C++ Stack Semantics for Reference Types"
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
  - "reference types, C++ stack semantics for"
ms.assetid: 319a1304-f4a4-4079-8b84-01cec847d531
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C++ Stack Semantics for Reference Types
Prior to Visual C++ 2005, an instance of a reference type could only be created using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator, which created the object on the garbage collected heap. However, you can now create an instance of a reference type using the same syntax that you would use to create an instance of a native type on the stack. So, you do not need to use [gcnew](../vs140/ref-new--gcnew---c---component-extensions-.md) to create an object of a reference type. And when the object goes out of scope, the compiler calls the object's destructor.  
  
## Remarks  
 When you create an instance of a reference type using stack semantics, the compiler does internally create the instance on the garbage collected heap (using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 When the signature or return type of a function includes an instance of a by-value reference type, the function will be marked in the metadata as requiring special handling (with modreq). This special handling is currently only provided by Visual C++ clients; other languages do not currently support consuming functions or data that use reference types created with stack semantics.  
  
 One reason to use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (dynamic allocation) instead of stack semantics would be if the type has no destructor. Also, using reference types created with stack semantics in function signatures would not be possible if you want your functions to be consumed by languages other than Visual C++.  
  
 The compiler will not generate a copy constructor for a reference type. Therefore, if you define a function that uses a by-value reference type in the signature, you must define a copy constructor for the reference type. A copy constructor for a reference type has a signature of the following form: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The compiler will not generate a default assignment operator for a reference type. An assignment operator allows you to create an object using stack semantics and initialize it with an existing object created using stack semantics. An assignment operator for a reference type has a signature of the following form: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 If your type's destructor releases critical resources and you use stack semantics for reference types, you do not need to explicitly call the destructor (or call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). For more information on destructors in reference types, see [Destructors and Finalizers](../vs140/destructors-and-finalizers-in-visual-c--.md).  
  
 A compiler-generated assignment operator will follow the usual standard C++ rules with the following additions:  
  
-   Any non-static data members whose type is a handle to a reference type will be shallow copied (treated like a non-static data member whose type is a pointer).  
  
-   Any non-static data member whose type is a value type will be shallow copied.  
  
-   Any non-static data member whose type is an instance of a reference type will invoke a call to the reference type’s copy constructor.  
  
 The compiler also provides a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> unary operator to convert an instance of a reference type created using stack semantics to its underlying handle type.  
  
 The following reference types are not available for use with stack semantics:  
  
-   [delegate](../vs140/delegate---c---component-extensions-.md)  
  
-   [array](../vs140/arrays--c---component-extensions-.md)  
  
-   \<xref:System.String*>  
  
## Example  
  
### Description  
 The following code sample shows how to declare instances of reference types with stack semantics, how the assignment operator and copy constructor works, and how to initialize a tracking reference with reference type created using stack semantics.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)
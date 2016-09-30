---
title: "pin_ptr (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "pin_ptr (C++/CLI)"
f1_keywords: 
  - "pin_ptr_cpp"
  - "stdcli::language::pin_ptr"
  - "pin_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pinning pointers"
  - "pin_ptr keyword [C++]"
ms.assetid: 6c2e6c73-4ec2-4dce-8e1f-ccf3a9f9d0aa
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pin_ptr (C++-CLI)
Declares a *pinning pointer*, which is used only with the common language runtime.  
  
## All Runtimes  
 (There are no remarks for this language feature that apply to all runtimes.)  
  
## Windows Runtime  
 (This language feature is not supported in the Windows Runtime.)  
  
## Common Language Runtime  
 A *pinning pointer* is an interior pointer that prevents the object pointed to from moving on the garbage-collected heap. That is, the value of a pinning pointer is not changed by the common language runtime. This is required when you pass the address of a managed class to an unmanaged function so that the address will not change unexpectedly during resolution of the unmanaged function call.  
  
### Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 *cv_qualifier*  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> qualifiers. By default, a pinning pointer is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. It is redundant but not an error to declare a pinning pointer <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 *type*  
 The type of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 *var*  
 The name of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> variable.  
  
 *initializer*  
 A member of a reference type, element of a managed array, or any other object that you can assign to a native pointer.  
  
### Remarks  
 A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> represents a superset of the functionality of a native pointer. Therefore, anything that can be assigned to a native pointer can also be assigned to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. An interior pointer is permitted to perform the same set of operations as native pointers, including comparison and pointer arithmetic.  
  
 An object or sub-object of a managed class can be pinned, in which case the common language runtime will not move it during garbage collection. The principal use of this is to pass a pointer to managed data as an actual parameter of an unmanaged function call. During a collection cycle, the runtime will inspect the metadata created for the pinning pointer and will not move the item it points to.  
  
 Pinning an object also pins its value fields; that is, fields of primitive or value type. However, fields declared by tracking handle (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) are not pinned.  
  
 Pinning a sub-object defined in a managed object has the effect of pinning the whole object.  
  
 If the pinning pointer is reassigned to point to a new value, the previous instance pointed to is no longer considered pinned.  
  
 An object is pinned only while a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> points to it. The object is no longer pinned when its pinning pointer goes out of scope, or is set to [nullptr](../vs140/nullptr---c---component-extensions-.md). After the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> goes out of scope, the object that was pinned can be moved in the heap by the garbage collector. Any native pointers that still point to the object will not be updated, and de-referencing one of them could raise an unrecoverable exception.  
  
 If no pinning pointers point to the object (all pinning pointers went out of scope, were reassigned to point to other objects, or were assigned [nullptr](../vs140/nullptr---c---component-extensions-.md)), the object is guaranteed not to be pinned.  
  
 A pinning pointer can point to a reference handle, value type or boxed type handle, member of a managed type, or an element of a managed array. It cannot point to a reference type.  
  
 Taking the address of a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that points to a native object causes undefined behavior.  
  
 Pinning pointers can only be declared as non-static local variables on the stack.  
  
 Pinning pointers cannot be used as:  
  
-   function parameters  
  
-   the return type of a function  
  
-   a member of a class  
  
-   the target type of a cast.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> namespace. For more information, see [cli Namespace](../vs140/platform--default--and-cli-namespaces---c---component-extensions-.md).  
  
 For more information about interior pointers, see [interior_ptr (C++/CLI)](../vs140/interior_ptr--c---cli-.md).  
  
 For more information about pinning pointers, see [How to: Pin Pointers and Arrays](../vs140/how-to--pin-pointers-and-arrays.md) and [How to: Declare Pinning Pointers and Value Types](../vs140/how-to--declare-pinning-pointers-and-value-types.md).  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following example uses <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to constrain the position of the first element of an array.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **45** **Example**  
  
 The following example shows that an interior pointer can be converted to a pinning pointer, and that the return type of the address-of operator (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) is an interior pointer when the operand is on the managed heap.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **1** **Example**  
  
 The following example shows that a pinning pointer can be cast to another type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **8**   
**255**
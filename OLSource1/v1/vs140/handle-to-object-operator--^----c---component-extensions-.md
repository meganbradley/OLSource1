---
title: "Handle to Object Operator (^)  (C++ Component Extensions)"
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
  - "^ handle to object [C++]"
ms.assetid: 70c411e6-be57-4468-a944-6ea7be89f392
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Handle to Object Operator (^)  (C++ Component Extensions)
The *handle declarator* (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, pronounced "hat"), modifies the type [specifier](../vs140/overview-of-declarators.md) to mean that the declared object should be automatically deleted when the system determines that the object is no longer accessible.  
  
## Accessing the Declared Object  
 A variable that is declared with the handle declarator behaves like a pointer to the object. However, the variable points to the entire object, cannot point to a member of the object, and it does not support pointer arithmetic. Use the indirection operator (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) to access the object, and the arrow member-access operator (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) to access a member of the object.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 The compiler uses the COM *reference counting* mechanism to determine if the object is no longer being used and can be deleted. This is possible because an object that is derived from a Windows Runtime interface is actually a COM object. The reference count is incremented when the object is created or copied, and decremented when the object is set to null or goes out of scope. If the reference count goes to zero, the object is automatically and immediately deleted.  
  
 The advantage of the handle declarator is that in COM you must explicitly manage the reference count for an object, which is a tedious and error prone process. That is, to increment and decrement the reference count you must call the object's AddRef() and Release() methods. However, if you declare an object with the handle declarator, the Visual C++ compiler generates code that automatically adjusts the reference count.  
  
 For information on how to instantiate an object, see [ref new](../vs140/ref-new--gcnew---c---component-extensions-.md).  
  
## Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 The system uses the CLR *garbage collector* mechanism to determine if the object is no longer being used and can be deleted. The common language runtime maintains a heap on which it allocates objects, and uses managed references (variables) in your program indicate the location of objects on the heap. When an object is no longer used, the memory that it occupied on the heap is freed. Periodically, the garbage collector compacts the heap to better use the freed memory. Compacting the heap can move objects on the heap, which invalidates the locations refered to by managed references. However, the garbage collector is aware of the location of all managed references, and automatically updates them to indicate the current location of the objects on the heap.  
  
 Because native C++ pointers (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) and references (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) are not managed references, the garbage collector cannot automatically update the addresses they point to. To solve this problem, use the handle declarator to specify a variable that the garbage collector is aware of and can update automatically.  
  
 In Visual C++ 2002 and Visual C++ 2003, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> was used to declare an object on the managed heap.  The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> replaces <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the new syntax.  
  
 For more information, see [Handles in Native Types](../vs140/how-to--declare-handles-in-native-types.md).  
  
### Examples  
 **Example**  
  
 This sample shows how to create an instance of a reference type on the managed heap.  This sample also shows that you can initialize one handle with another, resulting in two references to same object on managed, garbage-collected heap. Notice that assigning [nullptr](../vs140/nullptr---c---component-extensions-.md) to one handle does not mark the object for garbage collection.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **1**   
**2** **Example**  
  
 The following sample shows how to declare a handle to an object on the managed heap, where the type of object is a boxed value type. The sample also shows how to get the value type from the boxed object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **Not a boxed int**   
**100** **Example**  
  
 This sample shows that the common C++ idiom of using a void* pointer to point to an arbitrary object is replaced by Object^, which can hold a handle to any reference class. It also shows that all types, such as arrays and delegates, can be converted to an object handle.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **Type is System.Collections.ArrayList**   
 **Type is System.Int32**   
 **Type is MyDel** **Example**  
  
 This sample shows that a handle can be dereferenced and that a member can be accessed via a dereferenced handle.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **Array value: 7**   
 **Cannot access array element 11, size is 10** **Example**  
  
 This sample shows that a native reference (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) can’t bind to an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> member of a managed type, as the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> might be stored in the garbage collected heap, and native references don’t track object movement in the managed heap. The fix is to use a local variable, or to change <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, making it a tracking reference.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Requirements  
 Compiler option: **/clr**  
  
## See Also  
 [Component Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)   
 [% (Tracking Reference)](../vs140/tracking-reference-operator--c---component-extensions-.md)
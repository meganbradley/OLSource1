---
title: "How to: Declare Handles in Native Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
f1_keywords: 
  - "gcroot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "handles, declaring"
  - "gcroot keyword [C++]"
  - "types [C++], declaring handles in"
ms.assetid: b8c0eead-17e5-4003-b21f-b673f997d79f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare Handles in Native Types
You cannot declare a handle type in a native type. vcclr.h provides the type-safe wrapper template <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to refer to a CLR object from the C++ heap. This template lets you embed a virtual handle in a native type and treat it as if it were the underlying type. In most cases, you can use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object as the embedded type without any casting. However, with [for each, in](../vs140/for-each--in.md), you have to use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to retrieve the underlying managed reference.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> template is implemented using the facilities of the value class System::Runtime::InteropServices::GCHandle, which provides "handles" into the garbage-collected heap. Note that the handles themselves are not garbage collected and are freed when no longer in use by the destructor in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class (this destructor cannot be called manually). If you instantiate a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object on the native heap, you must call delete on that resource.  
  
 The runtime will maintain an association between the handle and the CLR object, which it references. When the CLR object moves with the garbage-collected heap, the handle will return the new address of the object. A variable does not have to be pinned before it is assigned to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> template.  
  
## Example  
 This sample shows how to create a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object on the native stack.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **hello**   
## Example  
 This sample shows how to create a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object on the native heap.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **hello**   
## Example  
 This sample shows how to use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to hold references to value types (not reference types) in a native type by using <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> on the boxed type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **String in V: Hello**   
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)
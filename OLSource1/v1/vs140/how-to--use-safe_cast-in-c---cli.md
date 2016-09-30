---
title: "How to: Use safe_cast in C++-CLI"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Use safe_cast in C++/CLI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "safe_cast keyword [C++], upcasting"
ms.assetid: 0fbc87d8-ecdf-4cd5-81f4-0d8cc18e2aff
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use safe_cast in C++-CLI
This article shows how to use safe_cast in [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] applications. For information about safe_cast in [!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)], see [safe_cast](../vs140/safe_cast--c---component-extensions-.md).  
  
## Upcasting  
 An upcast is a cast from a derived type to one of its base classes. This cast is safe and does not require an explicit cast notation. The following sample shows how to perform an upcast, with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and without it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **in C::Test**  
**in B::Test2**  
**in C::Test**  
**in B::Test2**   
## Downcasting  
 A downcast is a cast from a base class to a class that's derived from the base class.  A downcast is safe only if the object that's addressed at runtime is actually addressing a derived class object.  Unlike <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> performs a dynamic check and throws \<xref:System.InvalidCastException*> if the conversion fails.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **in C::Test()**  
**in C::Test()**  
**in B::Test2()**   
## safe_cast with user-defined conversions  
 The next sample shows how you can use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to invoke user-defined conversions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **in operator R^(V& v**  
**in operator V^(R^ r)**   
## safe_cast and boxing operations  
 **Boxing**  
  
 Boxing is defined as a compiler-injected, user-defined conversion.  Therefore, you can use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to box a value on the CLR heap.  
  
 The following sample shows boxing with simple and user-defined value types.  A <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> boxes a value type variable that's on the native stack so that it can be assigned to a variable on the garbage-collected heap.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The next sample shows that boxing has priority over a user-defined conversion in a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operation.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Unboxing**  
  
 Unboxing is defined as a compiler-injected, user-defined conversion.  Therefore, you can use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to unbox a value on the CLR heap.  
  
 Unboxing is a user-defined conversion, but unlike boxing, unboxing must be explicit—that is, it must be performed by a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, C-style cast, or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; unboxing cannot be performed implicitly.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The following sample shows unboxing with value types and primitive types.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## safe_cast and generic types  
 The next sample shows how you can use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to perform a downcast with a generic type.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [safe_cast](../vs140/safe_cast--c---component-extensions-.md)
---
title: "nothrow_t Structure"
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
  - "nothrow_t"
  - "std.nothrow_t"
  - "std::nothrow_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nothrow_t class"
ms.assetid: dc7d5d42-ed5a-4919-88fe-bbad519b7a1d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nothrow_t Structure
The struct is used as a function parameter to operator new to indicate that the function should return a null pointer to report an allocation failure, rather than throw an exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The struct helps the compiler to select the correct version of the constructor. [nothrow](../vs140/-new--functions.md#nothrow) is a synonym for objects of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Example  
 See [operator new](../vs140/-new--operators.md#operator_new) and [operator new&#91;&#93;](../vs140/-new--operators.md#operator_new_at) for examples of how <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used as a function parameter.  
  
## Requirements  
 **Header:** \<new>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)
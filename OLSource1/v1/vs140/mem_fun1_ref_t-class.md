---
title: "mem_fun1_ref_t Class"
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
  - "xfunctional/std::mem_fun1_ref_t"
  - "std::mem_fun1_ref_t"
  - "mem_fun1_ref_t"
  - "std.mem_fun1_ref_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mem_fun1_ref_t class"
ms.assetid: 7d6742f6-19ba-4523-b3c8-0e5b8f11464f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mem_fun1_ref_t Class
An adapter class that allows a **non_const** member function that takes a single argument to be called as a binary function object when initialized with a reference argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the member function of class **Type** to be converted to a function object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object that the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function is called on.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The argument that is being given to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 An adaptable binary function.  
  
## Remarks  
 The template class stores a copy of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which must be a pointer to a member function of class **Type**, in a private member object. It defines its member function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as returning ( **_Left**.\* <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>)( **_Right**).  
  
## Example  
 The constructor of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not usually used directly; the helper function <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is used to adapt member functions. See [mem_fun_ref](../vs140/-functional--functions.md#mem_fun_ref_function) for an example of how to use member function adaptors.  
  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
---
title: "const_mem_fun_t Class"
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
  - "const_mem_fun_t"
  - "std.const_mem_fun_t"
  - "xfunctional/std::const_mem_fun_t"
  - "std::const_mem_fun_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_mem_fun_t class"
ms.assetid: f169d381-019b-4a0e-a9a3-54da6d948270
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# const_mem_fun_t Class
An adapter class that allows a const member function that takes no arguments to be called as a unary function object when initialized with a reference argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the member function of class **Type** to be converted to a function object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object that the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function is called on.  
  
## Return Value  
 An adaptable unary function.  
  
## Remarks  
 The template class stores a copy of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which must be a pointer to a member function of class **Type**, in a private member object. It defines its member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> as returning ( <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>->\* <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>)() **const**.  
  
## Example  
 The constructor of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is not usually used directly; the helper function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used to adapt member functions. See [mem_fun](../vs140/-functional--functions.md#mem_fun_function) for an example of how to use member function adaptors.  
  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
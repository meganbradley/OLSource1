---
title: "mem_fun_ref_t Class"
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
  - "xfunctional/std::mem_fun_ref_t"
  - "mem_fun_ref_t"
  - "std.mem_fun_ref_t"
  - "std::mem_fun_ref_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mem_fun_ref_t class"
ms.assetid: 7dadcac3-8d33-4e4b-a792-81bd53d3df39
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mem_fun_ref_t Class
An adapter class that allows a **non_const** member function that takes no arguments to be called as a unary function object when initialized with a reference argument.  
  
## Syntax  
  
```  
template<class Result, class Type>  
   class mem_fun_ref_t : public unary_function<Type, Result> {  
      explicit mem_fun_ref_t(  
         Result ( Type::* _Pm )( )   
      );  
      Result operator()( Type& _Left ) const;  
   };  
```  
  
#### Parameters  
 `_Pm`  
 A pointer to the member function of class **Type** to be converted to a function object.  
  
 `_Left`  
 The object that the `_Pm` member function is called on.  
  
## Return Value  
 An adaptable unary function.  
  
## Remarks  
 The template class stores a copy of `_Pm`, which must be a pointer to a member function of class **Type**, in a private member object. It defines its member function `operator()` as returning ( **_Left**.* `_Pm`)( ).  
  
## Example  
  The constructor of `mem_fun_ref_t` is not usually used directly; the helper function `mem_fun_ref` is used to adapt member functions. See [mem_fun_ref](../vs140/-functional--functions.md#mem_fun_ref_function) for an example of how to use member function adaptors.  
  
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
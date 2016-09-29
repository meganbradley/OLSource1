---
title: "mem_fun1_t Class"
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
  - "mem_fun1_t"
  - "std.mem_fun1_t"
  - "std::mem_fun1_t"
  - "xfunctional/std::mem_fun1_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mem_fun1_t class"
ms.assetid: 01a8c2c2-b2f7-4e3f-869c-5b5b9f06ea54
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mem_fun1_t Class
An adapter class that allows a **non_const** member function that takes a single argument to be called as a binary function object when initialized with a pointer argument.  
  
## Syntax  
  
```  
template<class Result, class Type, class Arg>  
   class mem_fun1_t : public binary_function<Type *, Arg, Result> {  
      explicit mem_fun1_t(  
         Result (Type::* _Pm )( Arg )   
         );  
      Result operator()(  
         Type* _Pleft,   
         Arg _Right  
         ) const;  
   };  
```  
  
#### Parameters  
 `_Pm`  
 A pointer to the member function of class **Type** to be converted to a function object.  
  
 `_Pleft`  
 The object that the `_Pm` member function is called on.  
  
 `_Right`  
 The argument that is being given to `_Pm`.  
  
## Return Value  
 An adaptable binary function.  
  
## Remarks  
 The template class stores a copy of `_Pm`, which must be a pointer to a member function of class **Type**, in a private member object. It defines its member function `operator()` as returning ( **_Pleft**->\* `_Pm`)( **_Right**).  
  
## Example  
  The constructor of `mem_fun1_t` is not usually used directly; the helper function `mem_fun` is used to adapt member functions. See [mem_fun](../vs140/-functional--functions.md#mem_fun_function) for an example of how to use member function adaptors.  
  
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
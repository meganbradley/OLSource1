---
title: "function::assign"
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
  - "assign"
  - "functional/std::tr1::assign"
  - "function.assign"
  - "function::assign"
  - "std::tr1::function::assign"
  - "std.tr1.function.assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method[TR1]"
ms.assetid: ae6afc85-a7e1-4246-b130-af075b9720c5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::assign
Assigns a callable object to this function object.  
  
## Syntax  
  
```  
template<class Fx, class Alloc>  
    void assign(  
        Fx _Func,   
        const Alloc& _Ax  
);  
template<class Fx, class Alloc>  
    void assign(  
        reference_wrapper<Fx> _Fnref,   
        const Alloc& _Ax  
);  
```  
  
#### Parameters  
 `_Func`  
 A callable object.  
  
 `_Fnref`  
 A reference wrapper that contains a callable object.  
  
 `_Ax`  
 An allocator object.  
  
## Property Value/Return Value  
  
## Remarks  
 The member functions each replace the `callable object` held by `*this` with the callable object passed as the `operand`. Both allocate storage with the allocator object `_Ax`.  
  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [mem_fn](../vs140/mem_fn-function.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [reference_wrapper](../vs140/reference_wrapper-class.md)
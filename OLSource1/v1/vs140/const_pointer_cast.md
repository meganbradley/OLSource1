---
title: "const_pointer_cast"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - const_pointer_cast
  - std::tr1::const_pointer_cast
  - std.tr1.const_pointer_cast
  - memory/std::tr1::const_pointer_cast
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_pointer_cast function [TR1]
ms.assetid: 53d61b0a-d7eb-4f6e-bf32-7749da6b88cf
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# const_pointer_cast
Const cast to shared_ptr.  
  
## Syntax  
  
```  
template <class Ty, class Other>  
    shared_ptr<Ty> const_pointer_cast(const shared_ptr<Other>& sp);  
```  
  
#### Parameters  
 `Ty`  
 The type controlled by the returned shared pointer.  
  
 `Other`  
 The type controlled by the argument shared pointer.  
  
 `Other`  
 The argument shared pointer.  
  
## Remarks  
 The template function returns an empty shared_ptr object if `const_cast<Ty*>(sp.get())` returns a null pointer; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)`<Ty>` object that owns the resource that is owned by `sp`. The expression `const_cast<Ty*>(sp.get())` must be valid.  
  
## Example  
  
```  
// std_tr1__memory__const_pointer_cast.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0(new int);   
    std::shared_ptr<const int> sp1 =   
        std::const_pointer_cast<const int>(sp0);   
  
    *sp0 = 3;   
    std::cout << "sp1 == " << *sp1 << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **sp1 == 3**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [dynamic_pointer_cast](../vs140/dynamic_pointer_cast.md)   
 [static_pointer_cast](../vs140/static_pointer_cast.md)
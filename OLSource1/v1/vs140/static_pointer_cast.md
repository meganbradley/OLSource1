---
title: "static_pointer_cast"
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
  - "std.tr1.static_pointer_cast"
  - "std::tr1::static_pointer_cast"
  - "memory/std::tr1::static_pointer_cast"
  - "static_pointer_cast"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "static_pointer_cast function [TR1]"
ms.assetid: 69373bf4-87e5-41ec-902c-81f4886b5736
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# static_pointer_cast
Static cast to shared_ptr.  
  
## Syntax  
  
```  
template <class Ty, class Other>  
    shared_ptr<Ty> static_pointer_cast(const shared_ptr<Other>& sp);  
```  
  
#### Parameters  
 `Ty`  
 The type controlled by the returned shared pointer.  
  
 `Other`  
 The type controlled by the argument shared pointer.  
  
 `Other`  
 The argument shared pointer.  
  
## Remarks  
 The template function returns an empty shared_ptr object if `sp` is an empty `shared_ptr` object; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)`<Ty>` object that owns the resource that is owned by `sp`. The expression `static_cast<Ty*>(sp.get())` must be valid.  
  
## Example  
  
```  
// std_tr1__memory__static_pointer_cast.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
struct base   
    {   
    int val;   
    };   
  
struct derived   
    : public base   
    {   
    };   
  
int main()   
    {   
    std::shared_ptr<base> sp0(new derived);   
    std::shared_ptr<derived> sp1 =   
        std::static_pointer_cast<derived>(sp0);   
  
    sp0->val = 3;   
    std::cout << "sp1->val == " << sp1->val << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **sp1->val == 3**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [const_pointer_cast](../vs140/const_pointer_cast.md)   
 [dynamic_pointer_cast](../vs140/dynamic_pointer_cast.md)
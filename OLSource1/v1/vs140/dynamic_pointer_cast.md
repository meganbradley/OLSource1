---
title: "dynamic_pointer_cast"
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
  - "std::tr1::dynamic_pointer_cast"
  - "std.tr1.dynamic_pointer_cast"
  - "dynamic_pointer_cast"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dynamic_pointer_cast function [TR1]"
ms.assetid: dc6c9dff-0fb9-4e42-a63d-d221e5f1a33e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# dynamic_pointer_cast
Dynamic cast to shared_ptr.  
  
## Syntax  
  
```  
template <class Ty, class Other>  
    shared_ptr<Ty> dynamic_pointer_cast(const shared_ptr<Other>& sp);  
```  
  
#### Parameters  
 `Ty`  
 The type controlled by the returned shared pointer.  
  
 `Other`  
 The type controlled by the argument shared pointer.  
  
 `sp`  
 The argument shared pointer.  
  
## Remarks  
 The template function returns an empty shared_ptr object if `dynamic_cast<Ty*>(sp.get())` returns a null pointer; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)`<Ty>` object that owns the resource that is owned by `sp`. The expression `dynamic_cast<Ty*>(sp.get())` must be valid.  
  
## Example  
  
```  
// std_tr1__memory__dynamic_pointer_cast.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
struct base   
    {   
    virtual ~base()   
        {   
        }   
  
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
        std::dynamic_pointer_cast<derived>(sp0);   
  
    sp0->val = 3;   
    std::cout << "sp1->val == " << sp1->val << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **sp1->val == 3**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [const_pointer_cast](../vs140/const_pointer_cast.md)   
 [static_pointer_cast](../vs140/static_pointer_cast.md)
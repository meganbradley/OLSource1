---
title: "shared_ptr::operator-&gt;"
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
  - "shared_ptr.operator->"
  - "memory/std::tr1::shared_ptr::operator->"
  - "std::tr1::shared_ptr::operator->"
  - "tr1::shared_ptr::operator->"
  - "operator->"
  - "shared_ptr::operator->"
  - "tr1.shared_ptr.operator->"
  - "std.tr1.shared_ptr.operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-> operator [TR1]"
  - "operator->"
ms.assetid: 1fbefacf-ad63-4c2e-887a-8218023a6a36
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::operator-&gt;
Gets a pointer to the designated value.  
  
## Syntax  
  
```  
Ty *operator->() const;  
```  
  
## Remarks  
 The selection operator returns `get()`, so that the expression `sp->member` behaves the same as `(sp.get())->member` where `sp` is an object of class `shared_ptr<Ty>`. Hence, the stored pointer must not be null, and `Ty` must be a class, structure, or union type with a member `member`.  
  
## Example  
  
```  
// std_tr1__memory__shared_ptr_operator_ar.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
typedef std::pair<int, int> Mypair;   
int main()   
    {   
    std::shared_ptr<Mypair> sp0(new Mypair(1, 2));   
  
    std::cout << "sp0->first == " << sp0->first << std::endl;   
    std::cout << "sp0->second == " << sp0->second << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **sp0->first == 1**  
**sp0->second == 2**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::get](../vs140/shared_ptr--get.md)   
 [shared_ptr::operator*](../vs140/shared_ptr--operator-.md)
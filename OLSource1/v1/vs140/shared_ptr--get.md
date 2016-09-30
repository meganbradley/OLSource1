---
title: "shared_ptr::get"
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
  - "tr1.shared_ptr.get"
  - "shared_ptr.get"
  - "get"
  - "std.tr1.shared_ptr.get"
  - "tr1::shared_ptr::get"
  - "memory/std::tr1::shared_ptr::get"
  - "std::tr1::shared_ptr::get"
  - "shared_ptr::get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get method [TR1]"
  - "get method"
ms.assetid: 03a35a5e-9276-4893-ae41-d92ff3193ed9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::get
Gets address of owned resource.  
  
## Syntax  
  
```  
Ty *get() const;  
```  
  
## Remarks  
 The member function returns the address of the owned resource. If the object does not own a resource it returns 0.  
  
## Example  
  
```  
// std_tr1__memory__shared_ptr_get.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0;   
    std::shared_ptr<int> sp1(new int(5));   
  
    std::cout << "sp0.get() == 0 == " << std::boolalpha   
        << (sp0.get() == 0) << std::endl;   
    std::cout << "*sp1.get() == " << *sp1.get() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **sp0.get() == 0 == true**  
**\*sp1.get() == 5**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::operator*](../vs140/shared_ptr--operator-.md)   
 [shared_ptr::operator->](../vs140/shared_ptr--operator--.md)
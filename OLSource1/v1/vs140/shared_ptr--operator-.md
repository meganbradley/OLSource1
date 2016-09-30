---
title: "shared_ptr::operator*"
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
  - "shared_ptr::operator*"
  - "tr1::shared_ptr::operator*"
  - "std.tr1.shared_ptr.operator*"
  - "operator*"
  - "shared_ptr.operator*"
  - "tr1.shared_ptr.operator*"
  - "std::tr1::shared_ptr::operator*"
  - "memory/std::tr1::shared_ptr::operator*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator*"
  - "operator* operator [TR1]"
ms.assetid: 4fa7630c-b036-4a46-bd0f-d661b90cd97e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::operator*
Gets the designated value.  
  
## Syntax  
  
```  
Ty& operator*() const;  
```  
  
## Remarks  
 The indirection operator returns `*get()`. Hence, the stored pointer must not be null.  
  
## Example  
  
```  
// std_tr1__memory__shared_ptr_operator_st.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0(new int(5));   
  
    std::cout << "*sp0 == " << *sp0 << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **\*sp0 == 5**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::get](../vs140/shared_ptr--get.md)
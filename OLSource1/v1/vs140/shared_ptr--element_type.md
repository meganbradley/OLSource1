---
title: "shared_ptr::element_type"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::tr1::shared_ptr::element_type"
  - "std.tr1.shared_ptr.element_type"
  - "shared_ptr.element_type"
  - "shared_ptr::element_type"
  - "memory/std::tr1::shared_ptr::element_type"
  - "element_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "element_type typedef [TR1]"
ms.assetid: 23f3d4f1-d404-4e0e-9271-bd2c978f70ef
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::element_type
The type of an element.  
  
## Syntax  
  
```  
typedef Ty element_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Ty`.  
  
## Example  
  
```  
// std_tr1__memory__shared_ptr_element_type.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0(new int(5));   
    std::shared_ptr<int>::element_type val = *sp0;   
  
    std::cout << "*sp0 == " << val << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **\*sp0 == 5**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)
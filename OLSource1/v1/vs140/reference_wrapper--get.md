---
title: "reference_wrapper::get"
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
  - "std.tr1.reference_wrapper.get"
  - "std::tr1::reference_wrapper::get"
  - "get"
  - "reference_wrapper.get"
  - "xrefwrap/std::tr1::reference_wrapper::get"
  - "reference_wrapper::get"
  - "tr1::reference_wrapper::get"
  - "tr1.reference_wrapper.get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get method [TR1]"
  - "get method"
ms.assetid: 23bfe523-8200-4f1e-ba6b-f45632264350
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reference_wrapper::get
Obtains the wrapped reference.  
  
## Syntax  
  
```  
Ty& get() const;  
```  
  
## Remarks  
 The member function returns `INVOKE(get(), t1, t2, ..., tN)`.  
  
## Example  
  
```  
// std_tr1__functional__reference_wrapper_get.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
int main()   
    {   
    int i = 1;   
    std::reference_wrapper<int> rwi(i);   
  
    std::cout << "i = " << i << std::endl;   
    std::cout << "rwi = " << rwi << std::endl;   
    rwi.get() = -1;   
    std::cout << "i = " << i << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **i = 1**  
**rwi = 1**  
**i = -1**   
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [reference_wrapper](../vs140/reference_wrapper-class.md)   
 [reference_wrapper::operator()](../vs140/reference_wrapper--operator--.md)
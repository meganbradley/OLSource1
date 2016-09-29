---
title: "reference_wrapper::reference_wrapper"
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
  - "reference_wrapper"
  - "tr1.reference_wrapper.reference_wrapper"
  - "xrefwrap/std::tr1::reference_wrapper::reference_wrapper"
  - "reference_wrapper::reference_wrapper"
  - "std::tr1::reference_wrapper::reference_wrapper"
  - "tr1::reference_wrapper::reference_wrapper"
  - "reference_wrapper.reference_wrapper"
  - "std.tr1.reference_wrapper.reference_wrapper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference_wrapper constructor [TR1]"
  - "reference_wrapper method"
ms.assetid: 47c36ef1-4502-4819-b312-82b987f214d3
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reference_wrapper::reference_wrapper
Constructs a `reference_wrapper`.  
  
## Syntax  
  
```  
explicit reference_wrapper(Ty& val);  
```  
  
#### Parameters  
 `Ty`  
 The type to wrap.  
  
 `val`  
 The value to wrap.  
  
## Remarks  
 The constructor sets the stored value `ptr` to `&val`.  
  
## Example  
  
```  
// std_tr1__functional__reference_wrapper_reference_wrapper.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
int neg(int val)   
    {   
    return (-val);   
    }   
  
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
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [reference_wrapper](../vs140/reference_wrapper-class.md)
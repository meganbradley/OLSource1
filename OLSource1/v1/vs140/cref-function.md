---
title: "cref Function"
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
  - "std::tr1::cref"
  - "cref"
  - "std.tr1.cref"
  - "functional/std::tr1::cref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cref function [TR1]"
ms.assetid: c3681448-0150-46eb-b21b-99140476637c
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cref Function
Constructs a const `reference_wrapper` from an argument.  
  
## Syntax  
  
```  
template<class Ty>  
    reference_wrapper<const Ty> cref(const Ty& arg);  
template<class Ty>  
    reference_wrapper<const Ty> cref(const reference_wrapper<Ty>& arg);  
```  
  
#### Parameters  
 `Ty`  
 The type of the argument to wrap.  
  
 `arg`  
 The argument to wrap.  
  
## Remarks  
 The first function returns `reference_wrapper<const Ty>(arg.get())`. You use it to wrap a const reference. The second function returns `reference_wrapper<const Ty>(arg)`. You use it to rewrap a wrapped reference as a const reference.  
  
## Example  
  
```  
// std_tr1__functional__cref.cpp   
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
  
    std::cout << "i = " << i << std::endl;   
    std::cout << "cref(i) = " << std::cref(i) << std::endl;   
    std::cout << "cref(neg)(i) = "   
        << std::cref(&neg)(i) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **i = 1**  
**cref(i) = 1**  
**cref(neg)(i) = -1**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [ref](../vs140/ref-function.md)   
 [reference_wrapper](../vs140/reference_wrapper-class.md)
---
title: "reference_wrapper::operator()"
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
  - "functional/std::tr1::reference_wrapper::operator()"
  - "reference_wrapper.operator()"
  - "std.tr1.reference_wrapper.operator()"
  - "std::tr1::reference_wrapper::operator()"
  - "reference_wrapper::operator()"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator() operator [TR1]"
ms.assetid: e4b274cd-fece-4b19-8669-fe70111eff3c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reference_wrapper::operator()
Calls the wrapped reference.  
  
## Syntax  
  
```  
template<class T1, class T2, ..., class TN>  
    typename result_of<T(T1, T2, ..., TN)>::type  
    operator()(T1& t1, T2& t2, ..., TN& tN);  
```  
  
#### Parameters  
 `TN`  
 The type of the Nth call argument.  
  
 `tN`  
 The Nth call argument.  
  
## Remarks  
 The template member operator returns `INVOKE(get(), t1, t2, ..., tN)`.  
  
## Example  
  
```  
// std_tr1__functional__reference_wrapper_operator_call.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
int neg(int val)   
    {   
    return (-val);   
    }   
  
int main()   
    {   
    std::reference_wrapper<int (int)> rwi(neg);   
  
    std::cout << "rwi(3) = " << rwi(3) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **rwi(3) = -3**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [reference_wrapper](../vs140/reference_wrapper-class.md)   
 [reference_wrapper::get](../vs140/reference_wrapper--get.md)
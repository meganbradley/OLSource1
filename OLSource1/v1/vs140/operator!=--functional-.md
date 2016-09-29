---
title: "operator!= &lt;functional&gt;"
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
  - "std.tr1.operator!="
  - "std::tr1::operator!="
  - "operator!="
  - "functional/std::tr1::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= operator [TR1]"
ms.assetid: 00b16342-6462-4d98-98ff-3f870486ad27
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= &lt;functional&gt;
Tests if callable object is not empty.  
  
## Syntax  
  
```  
template<class Fty>  
    bool operator!=(const function<Fty>& f, null_ptr_type npc);  
template<class Fty>  
    bool operator!=(null_ptr_type npc, const function<Fty>& f);  
```  
  
#### Parameters  
 `Fty`  
 The function type to wrap.  
  
 `f`  
 The function object  
  
 `npc`  
 A null pointer.  
  
## Remarks  
 The operators both take an argument that is a reference to a `function` object and an argument that is a null pointer constant. Both return true only if the `function` object is not empty.  
  
## Example  
  
```  
// std_tr1__functional__operator_ne.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
int neg(int val)   
    {   
    return (-val);   
    }   
  
int main()   
    {   
    std::function<int (int)> fn0;   
    std::cout << std::boolalpha << "not empty == "   
        << (fn0 != 0) << std::endl;   
  
    std::function<int (int)> fn1(neg);   
    std::cout << std::boolalpha << "not empty == "   
        << (fn1 != 0) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **not empty == false**  
**not empty == true**   
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [operator_eq](../vs140/operator==--functional-.md)
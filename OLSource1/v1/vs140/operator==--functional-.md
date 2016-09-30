---
title: "operator== &lt;functional&gt;"
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
  - "functional/std::tr1::operator=="
  - "function.operator=="
  - "function::operator=="
  - "std.tr1.function.operator=="
  - "std::tr1::function::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== operator [TR1]"
ms.assetid: e5ead216-38c2-46f0-a71d-d6a59906fee8
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== &lt;functional&gt;
Tests if callable object is empty.  
  
## Syntax  
  
```  
template<class Fty>  
    bool operator==(const function<Fty>& f, null_ptr_type npc);  
template<class Fty>  
    bool operator==(null_ptr_type npc, const function<Fty>& f);  
```  
  
#### Parameters  
 `Fty`  
 The function type to wrap.  
  
 `f`  
 The function object  
  
 `npc`  
 A null pointer.  
  
## Remarks  
 The operators both take an argument that is a reference to a `function` object and an argument that is a null pointer constant. Both return true only if the `function` object is empty.  
  
## Example  
  
```  
// std_tr1__functional__operator_eq.cpp   
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
    std::cout << std::boolalpha << "empty == "   
        << (fn0 == 0) << std::endl;   
  
    std::function<int (int)> fn1(neg);   
    std::cout << std::boolalpha << "empty == "   
        << (fn1 == 0) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **empty == true**  
**empty == false**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [operator_ne](../vs140/operator!=--functional-.md)
---
title: "function::operator()"
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
  - "function::operator()"
  - "std::tr1::function::operator()"
  - "std.tr1.function.operator()"
  - "function.operator()"
  - "functional/std::tr1::function::operator()"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator() operator [TR1]"
ms.assetid: 0ba41345-237b-4d25-99e3-a65bdeac6ccc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::operator()
Calls a callable object.  
  
## Syntax  
  
```  
result_type operator()(T1 t1, T2 t2, ..., TN tN);  
```  
  
#### Parameters  
 `TN`  
 The type of the Nth call argument.  
  
 `tN`  
 The Nth call argument.  
  
## Remarks  
 The member function returns `INVOKE(fn, t1, t2, ..., tN, Ret)`, where `fn` is the target object stored in `*this`. You use it to call the wrapped callable object.  
  
## Example  
  
```  
// std_tr1__functional__function_operator_call.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
int neg(int val)   
    {   
    return (-val);   
    }   
  
int main()   
    {   
    std::function<int (int)> fn1(neg);   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << "val == " << fn1(3) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **empty == false**  
**val == -3**   
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::target](../vs140/function--target.md)
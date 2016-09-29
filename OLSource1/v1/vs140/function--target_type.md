---
title: "function::target_type"
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
  - "std::tr1::function::target_type"
  - "function::target_type"
  - "target_type"
  - "function.target_type"
  - "std.tr1.function.target_type"
  - "functional/std::tr1::function::target_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "target_type method [TR1]"
ms.assetid: d92f8afa-bcbf-49aa-8225-517b8f9b883b
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::target_type
Gets type information on the callable object.  
  
## Syntax  
  
```  
const std::type_info& target_type() const;  
```  
  
## Remarks  
 The member function returns `typeid(void)` if `*this` is empty, otherwise it returns `typeid(T)`, where `T` is the type of the target object.  
  
## Example  
  
```  
// std_tr1__functional__function_target_type.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
int neg(int val)   
    {   
    return (-val);   
    }   
  
int main()   
    {   
    std::function<int (int)> fn0(neg);   
    std::cout << std::boolalpha << "empty == " << !fn0 << std::endl;   
    std::cout << "type == " << fn0.target_type().name() << std::endl;   
  
    std::function<int (int)> fn1;   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << "type == " << fn1.target_type().name() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **empty == false**  
**type == int (__cdecl\*)(int)**  
**empty == true**  
**type == void**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::target](../vs140/function--target.md)
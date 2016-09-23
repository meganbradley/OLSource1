---
title: "function::result_type"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.tr1.function.result_type
  - function.result_type
  - result_type
  - functional/std::tr1::function::result_type
  - std::tr1::function::result_type
  - function::result_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - result_type typedef [TR1]
ms.assetid: 310e11a9-a6ae-44fe-bc70-768e12ca0849
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# function::result_type
The return type of the stored callable object.  
  
## Syntax  
  
```  
typedef Ret result_type;  
```  
  
## Remarks  
 The typedef is a synonym for the type `Ret` in the template's call signature. You use it to determine the return type of the wrapped callable object.  
  
## Example  
  
```  
// std_tr1__functional__function_result_type.cpp   
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
  
    std::function<int (int)>::result_type val = fn1(3);   
    std::cout << "val == " << val << std::endl;   
  
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
 [function::target_type](../vs140/function--target_type.md)
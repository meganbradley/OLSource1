---
title: "swap Function &lt;functional&gt;"
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
  - "std.tr1.swap"
  - "functional/std::tr1::swap"
  - "std::tr1::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function [TR1]"
ms.assetid: aa23df6d-d529-41fe-82c9-bf3357428810
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# swap Function &lt;functional&gt;
Swaps two `function` objects.  
  
## Syntax  
  
```  
template<class Fty>  
void swap(function<Fty>& f1,  
    function<Fty>& f2);  
```  
  
#### Parameters  
 `Fty`  
 The type controlled by the function objects.  
  
 `f1`  
 The first function object.  
  
 `f2`  
 The second function object.  
  
## Remarks  
 The function returns `f1.swap(f2)`.  
  
## Example  
  
```  
// std_tr1__functional__swap.cpp   
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
    std::cout << "val == " << fn0(3) << std::endl;   
  
    std::function<int (int)> fn1;   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << std::endl;   
  
    swap(fn0, fn1);   
    std::cout << std::boolalpha << "empty == " << !fn0 << std::endl;   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << "val == " << fn1(3) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **empty == false**  
**val == -3**  
**empty == true**  
**empty == true**  
**empty == false**  
**val == -3**   
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)
---
title: "swap Function &lt;array&gt;"
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
  - std.tr1.swap
  - std::tr1::swap
  - swap
dev_langs: 
  - C++
helpviewer_keywords: 
  - swap function [TR1]
ms.assetid: 906a09ff-706c-41c9-ae43-3bebc2bafd19
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# swap Function &lt;array&gt;
Swaps two arrays.  
  
## Syntax  
  
```  
template<class Ty, std::size_t N>  
    void swap(  
        array<Ty, N>& left,  
        array<Ty, N>& right);  
```  
  
#### Parameters  
 `Ty`  
 The type of an element.  
  
 `N`  
 The size of the array.  
  
 `left`  
 The first array to swap.  
  
 `right`  
 The second array to swap.  
  
## Remarks  
 The template function executes `left`.`swap(``right``)`.  
  
## Example  
  
```  
// std_tr1__array__swap.cpp   
// compile with: /EHsc   
#include <array>   
#include <iostream>   
  
typedef std::array<int, 4> Myarray;   
int main()   
    {   
    Myarray c0 = {0, 1, 2, 3};   
  
// display contents " 0 1 2 3"   
    for (Myarray::const_iterator it = c0.begin();   
        it != c0.end(); ++it)   
        std::cout << " " << *it;   
    std::cout << std::endl;   
  
    Myarray c1 = {4, 5, 6, 7};   
    c0.swap(c1);   
  
// display swapped contents " 4 5 6 7"   
    for (Myarray::const_iterator it = c0.begin();   
        it != c0.end(); ++it)   
        std::cout << " " << *it;   
    std::cout << std::endl;   
  
    swap(c0, c1);   
  
// display swapped contents " 0 1 2 3"   
    for (Myarray::const_iterator it = c0.begin();   
        it != c0.end(); ++it)   
        std::cout << " " << *it;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **4 5 6 7**  
 **0 1 2 3**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [swap](../vs140/array--swap.md)   
 [<array\>](../vs140/-array-.md)   
 [array::swap](../vs140/array--swap.md)
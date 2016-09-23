---
title: "operator&lt; &lt;array&gt;"
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
  - array::operator<
  - array.operator<
  - std::tr1::array::operator<
  - array/std::tr1::operator<
  - std.tr1.array.operator<
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator< operator [TR1]
ms.assetid: 679cea2b-4951-4eca-8bf1-342047aee0bb
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&lt; &lt;array&gt;
Array comparison, less than.  
  
## Syntax  
  
```  
template<Ty, std::size_t N>  
    bool operator<(  
        const array<Ty, N>& left,  
        const array<Ty, N>& right);  
```  
  
#### Parameters  
 `Ty`  
 The type of an element.  
  
 `N`  
 The size of the array.  
  
 `left`  
 Left container to compare.  
  
 `right`  
 Right container to compare.  
  
## Remarks  
 The template function overloads `operator<` to compare two objects of template class [array](../vs140/array-class--stl-.md). The function returns `lexicographical_compare(``left``.begin(),` `left``.end(),` `right``.begin())`.  
  
## Example  
  
```  
// std_tr1__array__operator_lt.cpp   
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
  
// display contents " 4 5 6 7"   
    for (Myarray::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " " << *it;   
    std::cout << std::endl;   
  
// display results of comparisons   
    std::cout << std::boolalpha << " " << (c0 < c0);   
    std::cout << std::endl;   
    std::cout << std::boolalpha << " " << (c0 < c1);   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **4 5 6 7**  
 **false**  
 **true**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [begin](../vs140/array--begin.md)   
 [end](../vs140/array--end.md)   
 [operator==](../vs140/operator==--array-.md)   
 [operator!=](../vs140/operator!=--array-.md)   
 [operator>=](../vs140/operator-=--array-.md)   
 [operator>](../vs140/operator---array-.md)   
 [operator<=](../vs140/operator-=--array-.md)
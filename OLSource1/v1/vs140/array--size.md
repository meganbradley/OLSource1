---
title: "array::size"
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
  - "std.tr1.array.size"
  - "array/std::tr1::array::size"
  - "tr1.array.size"
  - "tr1::array::size"
  - "array::size"
  - "array.size"
  - "std::tr1::array::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method [TR1]"
  - "size method"
ms.assetid: a3ab32f5-67d4-4d14-89cf-54af5ab038aa
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::size
Counts the number of elements.  
  
## Syntax  
  
```  
constexpr size_type size() const;  
```  
  
## Remarks  
 The member function returns `N`.  
  
## Example  
  
```  
// std_tr1__array__array_size.cpp   
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
  
// display size " 4"   
    std::cout << " " << c0.size();   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **4**   
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [max_size](../vs140/array--max_size.md)
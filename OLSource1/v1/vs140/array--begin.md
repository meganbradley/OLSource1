---
title: "array::begin"
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
  - "array.begin"
  - "array::begin"
  - "tr1::array::begin"
  - "tr1.array.begin"
  - "array/std::tr1::array::begin"
  - "std.tr1.array.begin"
  - "std::tr1::array::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method"
  - "begin method [TR1]"
ms.assetid: 0397d500-32b5-4e07-9c54-2ed21013565e
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# array::begin
Designates the beginning of the controlled sequence.  
  
## Syntax  
  
```  
iterator begin() noexcept;  
const_iterator begin() const noexcept;  
```  
  
## Remarks  
 The member functions return a random-access iterator that points at the first element of the sequence (or just beyond the end of an empty sequence).  
  
## Example  
  
```  
// std_tr1__array__array_begin.cpp   
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
  
// display first element " 0"   
    Myarray::iterator it2 = c0.begin();   
    std::cout << " " << *it2;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [end](../vs140/array--end.md)   
 [front](../vs140/array--front.md)
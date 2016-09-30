---
title: "array::rend"
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
  - "std.tr1.array.rend"
  - "array::rend"
  - "array/std::tr1::array::rend"
  - "array.rend"
  - "tr1::array::rend"
  - "tr1.array.rend"
  - "std::tr1::array::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
  - "rend method [TR1]"
ms.assetid: 653e3a21-ce63-490d-9e6a-6ed377fd80cf
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::rend
Designates the end of the reversed controlled sequence.  
  
## Syntax  
  
```  
reverse_iterator rend()noexcept;  
const_reverse_iterator rend() const  noexcept;  
```  
  
## Remarks  
 The member functions return a reverse iterator that points at the first element of the sequence (or just beyond the end of an empty sequence)). Hence, it designates the end of the reverse sequence.  
  
## Example  
  
```  
// std_tr1__array__array_rend.cpp   
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
    Myarray::const_reverse_iterator it2 = c0.rend();   
    std::cout << " " << *--it2;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0**   
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [begin](../vs140/array--begin.md)   
 [end](../vs140/array--end.md)   
 [rbegin](../vs140/array--rbegin.md)
---
title: "array::size_type"
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
  - "std.tr1.array.size_type"
  - "array/std::tr1::array::size_type"
  - "array.size_type"
  - "std::tr1::array::size_type"
  - "tr1.array.size_type"
  - "tr1::array::size_type"
  - "array::size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef"
  - "size_type typedef [TR1]"
ms.assetid: 2867bc74-58d8-4c29-88da-c0f1fabebd6a
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::size_type
The type of an unsigned distance between two element.  
  
## Syntax  
  
```  
typedef std::size_t size_type;  
```  
  
## Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is a synonym for the type `std::size_t`.  
  
## Example  
  
```  
// std__array__array_size_type.cpp   
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
  
// display distance last-first " 4"   
    Myarray::size_type diff = c0.end() - c0.begin();   
    std::cout << " " << diff;   
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
 [empty](../vs140/array--empty.md)
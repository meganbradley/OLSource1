---
title: "array::const_reverse_iterator"
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
  - "std.tr1.array.const_reverse_iterator"
  - "tr1::array::const_reverse_iterator"
  - "array::const_reverse_iterator"
  - "array/std::tr1::array::const_reverse_iterator"
  - "tr1.array.const_reverse_iterator"
  - "std::tr1::array::const_reverse_iterator"
  - "array.const_reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reverse_iterator typedef [TR1]"
  - "const_reverse_iterator typedef"
ms.assetid: ca8c5af4-4f55-45d2-ae47-2d0fe453e015
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::const_reverse_iterator
The type of a constant reverse iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef std::reverse_iterator<const_iterator> const_reverse_iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant reverse iterator for the controlled sequence.  
  
## Example  
  
```  
// std_tr1__array__array_const_reverse_iterator.cpp   
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
  
// display last element " 3"   
    Myarray::const_reverse_iterator it2 = c0.rbegin();   
    std::cout << " " << *it2;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **3**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [reverse_iterator](../vs140/array--reverse_iterator.md)
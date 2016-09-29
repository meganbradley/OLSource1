---
title: "array::const_iterator"
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
  - "array.const_iterator"
  - "array::const_iterator"
  - "tr1::array::const_iterator"
  - "tr1.array.const_iterator"
  - "std.tr1.array.const_iterator"
  - "array/std::tr1::array::const_iterator"
  - "std::tr1::array::const_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_iterator typedef [TR1]"
  - "const_iterator typedef"
ms.assetid: 1467b394-d446-4550-98c2-e874c1d51a4e
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::const_iterator
The type of a constant iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef implementation-defined const_iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant random-access iterator for the controlled sequence.  
  
## Example  
  
```cpp  
  
// std__array__array_const_iterator.cpp  
// compile with: /EHsc /W4  
#include <array>   
#include <iostream>   
  
typedef std::array<int, 4> MyArray;   
  
int main()   
{   
    MyArray c0 = {0, 1, 2, 3};   
  
    // display contents " 0 1 2 3"   
    std::cout << "it1:";  
    for ( MyArray::const_iterator it1 = c0.begin();   
          it1 != c0.end();   
          ++it1 ) {  
       std::cout << " " << *it1;   
    }  
    std::cout << std::endl;   
  
    // display first element " 0"   
    MyArray::const_iterator it2 = c0.begin();   
    std::cout << "it2:";  
    std::cout << " " << *it2;   
    std::cout << std::endl;   
  
    return (0);   
}  
  
```  
  
 **it1: 0 1 2 3**   
 **it2: 0**    
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [iterator](../vs140/array--iterator.md)
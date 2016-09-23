---
title: "array::iterator"
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
  - array::iterator
  - std::tr1::array::iterator
  - tr1.array.iterator
  - tr1::array::iterator
  - std.tr1.array.iterator
  - array/std::tr1::array::iterator
  - array.iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - iterator typedef [TR1]
  - iterator typedef
ms.assetid: 92b1a8cf-48ad-42c6-83e8-bb084e8830ef
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::iterator
The type of an iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef implementation-defined iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a random-access iterator for the controlled sequence.  
  
## Example  
  
```cpp  
  
// std__array__array_iterator.cpp   
// compile with: /EHsc /W4  
#include <array>   
#include <iostream>   
  
typedef std::array<int, 4> MyArray;   
  
int main()   
{   
    MyArray c0 = {0, 1, 2, 3};   
  
    // display contents " 0 1 2 3"   
    std::cout << "it1:";  
    for ( MyArray::iterator it1 = c0.begin();   
          it1 != c0.end();   
          ++it1 ) {  
       std::cout << " " << *it1;   
    }  
    std::cout << std::endl;   
  
    // display first element " 0"   
    MyArray::iterator it2 = c0.begin();   
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
 [const_iterator](../vs140/array--const_iterator.md)
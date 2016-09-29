---
title: "array::reference"
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
  - "array.reference"
  - "array::reference"
  - "tr1.array.reference"
  - "std.tr1.array.reference"
  - "tr1::array::reference"
  - "array/std::tr1::array::reference"
  - "std::tr1::array::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference typedef"
  - "reference typedef [TR1]"
ms.assetid: baa4a6d8-8b4c-433c-8f4e-2cd67bd6b47f
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::reference
The type of a reference to an element.  
  
## Syntax  
  
```  
typedef Ty& reference;  
```  
  
## Remarks  
 The type describes an object that can serve as a reference to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__array__array_reference.cpp   
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
    Myarray::reference ref = *c0.begin();   
    std::cout << " " << ref;   
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
 [const_reference](../vs140/array--const_reference.md)   
 [value_type](../vs140/array--value_type.md)
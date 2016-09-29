---
title: "array::array"
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
  - "std.tr1.array.array"
  - "array/std::tr1::array::array"
  - "array::array"
  - "array.array"
  - "std::tr1::array::array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array constructor [TR1]"
ms.assetid: b3907d5a-6053-483c-9e34-c55c647e68a9
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::array
Constructs an array object.  
  
## Syntax  
  
```  
array();  
array(const array& right);  
```  
  
#### Parameters  
 `right`  
 Object or range to insert.  
  
## Remarks  
 The constructor:  
  
```  
array();  
```  
  
 leaves the controlled sequence uninitialized (or default initialized). You use it to specify an uninitialized controlled sequence.  
  
 The constructor:  
  
```  
array(const array& right);  
```  
  
 initializes the controlled sequence with the sequence `[``right``.`[begin](../vs140/array--begin.md)`(),` `right``.`[end](../vs140/array--end.md)`())`. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the array object `right`.  
  
## Example  
  
```  
// std_tr1__array__array_array.cpp   
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
  
    Myarray c1(c0);   
  
// display contents " 0 1 2 3"   
    for (Myarray::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " " << *it;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0 1 2 3**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [assign](../vs140/array--assign.md)   
 [operator=](../vs140/array--operator=.md)
---
title: "unordered_set::size_type"
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
  - "unordered_set/std::tr1::unordered_set::size_type"
  - "unordered_set::size_type"
  - "tr1.unordered_set.size_type"
  - "std::tr1::unordered_set::size_type"
  - "std.tr1.unordered_set.size_type"
  - "size_type"
  - "unordered_set.size_type"
  - "tr1::unordered_set::size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef"
  - "size_type typedef [TR1]"
ms.assetid: e8ef57b2-0567-4275-b02b-9d6e91a9dfdb
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::size_type
The type of an unsigned distance between two elements.  
  
## Syntax  
  
```  
typedef T2 size_type;  
```  
  
## Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is described here as a synonym for the implementation-defined type `T2`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_size_type.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_set<char> Myset;   
int main()   
    {   
    Myset c1;   
    Myset::size_type sz = c1.size();   
  
    std::cout << "size == " << sz << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **size == 0**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::difference_type](../vs140/unordered_set--difference_type.md)
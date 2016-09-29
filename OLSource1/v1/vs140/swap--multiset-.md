---
title: "swap (multiset)"
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
  - "std.swap"
  - "std::swap"
  - "set/std::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: 5726abb2-3ee9-414c-aa21-0bb340124d07
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (multiset)
Exchanges the elements of two multisets.  
  
## Syntax  
  
```  
  
      template<class Key, class Traits, class Allocator>  
void swap(  
   multiset< Key, Traits, Allocator>& _Left,  
   multiset< Key, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The multiset providing the elements to be swapped, or the multiset whose elements are to be exchanged with those of the multiset `_Left`.  
  
 `_Left`  
 The multiset whose elements are to be exchanged with those of the multiset `_Right`.  
  
## Remarks  
 The template function is an algorithm specialized on the container class multiset to execute the member function `_Left``.`[swap](../vs140/multiset--swap.md)(`_Right`). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function  
  
 `template` <**class T**> **void swap**(**T&**, **T&**)  
  
 in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
## Example  
 See the code example for the member class [multiset::swap](../vs140/multiset--swap.md)for an example of the use of the template version of `swap`.  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)
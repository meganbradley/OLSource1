---
title: "swap (multimap)"
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
  - "map/std::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: 6ca73e89-c108-4646-8321-e43db5b462e0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (multimap)
Exchanges the elements of two multimaps.  
  
## Syntax  
  
```  
template<class _Key, class _Ty, class _Pr, class _Alloc>  
void swap(  
   multimap<Key, Traits, Compare, Alloctor >& _Left,  
   multimap<Key, Traits, Compare, Alloctor >& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The multimap providing the elements to be swapped, or the multimap whose elements are to be exchanged with those of the multimap `_Left`.  
  
 `_Left`  
 The multimap whose elements are to be exchanged with those of the multimap `_Right`.  
  
## Remarks  
 The template function is an algorithm specialized on the container class map to execute on the container class multimap to execute the member function `_Left.`[swap](../vs140/multimap--swap.md) (`_Right`). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function, **template** <**class T**> **void swap**(**T&**, **T&**), in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
## Example  
 See the code example for member function [multimap::swap](../vs140/multimap--swap.md) for an example that uses the template version of `swap`.  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)
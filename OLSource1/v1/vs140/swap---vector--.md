---
title: "swap (&lt;vector&gt;)"
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
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: f699795f-ef0a-48f7-bd55-ffd23f682e74
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (&lt;vector&gt;)
Exchanges the elements of two vectors.  
  
## Syntax  
  
```  
  
      template<class Type, class Allocator>  
void swap(  
   vector<Type, Allocator>& _Left,  
   vector<Type, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The vector providing the elements to be swapped, or the vector whose elements are to be exchanged with those of the vector `_Left`.  
  
 `_Left`  
 The vector whose elements are to be exchanged with those of the vector `_Right`.  
  
## Remarks  
 The template function is an algorithm specialized on the container class vector to execute the member function `_Left.`[vector::swap](../vs140/vector--swap.md)*(_Right*). These are instances of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function, **template** \<**class T**> **void swap**(**T&**, **T&**), in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
## Example  
 See the code example for member function [vector::swap](../vs140/vector--swap.md) for an example that uses the template version of `swap`.  
  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)
---
title: "swap (set)"
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
ms.assetid: 307732be-3309-43f6-8cca-8a3be7cc45db
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (set)
Exchanges the elements of two sets.  
  
## Syntax  
  
```  
  
      template<class Key, class Traits, class Allocator>  
void swap(  
   set< Key, Traits, Allocator>& _Left,  
   set< Key, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The set providing the elements to be swapped, or the set whose elements are to be exchanged with those of the set `_Left`.  
  
 `_Left`  
 The set whose elements are to be exchanged with those of the set `_Right`.  
  
## Remarks  
 The template function is an algorithm specialized on the container class set to execute the member function `_Left``.`[swap](../vs140/set--swap.md)(`_Right`). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function  
  
 `template` <**class T**> **void swap**(**T&**, **T&**)  
  
 in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
## Example  
 See the code example for the member class [set::swap](../vs140/set--swap.md) for an example of the use of the template version of `swap`.  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)
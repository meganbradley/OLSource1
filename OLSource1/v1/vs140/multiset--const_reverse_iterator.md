---
title: "multiset::const_reverse_iterator"
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
  - multiset.const_reverse_iterator
  - std.multiset.const_reverse_iterator
  - const_reverse_iterator
  - std::multiset::const_reverse_iterator
  - set/std::multiset::const_reverse_iterator
  - multiset::const_reverse_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_reverse_iterator method
  - const_reverse_iterator typedef
ms.assetid: 39a2469e-569b-49b2-9cff-0cffd52840b4
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::const_reverse_iterator
A type that provides a bidirectional iterator that can read any **const** element in the multiset.  
  
## Syntax  
  
```  
typedef std::reverse_iterator<const_iterator> const_reverse_iterator;  
```  
  
## Remarks  
 A type `const_reverse_iterator` cannot modify the value of an element and is use to iterate through the multiset in reverse.  
  
## Example  
 See the example for [rend](../vs140/multiset--rend.md) for an example of how to declare and use the `const_reverse_iterator`.  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
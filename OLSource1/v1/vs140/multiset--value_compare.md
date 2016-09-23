---
title: "multiset::value_compare"
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
  - std::multiset::value_compare
  - value_compare
  - std.multiset.value_compare
  - multiset.value_compare
  - multiset::value_compare
  - set/std::multiset::value_compare
dev_langs: 
  - C++
helpviewer_keywords: 
  - value_compare method
  - value_compare typedef
ms.assetid: 6cbf7dab-7328-4191-99eb-8947e96be561
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::value_compare
The type that provides a function object that can compare two sort keys to determine their relative order in the multiset.  
  
## Syntax  
  
```  
typedef key_compare value_compare;  
```  
  
## Remarks  
 `value_compare` is a synonym for the template parameter `Compare`.  
  
 Note that both [key_compare](../vs140/multiset--key_compare.md) and **value_compare** are synonyms for the template parameter `Compare`. Both types are provided for the classes set and multiset, where they are identical, for compatibility with the classes map and multimap, where they are distinct.  
  
 For more information on `Compare`, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
## Example  
 See the example for [value_comp](../vs140/multiset--value_comp.md) for an example of how to declare and use `value_compare`.  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
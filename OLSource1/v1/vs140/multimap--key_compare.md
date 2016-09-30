---
title: "multimap::key_compare"
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
  - "key_compare"
  - "multimap::key_compare"
  - "multimap.key_compare"
  - "map/std::multimap::key_compare"
  - "std::multimap::key_compare"
  - "std.multimap.key_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_compare method"
  - "key_compare typedef"
ms.assetid: 91a516f6-24f3-442d-8264-fcb2638682ee
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::key_compare
A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the multimap.  
  
## Syntax  
  
```  
typedef Traits key_compare;  
```  
  
## Remarks  
 **key_compare** is a synonym for the template parameter `Traits`.  
  
 For more information on `Traits` see the [multimap Class](../vs140/multimap-class.md) topic.  
  
## Example  
 See the example for [key_comp](../vs140/multimap--key_comp.md) for an example of how to declare and use `key_compare`.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
---
title: "multimap::const_iterator"
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
  - "std.multimap.const_iterator"
  - "const_iterator"
  - "multimap::const_iterator"
  - "std::multimap::const_iterator"
  - "map/std::multimap::const_iterator"
  - "multimap.const_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_iterator method"
  - "const_iterator typedef"
ms.assetid: 44f383c2-fc23-431f-8c95-a3727aa7106f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::const_iterator
A type that provides a bidirectional iterator that can read a **const** element in the multimap.  
  
## Syntax  
  
```  
typedef implementation-defined const_iterator;  
```  
  
## Remarks  
 A type `const_iterator` cannot be used to modify the value of an element.  
  
 The `const_iterator` defined by multimap points to objects of [value_type](../vs140/multimap--value_type.md), which are of type `pair`*<***const Key**, **Type***>*. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 To dereference a `const_iterator` `cIter` pointing to an element in a multimap, use the **->** operator.  
  
 To access the value of the key for the element, use `cIter` -> **first**, which is equivalent to (\*`cIter`).**first**. To access the value of the mapped datum for the element, use `cIter` -> **second**, which is equivalent to (\*`cIter`).**second**.  
  
## Example  
 See the example for [begin](../vs140/multimap--begin.md) for an example using `const_iterator`.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
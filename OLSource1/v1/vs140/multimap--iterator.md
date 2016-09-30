---
title: "multimap::iterator"
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
  - "iterator"
  - "multimap.iterator"
  - "std.multimap.iterator"
  - "multimap::iterator"
  - "std::multimap::iterator"
  - "map/std::multimap::iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator method"
  - "iterator typedef"
ms.assetid: c4bd01b4-b036-4cc5-b501-fa82c926cea5
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::iterator
A type that provides a bidirectional iterator that can read or modify any element in a multimap.  
  
## Syntax  
  
```  
typedef implementation-defined iterator;  
```  
  
## Remarks  
 The **iterator** defined by multimap points to objects of [value_type](../vs140/multimap--value_type.md), which are of type `pair`*<***const Key**, **Type***>*. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 To dereference an **iterator** `Iter` pointing to an element in a multimap, use the **->** operator.  
  
 To access the value of the key for the element, use `Iter` -> **first**, which is equivalent to (\*`Iter`).**first**. To access the value of the mapped datum for the element, use `Iter` -> **second**, which is equivalent to (\*`Iter`).**second**.  
  
 A type **iterator** can be used to modify the value of an element.  
  
## Example  
 See the example for [begin](../vs140/multimap--begin.md) for an example of how to declare and use **iterator**.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
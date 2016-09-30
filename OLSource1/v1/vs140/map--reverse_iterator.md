---
title: "map::reverse_iterator"
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
  - "reverse_iterator"
  - "map.reverse_iterator"
  - "map/std::map::reverse_iterator"
  - "std.map.reverse_iterator"
  - "map::reverse_iterator"
  - "std::map::reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator typedef"
  - "reverse_iterator method"
ms.assetid: 105d1d38-98ac-4341-8b22-b7b4e20c27d4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::reverse_iterator
A type that provides a bidirectional iterator that can read or modify an element in a reversed map.  
  
## Syntax  
  
```  
typedef std::reverse_iterator<iterator> reverse_iterator;  
```  
  
## Remarks  
 A type `reverse_iterator` cannot modify the value of an element and is use to iterate through the map in reverse.  
  
 The `reverse_iterator` defined by map points to elements that are objects of [value_type](../vs140/map--value_type.md), that is of type `pair`*\<***const Key**, **Type***>*, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a `reverse_iterator` `rIter` pointing to an element in a map, use the **->** operator.  
  
 To access the value of the key for the element, use `rIter` -> **first**, which is equivalent to (\*`rIter`).**first**. To access the value of the mapped datum for the element, use `rIter` -> **second**, which is equivalent to (\*`rIter`).**first**.  
  
## Example  
 See example for [rbegin](../vs140/map--rbegin.md) for an example of how to declare and use `reverse_iterator`.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
---
title: "map::const_reverse_iterator"
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
  - "map/std::map::const_reverse_iterator"
  - "std.map.const_reverse_iterator"
  - "map::const_reverse_iterator"
  - "map.const_reverse_iterator"
  - "std::map::const_reverse_iterator"
  - "const_reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reverse_iterator method"
  - "const_reverse_iterator typedef"
ms.assetid: 297c4428-a0d4-4c4f-ae16-1c6f21e08829
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::const_reverse_iterator
A type that provides a bidirectional iterator that can read any **const** element in the map.  
  
## Syntax  
  
```  
typedef std::reverse_iterator<const_iterator> const_reverse_iterator;  
```  
  
## Remarks  
 A type `const_reverse_iterator` cannot modify the value of an element and is use to iterate through the map in reverse.  
  
 The `const_reverse_iterator` defined by map points to elements that are objects of [value_type](../vs140/map--value_type.md), that is of type `pair`*<***const Key***,* **Type***>*, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a `const_reverse_iterator` `crIter` pointing to an element in a map, use the **->** operator.  
  
 To access the value of the key for the element, use `crIter` -> **first**, which is equivalent to (\*`crIter`).**first**.  
  
 To access the value of the mapped datum for the element, use `crIter` -> **second**, which is equivalent to (\*`crIter`).**first**.  
  
## Example  
 See the example for [rend](../vs140/map--rend.md) for an example of how to declare and use `const_reverse_iterator`.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
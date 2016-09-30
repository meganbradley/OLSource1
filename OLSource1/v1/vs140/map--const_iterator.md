---
title: "map::const_iterator"
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
  - "std::map::const_iterator"
  - "const_iterator"
  - "map/std::map::const_iterator"
  - "std.map.const_iterator"
  - "map::const_iterator"
  - "map.const_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_iterator method"
  - "const_iterator typedef"
ms.assetid: f27f8a37-94cd-4e12-9c56-5e64efa2baca
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::const_iterator
A type that provides a bidirectional iterator that can read a **const** element in the map.  
  
## Syntax  
  
```  
typedef implementation-defined const_iterator;  
```  
  
## Remarks  
 A type `const_iterator` cannot be used to modify the value of an element.  
  
 The `const_iterator` defined by map points to elements that are objects of [value_type](../vs140/map--value_type.md), that is of type `pair`\<**const Key**, **Type**>, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a `const_iterator` `cIter` pointing to an element in a map, use the **->** operator.  
  
 To access the value of the key for the element, use `cIter` -> **first**, which is equivalent to (\*`cIter`).**first**.  
  
 To access the value of the mapped datum for the element, use `cIter` -> **second**, which is equivalent to (\*`cIter`). **second**.  
  
## Example  
 See example for [begin](../vs140/map--begin.md) for an example that uses `const_iterator`.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
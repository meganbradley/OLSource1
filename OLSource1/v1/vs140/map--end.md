---
title: "map::end"
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
  - "map/std::map::end"
  - "end"
  - "std.map.end"
  - "map::end"
  - "map.end"
  - "std::map::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: cdb836d4-47c7-4907-b2d3-f7f3672e0504
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# map::end
Returns the past-the-end iterator.  
  
## Syntax  
  
```  
const_iterator end( ) const;  
  
iterator end( );  
```  
  
## Return Value  
 The past-the-end iterator. If the map is empty, then `map::end() == map::begin()`.  
  
## Remarks  
 **end** is used to test whether an iterator has passed the end of its map.  
  
 The value returned by **end** should not be dereferenced.  
  
 For a code example, see [map::find](../vs140/map--find.md).  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
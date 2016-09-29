---
title: "map::const_pointer"
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
  - "map::const_pointer"
  - "const_pointer"
  - "std::map::const_pointer"
  - "map.const_pointer"
  - "std.map.const_pointer"
  - "map/std::map::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer method"
ms.assetid: 3d027783-e299-440c-b30e-9cc644d2f4ab
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::const_pointer
A type that provides a pointer to a **const** element in a map.  
  
## Syntax  
  
```  
typedef typename allocator_type::const_pointer const_pointer;  
```  
  
## Remarks  
 A type `const_pointer` cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](../vs140/map--iterator.md) should be used to access the elements in a map object.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
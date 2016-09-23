---
title: "multimap::const_pointer"
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
  - multimap.const_pointer
  - std::multimap::const_pointer
  - map/std::multimap::const_pointer
  - std.multimap.const_pointer
  - const_pointer
  - multimap::const_pointer
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_pointer typedef
  - const_pointer method
ms.assetid: b4d1eb97-6909-4983-9765-85fefef2ea2a
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multimap::const_pointer
A type that provides a pointer to a **const** element in a multimap.  
  
## Syntax  
  
```  
typedef typename allocator_type::const_pointer const_pointer;  
```  
  
## Remarks  
 A type `const_pointer` cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](../vs140/multimap--iterator.md) should be used to access the elements in a multimap object.  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
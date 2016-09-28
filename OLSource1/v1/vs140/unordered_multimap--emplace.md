---
title: "unordered_multimap::emplace"
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
  - "unordered_multimap.emplace"
  - "unordered_map/std::tr1::unordered_multimap::emplace"
  - "std::tr1::unordered_multimap::emplace"
  - "unordered_multimap::emplace"
  - "std.tr1.unordered_multimap.emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 47e596b6-4ae0-4490-8a21-cb2e58f5f81e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::emplace
Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
## Syntax  
  
```  
template<class... Args>  
   iterator emplace(  
      Args&&... args);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`args`|The arguments forwarded to construct an element to be inserted into the unordered_multimap.|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
## Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 The [value_type](../vs140/map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see [multimap::emplace](../vs140/multimap--emplace.md).  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [<map\>](../vs140/-map-.md)   
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
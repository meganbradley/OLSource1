---
title: "unordered_map::emplace"
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
  - "unordered_map/std::tr1::unordered_map::emplace"
  - "std.tr1.unordered_map.emplace"
  - "std::tr1::unordered_map::emplace"
  - "unordered_map.emplace"
  - "unordered_map::emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 440f42ff-75d7-472b-ad24-471d07c34d54
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::emplace
Inserts an element constructed in place (no copy or move operations are performed) into an unordered_map.  
  
## Syntax  
  
```  
template<class... Args>  
   pair<iterator, bool> emplace(  
      Args&&... args);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`args`|The arguments forwarded to construct an element to be inserted into the unordered_map unless it already contains an element whose value is equivalently ordered.|  
  
## Return Value  
 A `pair` whose `bool` component returns true if an insertion was made and false if the `unordered_map` already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair `pr` returned by this member function, use `pr.first`, and to dereference it, use `*(pr.first)`. To access the `bool` component of a pair `pr` returned by this member function, use `pr.second`.  
  
## Remarks  
 No iterators or references are invalidated by this function.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see [map::emplace](../vs140/map--emplace.md).  
  
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map Class](../vs140/unordered_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
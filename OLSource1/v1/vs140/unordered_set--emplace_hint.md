---
title: "unordered_set::emplace_hint"
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
  - unordered_set::emplace_hint
  - std.tr1.unordered_set.emplace_hint
  - unordered_set/std::tr1::unordered_set::emplace_hint
  - unordered_set.emplace_hint
  - std::tr1::unordered_set::emplace_hint
dev_langs: 
  - C++
helpviewer_keywords: 
  - emplace_hint method
ms.assetid: 07288316-2668-456f-91b4-0d0c2f93f39a
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unordered_set::emplace_hint
Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
## Syntax  
  
```  
template<class... Args>  
   iterator emplace_hint(  
      const_iterator where,  
      Args&&... args);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`args`|The arguments forwarded to construct an element to be inserted into the unordered_set unless the unordered_set already contains that element or, more generally, unless it already contains an element whose key is equivalently ordered.|  
|`where`|A hint regarding the place to start searching for the correct point of insertion.|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element.  
  
## Remarks  
 No iterators or references are invalidated by this function.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see [set::emplace_hint](../vs140/set--emplace_hint.md).  
  
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set Class](../vs140/unordered_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
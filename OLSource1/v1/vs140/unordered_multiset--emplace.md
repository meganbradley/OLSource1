---
title: "unordered_multiset::emplace"
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
  - "std::tr1::unordered_multiset::emplace"
  - "unordered_multiset.emplace"
  - "unordered_multiset::emplace"
  - "std.tr1.unordered_multiset.emplace"
  - "unordered_set/std::tr1::unordered_multiset::emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 9cf72e5e-cc6e-41ff-9bb8-4ddbacd2fb79
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::emplace
Inserts an element constructed in place (no copy or move operations are performed).  
  
## Syntax  
  
```  
template<class... Args>  
    iterator emplace(  
        Args&&... args  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`args`|The arguments forwarded to construct an element to be inserted into the unordered_multiset.|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
## Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see [multiset::emplace](../vs140/multiset--emplace.md).  
  
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset Class](../vs140/unordered_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)
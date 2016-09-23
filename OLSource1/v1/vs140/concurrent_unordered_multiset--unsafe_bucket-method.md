---
title: "concurrent_unordered_multiset::unsafe_bucket Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 55736c54-e7c8-47e3-8947-780bd4425002
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multiset::unsafe_bucket Method
Returns the bucket index that a specific key maps to in this container.  
  
## Syntax  
  
```  
size_type unsafe_bucket(  
   const key_type& _Keyval  
) const;  
```  
  
#### Parameters  
 `_Keyval`  
 The element key being searched for.  
  
## Return Value  
 The bucket index for the key in this container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../vs140/concurrent_unordered_multiset-class.md)
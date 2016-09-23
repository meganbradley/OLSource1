---
title: "concurrent_unordered_multiset::find Method"
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
ms.assetid: 2399063e-5b35-4f14-a06c-7fae652e71e1
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multiset::find Method
Finds an element that matches a specified key. This function is concurrency safe.  
  
## Syntax  
  
```  
iterator find(  
   const key_type& _Keyval  
);  
  
const_iterator find(  
   const key_type& _Keyval  
) const;  
```  
  
#### Parameters  
 `_Keyval`  
 The key value to search for.  
  
## Return Value  
 An iterator pointing to the location of the the first element that matched the key provided, or the iterator `end()` if no such element exists.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../vs140/concurrent_unordered_multiset-class.md)
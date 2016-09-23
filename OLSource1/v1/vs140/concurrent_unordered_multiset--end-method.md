---
title: "concurrent_unordered_multiset::end Method"
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
ms.assetid: 35fc1002-5154-4efb-9317-9546feffb9ca
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multiset::end Method
Returns an iterator pointing to the location succeeding the last element in the concurrent container. This method is concurrency safe.  
  
## Syntax  
  
```  
iterator end();  
  
const_iterator end() const;  
```  
  
## Return Value  
 An iterator to the location succeeding the last element in the concurrent container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../vs140/concurrent_unordered_multiset-class.md)
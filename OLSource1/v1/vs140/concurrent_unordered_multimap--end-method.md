---
title: "concurrent_unordered_multimap::end Method"
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
ms.assetid: 0dac8518-f680-41fa-abb7-c952b6d4d9bc
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multimap::end Method
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
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)
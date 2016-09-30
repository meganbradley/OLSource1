---
title: "concurrent_vector::rbegin Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: ae710418-a6cb-4370-b71b-a4915ee2e709
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::rbegin Method
Returns an iterator of type `reverse_iterator` or `const_reverse_iterator` to the beginning of the concurrent vector. This method is concurrency-safe.  
  
## Syntax  
  
```  
reverse_iterator rbegin();  
  
const_reverse_iterator rbegin() const;  
```  
  
## Return Value  
 An iterator of type `reverse_iterator` or `const_reverse_iterator` to the beginning of the concurrent vector.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)
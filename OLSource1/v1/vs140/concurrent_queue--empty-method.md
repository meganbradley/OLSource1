---
title: "concurrent_queue::empty Method"
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
  - "concurrent_queue/concurrency::concurrent_queue::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: 6e50bf38-1be9-4c1d-a6d9-9c7195543cbf
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_queue::empty Method
Tests if the concurrent queue is empty at the moment this method is called. This method is concurrency-safe.  
  
## Syntax  
  
```  
bool empty() const;  
```  
  
## Return Value  
 `true` if the concurrent queue was empty at the moment we looked, `false` otherwise.  
  
## Remarks  
 While this method is concurrency-safe with respect to calls to the methods `push`, `try_pop`, and `empty`, the value returned might be incorrect by the time it is inspected by the calling thread.  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_queue Class](../vs140/concurrent_queue-class.md)
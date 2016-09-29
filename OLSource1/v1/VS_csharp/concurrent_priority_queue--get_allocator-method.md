---
title: "concurrent_priority_queue::get_allocator Method"
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
  - "concurrent_priority_queue/concurrency::concurrent_priority_queue::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 9139c1db-41d3-49ba-a448-e1eba952c83d
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_priority_queue::get_allocator Method
Returns a copy of the allocator used to construct the concurrent priority queue. This method is concurrency-safe.  
  
## Syntax  
  
```  
allocator_type get_allocator() const;  
```  
  
## Return Value  
 A copy of the allocator used to construct the `concurrent_priority_queue` object.  
  
## Requirements  
 **Header:** concurrent_priority_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_priority_queue Class](../VS_csharp/concurrent_priority_queue-class.md)
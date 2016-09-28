---
title: "concurrent_priority_queue::clear Method"
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
  - "concurrent_priority_queue/concurrency::concurrent_priority_queue::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: 7c37a32d-40fd-480e-8fa1-9bc6639c05d7
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_priority_queue::clear Method
Erases all elements in the concurrent priority. This method is not concurrency-safe.  
  
## Syntax  
  
```  
void clear();  
```  
  
## Remarks  
 `clear` is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent priority queue when you call this method. `clear` does not free memory.  
  
## Requirements  
 **Header:** concurrent_priority_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_priority_queue Class](../vs140/concurrent_priority_queue-class.md)
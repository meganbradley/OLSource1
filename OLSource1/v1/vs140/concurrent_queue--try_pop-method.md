---
title: "concurrent_queue::try_pop Method"
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
  - "concurrent_queue/concurrency::concurrent_queue::try_pop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "try_pop method"
ms.assetid: cae07ea0-5fe0-468d-90c9-641a953b755b
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_queue::try_pop Method
Dequeues an item from the queue if one is available. This method is concurrency-safe.  
  
## Syntax  
  
```  
bool try_pop(  
   _Ty& _Dest  
);  
```  
  
#### Parameters  
 `_Dest`  
 A reference to a location to store the dequeued item.  
  
## Return Value  
 `true` if an item was successfully dequeued,`false` otherwise.  
  
## Remarks  
 If an item was successfully dequeued, the parameter `_Dest` receives the dequeued value, the original value held in the queue is destroyed, and this function returns `true`. If there was no item to dequeue, this function returns `false` without blocking, and the contents of the `_Dest` parameter are undefined.  
  
 `try_pop` is concurrency-safe with respect to calls to the methods `push`, `try_pop`, and `empty`.  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_queue Class](../vs140/concurrent_queue-class.md)
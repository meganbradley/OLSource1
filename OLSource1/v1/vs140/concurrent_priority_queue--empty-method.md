---
title: "concurrent_priority_queue::empty Method"
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
  - "concurrent_priority_queue/concurrency::concurrent_priority_queue::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: 54450c62-f224-48af-9928-f1399ba57223
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_priority_queue::empty Method
Tests if the concurrent priority queue is empty at the time this method is called. This method is concurrency-safe.  
  
## Syntax  
  
```  
bool empty() const;  
```  
  
## Return Value  
 `true` if the priority queue was empty at the moment the function was called, `false` otherwise.  
  
## Requirements  
 **Header:** concurrent_priority_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_priority_queue Class](../vs140/concurrent_priority_queue-class.md)
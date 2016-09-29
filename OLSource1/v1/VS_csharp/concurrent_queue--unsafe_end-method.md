---
title: "concurrent_queue::unsafe_end Method"
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
  - "concurrent_queue/concurrency::concurrent_queue::unsafe_end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsafe_end method"
ms.assetid: 498dbad1-b8e2-4487-98e9-0d0ddcfc9fbb
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_queue::unsafe_end Method
Returns an iterator of type `iterator` or `const_iterator` to the end of the concurrent queue. This method is not concurrency-safe.  
  
## Syntax  
  
```  
iterator unsafe_end();  
  
const_iterator unsafe_end() const;  
```  
  
## Return Value  
 An iterator of type `iterator` or `const_iterator` to the end of the concurrent queue.  
  
## Remarks  
 The iterators for the `concurrent_queue` class are primarily intended for debugging, as they are slow, and iteration is not concurrency-safe with respect to other queue operations.  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_queue Class](../VS_csharp/concurrent_queue-class.md)
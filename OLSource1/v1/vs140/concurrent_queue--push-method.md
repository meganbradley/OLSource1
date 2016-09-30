---
title: "concurrent_queue::push Method"
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
  - "concurrent_queue/concurrency::concurrent_queue::push"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push method"
ms.assetid: a0013721-3a3b-4307-a29e-710d8c39d8a9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_queue::push Method
Enqueues an item at tail end of the concurrent queue. This method is concurrency-safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The item to be added to the queue.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is concurrency-safe with respect to calls to the methods <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_queue Class](../vs140/concurrent_queue-class.md)
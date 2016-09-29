---
title: "thread::join Method"
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
  - "thread/std::thread::join"
dev_langs: 
  - "C++"
ms.assetid: 6e45b2d2-15a6-4221-a825-105a14431115
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# thread::join Method
Blocks until the thread of execution that's associated with the calling object completes.  
  
## Syntax  
  
```  
void join();  
```  
  
## Remarks  
 If the call succeeds, subsequent calls to [get_id](../vs140/thread--get_id-method.md) for the calling object return a default [thread::id](../vs140/thread--id-class.md) that does not compare equal to the `thread::id` of any existing thread; if the call does not succeed, the value that's returned by `get_id` is unchanged.  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
## See Also  
 [thread Class](../vs140/thread-class.md)   
 [<thread\>](../vs140/-thread-.md)
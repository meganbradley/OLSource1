---
title: "clear Function"
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
  - "concurrent_queue/concurrency::concurrent_queue::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear function"
ms.assetid: 05f59278-cdae-4629-9a79-7d6aeaf19459
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# clear Function
Clears the concurrent queue, destroying any currently enqueued elements. This method is not concurrency-safe.  
  
## Syntax  
  
```  
template<  
   typename _Ty,  
   class _Ax  
>  
void concurrent_queue<_Ty,_Ax>::clear();  
```  
  
#### Parameters  
 `_Ty`  
 `_Ax`  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Reference (Concurrency Runtime)](../vs140/reference--concurrency-runtime-.md)
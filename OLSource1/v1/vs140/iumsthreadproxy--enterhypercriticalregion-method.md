---
title: "IUMSThreadProxy::EnterHyperCriticalRegion Method"
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
  - "concrtrm/concurrency::IUMSThreadProxy::EnterHyperCriticalRegion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnterHyperCriticalRegion method"
ms.assetid: 5761b329-c273-4458-8679-80d708a2cb9a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IUMSThreadProxy::EnterHyperCriticalRegion Method
Called in order to enter a hyper-critical region. When inside a hyper-critical region, the scheduler will not observe any blocking operations that happen during the region. This means the scheduler will not be reentered for blocking function calls, lock acquisition attempts which block, page faults, thread suspensions, kernel asynchronous procedure calls (APCs), and so forth, for a UMS thread.  
  
## Syntax  
  
```  
virtual int EnterHyperCriticalRegion() =0;  
```  
  
## Return Value  
 The new depth of hyper-critical region. Hyper-critical regions are reentrant.  
  
## Remarks  
 The scheduler must be extraordinarily careful about what methods it calls and what locks it acquires in such regions. If code in such a region blocks on a lock that is held by something the scheduler is responsible for scheduling, deadlock may ensue.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IUMSThreadProxy Structure](../vs140/iumsthreadproxy-structure.md)   
 [IUMSThreadProxy::ExitHyperCriticalRegion Method](../vs140/iumsthreadproxy--exithypercriticalregion-method.md)
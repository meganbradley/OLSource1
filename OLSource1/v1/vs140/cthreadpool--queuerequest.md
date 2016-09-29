---
title: "CThreadPool::QueueRequest"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CThreadPool.QueueRequest"
  - "CThreadPool::QueueRequest"
  - "ATL.CThreadPool.QueueRequest"
  - "QueueRequest"
  - "ATL::CThreadPool::QueueRequest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueueRequest method"
ms.assetid: f665017a-20a5-4d83-817e-6119ce6b1727
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CThreadPool::QueueRequest
Call this method to queue a work item to be handled by a thread in the pool.  
  
## Syntax  
  
```  
  
      BOOL QueueRequest(  
   Worker::RequestType request   
) throw( );  
```  
  
#### Parameters  
 `request`  
 The request to be queued.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 This method adds a work item to the queue. The threads in the pool pick items off the queue in the order in which they are received.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)
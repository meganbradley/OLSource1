---
title: "CThreadPool::SetSize"
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
  - "ATL.CThreadPool.SetSize"
  - "CThreadPool::SetSize"
  - "CThreadPool.SetSize"
  - "ATL::CThreadPool::SetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSize method"
ms.assetid: 2298ab3a-19ce-4ba3-8553-39ac488b18cb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CThreadPool::SetSize
Call this method to set the number of threads in the pool.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE SetSize(  
   int nNumThreads   
) throw( );  
```  
  
#### Parameters  
 `nNumThreads`  
 The requested number of threads in the pool.  
  
 If `nNumThreads` is negative, its absolute value will be multiplied by the number of processors in the machine to get the total number of threads.  
  
 If `nNumThreads` is zero, [ATLS_DEFAULT_THREADSPERPROC](../vs140/atls_default_threadsperproc.md) will be multiplied by the number of processors in the machine to get the total number of threads.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 If the number of threads specified is less than the number of threads currently in the pool, the object puts a shutdown message on the queue to be picked up by a waiting thread. When a waiting thread pulls the message off the queue, it notifies the thread pool and exits the thread procedure. This process is repeated until the number of threads in the pool reaches the specified number or until no thread has exited within the period specified by [GetTimeout](../vs140/cthreadpool--gettimeout.md)/[SetTimeout](../vs140/cthreadpool--settimeout.md). In this situation the method will return an HRESULT corresponding to **WAIT_TIMEOUT** and the pending shutdown message is canceled.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)   
 [IThreadPoolConfig::SetSize](../vs140/ithreadpoolconfig--setsize.md)   
 [CThreadPool::GetSize](../vs140/cthreadpool--getsize.md)
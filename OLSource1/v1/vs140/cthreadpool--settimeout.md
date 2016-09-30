---
title: "CThreadPool::SetTimeout"
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
  - "ATL.CThreadPool.SetTimeout"
  - "ATL::CThreadPool::SetTimeout"
  - "SetTimeout"
  - "CThreadPool.SetTimeout"
  - "CThreadPool::SetTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTimeout method"
ms.assetid: 9efa62b1-9512-4e12-bddc-274483088f07
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CThreadPool::SetTimeout
Call this method to set the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The requested maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 The timeout is initialized to [ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT](../vs140/atls_default_threadpoolshutdowntimeout.md) in the constructor.  
  
 Note that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the time that the pool will wait for a single thread to shut down. The maximum time that could be taken to remove multiple threads from the pool could be slightly less than <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> multiplied by the number of threads.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)   
 [IThreadPoolConfig::SetTimeout](../vs140/ithreadpoolconfig--settimeout.md)   
 [CThreadPool::GetTimeout](../vs140/cthreadpool--gettimeout.md)
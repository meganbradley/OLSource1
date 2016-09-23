---
title: "CThreadPool::GetTimeout"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CThreadPool::GetTimeout
  - ATL.CThreadPool.GetTimeout
  - GetTimeout
  - CThreadPool.GetTimeout
  - ATL::CThreadPool::GetTimeout
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTimeout method
ms.assetid: f27db84b-a4fd-42e1-9c83-89f0458e43e8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CThreadPool::GetTimeout
Call this method to get the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE GetTimeout(  
   DWORD* pdwMaxWait   
) throw( );  
```  
  
#### Parameters  
 `pdwMaxWait`  
 [out] Address of the variable that, on success, receives the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This timeout value is used by [CThreadPool::Shutdown](../vs140/cthreadpool--shutdown.md) if no other value is supplied to that method.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)   
 [IThreadPoolConfig::GetTimeout](../vs140/ithreadpoolconfig--gettimeout.md)   
 [CThreadPool::SetTimeout](../vs140/cthreadpool--settimeout.md)
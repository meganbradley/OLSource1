---
title: "CThreadPool::GetSize"
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
  - ATL.CThreadPool.GetSize
  - CThreadPool.GetSize
  - CThreadPool::GetSize
  - ATL::CThreadPool::GetSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSize method
ms.assetid: 9f6d3069-5cb4-43f5-ba48-2760b7b4f122
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CThreadPool::GetSize
Call this method to get the number of threads in the pool.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE GetSize(  
   int* pnNumThreads   
) throw( );  
```  
  
#### Parameters  
 `pnNumThreads`  
 [out] Address of the variable that, on success, receives the number of threads in the pool.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)   
 [IThreadPoolConfig::GetSize](../vs140/ithreadpoolconfig--getsize.md)   
 [CThreadPool::SetSize](../vs140/cthreadpool--setsize.md)   
 [CThreadPool::GetNumThreads](../vs140/cthreadpool--getnumthreads.md)
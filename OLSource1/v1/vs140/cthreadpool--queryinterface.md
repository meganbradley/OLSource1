---
title: "CThreadPool::QueryInterface"
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
  - "ATL.CThreadPool.QueryInterface"
  - "CThreadPool.QueryInterface"
  - "ATL::CThreadPool::QueryInterface"
  - "CThreadPool::QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: 962b28f8-24fd-4a43-b5ac-df0d8c2dd858
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CThreadPool::QueryInterface
Implementation of **IUnknown::QueryInterface**.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE QueryInterface(  
   REFIID riid,  
   void** ppv   
) throw( );  
```  
  
## Remarks  
 Objects of this class can be successfully queried for the **IUnknown** and [IThreadPoolConfig](../vs140/ithreadpoolconfig-interface.md) interfaces.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)
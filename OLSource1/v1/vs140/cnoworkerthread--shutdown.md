---
title: "CNoWorkerThread::Shutdown"
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
  - "CNoWorkerThread.Shutdown"
  - "ATL.CNoWorkerThread.Shutdown"
  - "ATL::CNoWorkerThread::Shutdown"
  - "CNoWorkerThread::Shutdown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShutDown method"
ms.assetid: 74dd13b9-e8db-470c-add7-387af5ee632f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNoWorkerThread::Shutdown
Non-functional equivalent of [CWorkerThread::Shutdown](../vs140/cworkerthread--shutdown.md).  
  
## Syntax  
  
```  
  
      HRESULT Shutdown(  
   DWORD dwWait = ATL_WORKER_THREAD_WAIT   
) throw( );  
```  
  
## Return Value  
 Always returns S_OK.  
  
## Remarks  
 The implementation provided by this class does nothing.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CNoWorkerThread Class](../vs140/cnoworkerthread-class.md)
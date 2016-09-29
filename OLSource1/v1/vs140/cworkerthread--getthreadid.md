---
title: "CWorkerThread::GetThreadId"
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
  - "CWorkerThread.GetThreadId"
  - "CWorkerThread::GetThreadId"
  - "GetThreadId"
  - "ATL::CWorkerThread<ThreadTraits>::GetThreadId"
  - "CWorkerThread<ThreadTraits>::GetThreadId"
  - "ATL.CWorkerThread.GetThreadId"
  - "ATL::CWorkerThread::GetThreadId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetThreadId method"
ms.assetid: 27abeb97-b089-4ddc-a044-661e04fa4cdd
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWorkerThread::GetThreadId
Call this method to get the thread ID of the worker thread.  
  
## Syntax  
  
```  
  
DWORD GetThreadId( ) throw( );  
  
```  
  
## Return Value  
 Returns the thread ID or NULL if the worker thread has not been initialized.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CWorkerThread Class](../vs140/cworkerthread-class.md)
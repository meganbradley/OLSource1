---
title: "CWorkerThread::AddHandle"
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
  - "ATL.CWorkerThread<ThreadTraits>.AddHandle"
  - "CWorkerThread.AddHandle"
  - "CWorkerThread::AddHandle"
  - "CWorkerThread<ThreadTraits>::AddHandle"
  - "ATL::CWorkerThread::AddHandle"
  - "AddHandle"
  - "ATL::CWorkerThread<ThreadTraits>::AddHandle"
  - "ATL.CWorkerThread.AddHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddHandle method"
ms.assetid: 30baeb7c-aa16-43c0-a947-ff65f6a7f145
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWorkerThread::AddHandle
Call this method to add a waitable object's handle to the list maintained by the worker thread.  
  
## Syntax  
  
```  
  
      HRESULT AddHandle(  
   HANDLE hObject,  
   IWorkerThreadClient* pClient,  
   DWORD_PTR dwParam   
) throw( );  
```  
  
#### Parameters  
 `hObject`  
 The handle to a waitable object.  
  
 `pClient`  
 The pointer to the [IWorkerThreadClient](../vs140/iworkerthreadclient-interface.md) interface on the object to be called when the handle is signaled.  
  
 `dwParam`  
 The parameter to be passed to [IWorkerThreadClient::Execute](../vs140/iworkerthreadclient--execute.md) when the handle is signaled.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 [IWorkerThreadClient::Execute](../vs140/iworkerthreadclient--execute.md) will be called through `pClient` when the handle, `hObject`, is signaled.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CWorkerThread Class](../vs140/cworkerthread-class.md)
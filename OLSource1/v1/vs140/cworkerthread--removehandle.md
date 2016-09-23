---
title: "CWorkerThread::RemoveHandle"
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
  - ATL::CWorkerThread<ThreadTraits>::RemoveHandle
  - CWorkerThread<ThreadTraits>::RemoveHandle
  - RemoveHandle
  - ATL::CWorkerThread::RemoveHandle
  - CWorkerThread::RemoveHandle
  - ATL.CWorkerThread.RemoveHandle
  - CWorkerThread.RemoveHandle
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveHandle method
ms.assetid: c5a4b432-c4c1-48dc-9967-4f6610e3a3b1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWorkerThread::RemoveHandle
Call this method to remove a handle from the list of waitable objects.  
  
## Syntax  
  
```  
  
      HRESULT RemoveHandle(  
   HANDLE hObject   
) throw( );  
```  
  
#### Parameters  
 `hObject`  
 The handle to remove.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 When the handle is removed [IWorkerThreadClient::CloseHandle](../vs140/iworkerthreadclient--closehandle.md) will be called on the associated object that was passed to [AddHandle](../vs140/cworkerthread--addhandle.md). If this call fails, `CWorkerThread` will call the Windows [CloseHandle](http://msdn.microsoft.com/library/windows/desktop/ms724211) function on the handle.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CWorkerThread Class](../vs140/cworkerthread-class.md)
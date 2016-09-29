---
title: "CWorkerThread::Initialize"
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
  - "CWorkerThread.Initialize"
  - "CWorkerThread<ThreadTraits>::Initialize"
  - "Initialize"
  - "ATL.CWorkerThread.Initialize"
  - "ATL::CWorkerThread::Initialize"
  - "ATL::CWorkerThread<ThreadTraits>::Initialize"
  - "CWorkerThread::Initialize"
  - "ATL.CWorkerThread<ThreadTraits>.Initialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Initialize method"
ms.assetid: 0915fc9c-d6cb-4740-9b21-df8d34a8c70d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWorkerThread::Initialize
Call this method to initialize the worker thread.  
  
## Syntax  
  
```  
  
      HRESULT Initialize( ) throw( );   
HRESULT Initialize(  
   CWorkerThread< ThreadTraits > * pThread   
) throw( );  
```  
  
#### Parameters  
 `pThread`  
 An existing worker thread.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method should be called to initialize the object after creation or after a call to [CWorkerThread::Shutdown](../vs140/cworkerthread--shutdown.md).  
  
 To have two or more `CWorkerThread` objects use the same worker thread, initialize one of them without passing any arguments then pass a pointer to that object to the `Initialize` methods of the others. The objects initialized using the pointer should be shut down before the object used to initialize them.  
  
 See [CWorkerThread::Shutdown](../vs140/cworkerthread--shutdown.md) for information on how that method's behavior changes when initialized using a pointer to an existing object.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CWorkerThread Class](../vs140/cworkerthread-class.md)
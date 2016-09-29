---
title: "CNoWorkerThread::AddTimer"
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
  - "ATL::CNoWorkerThread::AddTimer"
  - "AddTimer"
  - "CNoWorkerThread.AddTimer"
  - "ATL.CNoWorkerThread.AddTimer"
  - "CNoWorkerThread::AddTimer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTimer method"
ms.assetid: d9ecc65e-1d2e-4be8-8669-561fe1a5e150
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNoWorkerThread::AddTimer
Non-functional equivalent of [CWorkerThread::AddTimer](../vs140/cworkerthread--addtimer.md).  
  
## Syntax  
  
```  
  
      HRESULT AddTimer(  
   DWORD /* dwInterval */,  
   IWorkerThreadClient * /* pClient */,  
   DWORD_PTR /* dwParam */,  
   HANDLE * /* phTimer */   
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
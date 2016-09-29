---
title: "CNoWorkerThread::AddHandle"
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
  - "ATL.CNoWorkerThread.AddHandle"
  - "ATL::CNoWorkerThread::AddHandle"
  - "CNoWorkerThread::AddHandle"
  - "AddHandle"
  - "CNoWorkerThread.AddHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddHandle method"
ms.assetid: bf35bc89-e448-4cf0-b027-75223763d482
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNoWorkerThread::AddHandle
Non-functional equivalent of [CWorkerThread::AddHandle](../vs140/cworkerthread--addhandle.md).  
  
## Syntax  
  
```  
  
      HRESULT AddHandle(  
   HANDLE /* hObject */,  
   IWorkerThreadClient * /* pClient */,  
   DWORD_PTR /* dwParam */   
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
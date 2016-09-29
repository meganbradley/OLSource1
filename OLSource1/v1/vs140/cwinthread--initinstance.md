---
title: "CWinThread::InitInstance"
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
  - "CWinThread.InitInstance"
  - "CWinThread::InitInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitInstance method"
  - "CWinThread class, overridables"
ms.assetid: 346176e4-9dcf-4d00-bee7-48b307328991
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::InitInstance
`InitInstance` must be overridden to initialize each new instance of a user-interface thread.  
  
## Syntax  
  
```  
  
virtual BOOL InitInstance( );  
```  
  
## Return Value  
 Nonzero if initialization is successful; otherwise 0.  
  
## Remarks  
 Typically, you override `InitInstance` to perform tasks that must be completed when a thread is first created.  
  
 This member function is used only in user-interface threads. Perform initialization of worker threads in the controlling function passed to [AfxBeginThread](../vs140/afxbeginthread.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)
---
title: "CWinThread::m_pMainWnd"
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
  - "CWinThread.m_pMainWnd"
  - "CWinThread::m_pMainWnd"
  - "m_pMainWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pMainWnd"
  - "CWinThread class, data members"
ms.assetid: 0ba89a46-25ef-4208-8ee5-4cb9f1f8f096
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::m_pMainWnd
Use this data member to store a pointer to your thread's main window object.  
  
## Syntax  
  
```  
  
CWnd* m_pMainWnd;  
  
```  
  
## Remarks  
 The Microsoft Foundation Class Library will automatically terminate your thread when the window referred to by `m_pMainWnd` is closed. If this thread is the primary thread for an application, the application will also be terminated. If this data member is **NULL**, the main window for the application's `CWinApp` object will be used to determine when to terminate the thread. `m_pMainWnd` is a public variable of type **CWnd\***.  
  
 Typically, you set this member variable when you override `InitInstance`. In a worker thread, the value of this data member is inherited from its parent thread.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinThread::InitInstance](../vs140/cwinthread--initinstance.md)
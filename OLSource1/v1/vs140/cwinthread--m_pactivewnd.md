---
title: "CWinThread::m_pActiveWnd"
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
  - "CWinThread::m_pActiveWnd"
  - "m_pActiveWnd"
  - "CWinThread.m_pActiveWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinThread class, data members"
  - "m_pActiveWnd"
ms.assetid: 1148a727-fb61-497a-8ab9-6c0d2c975965
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::m_pActiveWnd
Use this data member to store a pointer to your thread's active window object.  
  
## Syntax  
  
```  
  
CWnd* m_pActiveWnd;  
  
```  
  
## Remarks  
 The Microsoft Foundation Class Library will automatically terminate your thread when the window referred to by `m_pActiveWnd` is closed. If this thread is the primary thread for an application, the application will also be terminated. If this data member is **NULL**, the active window for the application's `CWinApp` object will be inherited. `m_pActiveWnd` is a public variable of type **CWnd\***.  
  
 Typically, you set this member variable when you override `InitInstance`. In a worker thread, the value of this data member is inherited from its parent thread.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinThread::InitInstance](../vs140/cwinthread--initinstance.md)   
 [CWinThread::m_pMainWnd](../vs140/cwinthread--m_pmainwnd.md)
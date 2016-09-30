---
title: "CWinApp::m_pActiveWnd"
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
  - "CWinApp::m_pActiveWnd"
  - "CWinApp.m_pActiveWnd"
  - "m_pActiveWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pActiveWnd"
  - "CWinApp class, data members"
ms.assetid: c12d1c91-6ef0-4b18-9f3f-06c5a450a66f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_pActiveWnd
Use this data member to store a pointer to the main window of the OLE container application that has your OLE server application in-place activated.  
  
## Remarks  
 If this data member is **NULL**, the application is not in-place active.  
  
 The framework sets this member variable when the frame window is in-place activated by an OLE container application.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AfxGetMainWnd](../vs140/afxgetmainwnd.md)   
 [CWinThread::m_pMainWnd](../vs140/cwinthread--m_pmainwnd.md)
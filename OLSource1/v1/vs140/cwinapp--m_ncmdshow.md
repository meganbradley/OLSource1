---
title: "CWinApp::m_nCmdShow"
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
  - "CWinApp.m_nCmdShow"
  - "m_nCmdShow"
  - "CWinApp::m_nCmdShow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nCmdShow"
  - "CWinApp class, data members"
ms.assetid: ba1c0117-3446-4613-ac56-ff1433515d19
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_nCmdShow
Corresponds to the `nCmdShow` parameter passed by Windows to `WinMain`.  
  
## Syntax  
  
```  
  
int m_nCmdShow;  
  
```  
  
## Remarks  
 You should pass `m_nCmdShow` as an argument when you call [CWnd::ShowWindow](../vs140/cwnd--showwindow.md) for your application's main window. `m_nCmdShow` is a public variable of type `int`.  
  
## Example  
 [!code[NVC_MFCWindowing#56](../vs140/codesnippet/CPP/cwinapp--m_ncmdshow_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
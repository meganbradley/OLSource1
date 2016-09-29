---
title: "CWinApp::m_lpCmdLine"
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
  - "CWinApp::m_lpCmdLine"
  - "m_lpCmdLine"
  - "CWinApp.m_lpCmdLine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_lpCmdLine"
  - "CWinApp class, data members"
ms.assetid: c29fd6e9-47cd-4fec-91c8-62c91a794c98
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_lpCmdLine
Corresponds to the `lpCmdLine` parameter passed by Windows to `WinMain`.  
  
## Syntax  
  
```  
  
LPTSTR m_lpCmdLine;  
  
```  
  
## Remarks  
 Points to a null-terminated string that specifies the command line for the application. Use `m_lpCmdLine` to access any command-line arguments the user entered when the application was started. `m_lpCmdLine` is a public variable of type `LPTSTR`.  
  
## Example  
 [!code[NVC_MFCWindowing#52](../vs140/codesnippet/CPP/cwinapp--m_lpcmdline_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
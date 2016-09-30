---
title: "CWinApp::EnableShellOpen"
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
  - "CWinApp::EnableShellOpen"
  - "CWinApp.EnableShellOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, initialization"
  - "applications [C++], opening"
  - "EnableShellOpen method"
ms.assetid: d73c8842-493d-4948-b2ea-4c68308b1be9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::EnableShellOpen
Call this function, typically from your <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> override, to enable your application's users to open data files when they double-click the files from within the Windows File Manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Call the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function in conjunction with this function, or provide a .REG file with your application for manual registration of document types.  
  
## Example  
 [!code[NVC_MFCWindowing#38](../vs140/codesnippet/CPP/cwinapp--enableshellopen_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnDDECommand](../vs140/cwinapp--onddecommand.md)   
 [CWinApp::RegisterShellFileTypes](../vs140/cwinapp--registershellfiletypes.md)
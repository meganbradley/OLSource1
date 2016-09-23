---
title: "CWinApp::OnDDECommand"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWinApp.OnDDECommand
  - OnDDECommand
  - CWinApp::OnDDECommand
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDDECommand method
  - DDE (Dynamic Data Exchange), message execution
  - CWinApp class, overridables
ms.assetid: 36c1c16d-41fd-46e2-b408-4095f2315952
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::OnDDECommand
Called by the framework when the main frame window receives a DDE execute message.  
  
## Syntax  
  
```  
  
      virtual BOOL OnDDECommand(  
   LPTSTR lpszCommand   
);  
```  
  
#### Parameters  
 *lpszCommand*  
 Points to a DDE command string received by the application.  
  
## Return Value  
 Nonzero if the command is handled; otherwise 0.  
  
## Remarks  
 The default implementation checks whether the command is a request to open a document and, if so, opens the specified document. The Windows File Manager usually sends such DDE command strings when the user double-clicks a data file. Override this function to handle other DDE execute commands, such as the command to print.  
  
## Example  
 [!code[NVC_MFCWindowing#48](../vs140/codesnippet/CPP/cwinapp--onddecommand_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::EnableShellOpen](../vs140/cwinapp--enableshellopen.md)
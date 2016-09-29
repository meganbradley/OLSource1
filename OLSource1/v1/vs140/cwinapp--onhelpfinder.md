---
title: "CWinApp::OnHelpFinder"
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
  - "OnHelpFinder"
  - "CWinApp.OnHelpFinder"
  - "CWinApp::OnHelpFinder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Help Finder"
  - "CWinApp class, command handlers"
  - "OnHelpFinder method"
ms.assetid: 5fe1c81c-2dcf-49cb-ab47-b660961f2109
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::OnHelpFinder
Handles the **ID_HELP_FINDER** and **ID_DEFAULT_HELP** commands.  
  
## Syntax  
  
```  
  
afx_msg void OnHelpFinder( );  
```  
  
## Remarks  
 You must add an `ON_COMMAND( ID_HELP_FINDER, OnHelpFinder )` statement to your `CWinApp` class message map to enable this member function. If enabled, the framework calls this message-handler function when the user of your application selects the Help Finder command to invoke `WinHelp` with the standard **HELP_FINDER** topic.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnHelp](../vs140/cwinapp--onhelp.md)   
 [CWinApp::OnHelpUsing](../vs140/cwinapp--onhelpusing.md)   
 [CWinApp::WinHelp](../vs140/cwinapp--winhelp.md)   
 [CWinApp::OnHelpIndex](../vs140/cwinapp--onhelpindex.md)
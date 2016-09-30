---
title: "CWinApp::OnHelpIndex"
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
  - "CWinApp::OnHelpIndex"
  - "CWinApp.OnHelpIndex"
  - "OnHelpIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, command handlers"
  - "OnHelpIndex method"
ms.assetid: 90e0d402-058f-46b8-88f0-6d0c67d87f0b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::OnHelpIndex
Handles the **ID_HELP_INDEX** command and provides a default Help topic.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You must add an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement to your <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class message map to enable this member function. If enabled, the framework calls this message-handler function when the user of your application selects the Help Index command to invoke <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> with the standard **HELP_INDEX** topic.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnHelp](../vs140/cwinapp--onhelp.md)   
 [CWinApp::OnHelpUsing](../vs140/cwinapp--onhelpusing.md)   
 [CWinApp::WinHelp](../vs140/cwinapp--winhelp.md)
---
title: "CWinApp::OnHelpUsing"
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
  - "OnHelpUsing"
  - "CWinApp.OnHelpUsing"
  - "CWinApp::OnHelpUsing"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, command handlers"
  - "OnHelpUsing method"
ms.assetid: 1ea0cbb1-23a9-4893-81b6-e7a7f514c241
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::OnHelpUsing
Handles the **ID_HELP_USING** command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You must add an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement to your <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class message map to enable this member function. The framework calls this message-handler function when the user of your application selects the Help Using command to invoke the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> application with the standard **HELP_HELPONHELP** topic.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnHelp](../vs140/cwinapp--onhelp.md)   
 [CWinApp::OnHelpIndex](../vs140/cwinapp--onhelpindex.md)   
 [CWinApp::WinHelp](../vs140/cwinapp--winhelp.md)
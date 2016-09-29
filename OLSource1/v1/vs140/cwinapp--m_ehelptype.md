---
title: "CWinApp::m_eHelpType"
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
  - "CWinApp.m_eHelpType"
  - "m_eHelpType"
  - "CWinApp::m_eHelpType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, data members"
  - "m_eHelpType"
ms.assetid: 5a481f8f-e6b1-4890-a4f8-7b81cac0b154
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_eHelpType
The type of this data member is the enumerated type **AFX_HELP_TYPE**, which is defined within the `CWinApp` class.  
  
## Syntax  
  
```  
  
AFX_HELP_TYPE m_eHelpType;  
  
```  
  
## Remarks  
 The **AFX_HELP_TYPE** enumeration is defined as follows:  
  
 `enum AFX_HELP_TYPE`  
  
 `{`  
  
 `afxWinHelp = 0,`  
  
 `afxHTMLHelp = 1`  
  
 `};`  
  
-   To set the application's help to HTML Help, call [SetHelpMode](../vs140/cwinapp--sethelpmode.md) and specify **afxHTMLHelp**.  
  
-   To set the application's help to WinHelp, call `SetHelpMode` and specify **afxWinHelp**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::GetHelpMode](../vs140/cwinapp--gethelpmode.md)   
 [CWinApp::EnableHtmlHelp](../vs140/cwinapp--enablehtmlhelp.md)
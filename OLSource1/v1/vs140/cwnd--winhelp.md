---
title: "CWnd::WinHelp"
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
  - "CWnd.WinHelp"
  - "CWnd::WinHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WinHelp method"
ms.assetid: d09916e0-9fc0-4986-9a74-35e6c4a37fbc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::WinHelp
Called to initiate the WinHelp application.  
  
## Syntax  
  
```  
  
      virtual void WinHelp(  
   DWORD_PTR dwData,  
   UINT nCmd = HELP_CONTEXT   
);  
```  
  
#### Parameters  
 `dwData`  
 Specifies additional data. The value used depends on the value of the `nCmd` parameter.  
  
 `nCmd`  
 Specifies the type of help requested. For a list of possible values and how they affect the `dwData` parameter, see the [WinHelp](http://msdn.microsoft.com/library/windows/desktop/bb762267) Windows function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 See [CWinApp::WinHelp](../vs140/cwinapp--winhelp.md) for more information.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::HtmlHelp](../vs140/cwnd--htmlhelp.md)   
 [CWnd::OnHelpUsing](../vs140/cwnd--onhelpusing.md)   
 [CWnd::OnHelpIndex](../vs140/cwnd--onhelpindex.md)
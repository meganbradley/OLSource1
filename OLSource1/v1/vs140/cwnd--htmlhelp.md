---
title: "CWnd::HtmlHelp"
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
  - "CWnd.HtmlHelp"
  - "CWnd::HtmlHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HtmlHelp method"
ms.assetid: 79f214fa-116b-43b8-adb4-a0fdfcb38ac5
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::HtmlHelp
Call this member function to invoke the HTMLHelp application.  
  
## Syntax  
  
```  
  
      virtual void HtmlHelp(  
   DWORD_PTR dwData,  
   UINT nCmd = 0x000F   
);  
```  
  
#### Parameters  
 `dwData`  
 Specifies additional data. The value used depends on the value of the `nCmd` parameter.  
  
 `nCmd`  
 Specifies the type of help requested. For a list of possible values and how they affect the `dwData` parameter, see the `uCommand` parameter described in the [HTMLHelp API Reference](vsconOvhtmlhelpapioverview) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 See [CWinApp::HtmlHelp](../vs140/cwinapp--htmlhelp.md) for more information.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::WinHelp](../vs140/cwnd--winhelp.md)   
 [<PAVE OVER\> Displaying F1 Help for a Dialog Box or Menu Option_deleted](../Topic/%3CPAVE%20OVER%3E%20Displaying%20F1%20Help%20for%20a%20Dialog%20Box%20or%20Menu%20Option_deleted.md)
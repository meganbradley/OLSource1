---
title: "CWindow::WinHelp"
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
  - "CWindow::WinHelp"
  - "ATL::CWindow::WinHelp"
  - "ATL.CWindow.WinHelp"
  - "CWindow.WinHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WinHelp method"
ms.assetid: 71df9a51-3f0f-4a4f-9783-bf844ea8e4ea
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::WinHelp
Starts Windows Help.  
  
## Syntax  
  
```  
  
      BOOL WinHelp(  
   LPCTSTR lpszHelp,  
   UINT nCmd = HELP_CONTEXT,  
   DWORD dwData = 0   
) throw();  
```  
  
## Remarks  
 See [WinHelp](http://msdn.microsoft.com/library/windows/desktop/bb762267) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)
---
title: "CWnd::CenterWindow"
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
  - "CWnd.CenterWindow"
  - "CWnd::CenterWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CenterWindow method"
ms.assetid: 27d0d7d1-374a-4e73-8639-004291b634b9
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CenterWindow
Centers a window relative to its parent.  
  
## Syntax  
  
```  
  
      void CenterWindow(  
   CWnd* pAlternateOwner = NULL   
);  
```  
  
#### Parameters  
 `pAlternateOwner`  
 Pointer to an alternate window relative to which it will be centered (other than the parent window).  
  
## Remarks  
 Usually called from [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md) to center dialog boxes relative to the main window of the application. By default, the function centers child windows relative to their parent window, and pop-up windows relative to their owner. If the pop-up window is not owned, it is centered relative to the screen. To center a window relative to a specific window which is not the owner or parent, the `pAlternateOwner` parameter may be set to a valid window. To force centering relative to the screen, pass the value returned by [CWnd::GetDesktopWindow](../vs140/cwnd--getdesktopwindow.md) as `pAlternateOwner`.  
  
## Example  
 [!code[NVC_MFCWindowing#74](../vs140/codesnippet/CPP/cwnd--centerwindow_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDesktopWindow](../vs140/cwnd--getdesktopwindow.md)   
 [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md)
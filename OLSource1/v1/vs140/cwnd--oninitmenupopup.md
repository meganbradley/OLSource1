---
title: "CWnd::OnInitMenuPopup"
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
  - "CWnd::OnInitMenuPopup"
  - "CWnd.OnInitMenuPopup"
  - "OnInitMenuPopup"
  - "WM_INITMENUPOPUP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnInitMenuPopup method"
  - "WM_INITMENUPOPUP"
  - "CWnd class, initialization message handlers"
ms.assetid: 14525acd-d24a-4ff0-bd86-1806b32f4920
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnInitMenuPopup
The framework calls this member function when a pop-up menu is about to become active.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pPopupMenu*  
 Specifies the menu object of the pop-up menu. May be temporary and should not be stored for later use.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the index of the pop-up menu in the main menu.  
  
 *bSysMenu*  
 **TRUE** if the pop-up menu is the Control menu; otherwise **FALSE**.  
  
## Remarks  
 This allows an application to modify the pop-up menu before it is displayed without changing the entire menu.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnInitMenu](../vs140/cwnd--oninitmenu.md)   
 [WM_INITMENUPOPUP](http://msdn.microsoft.com/library/windows/desktop/ms646347)
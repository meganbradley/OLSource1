---
title: "CWindow::GotoDlgCtrl"
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
  - "CWindow.GotoDlgCtrl"
  - "ATL::CWindow::GotoDlgCtrl"
  - "ATL.CWindow.GotoDlgCtrl"
  - "CWindow::GotoDlgCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GotoDlgCtrl method"
ms.assetid: af585bfa-6836-4889-b0a9-13b3c3513609
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GotoDlgCtrl
Sets the keyboard focus to a control in the dialog box.  
  
## Syntax  
  
```  
  
      void GotoDlgCtrl(  
   HWND hWndCtrl   
) const throw();  
```  
  
## Remarks  
 See [WM_NEXTDLGCTL](http://msdn.microsoft.com/library/windows/desktop/ms645432) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::NextDlgCtrl](../vs140/cwindow--nextdlgctrl.md)   
 [CWindow::PrevDlgCtrl](../vs140/cwindow--prevdlgctrl.md)
---
title: "CWindow::DestroyWindow"
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
  - "CWindow::DestroyWindow"
  - "ATL::CWindow::DestroyWindow"
  - "CWindow.DestroyWindow"
  - "ATL.CWindow.DestroyWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DestroyWindow method"
ms.assetid: 070fcb24-ebce-4f51-9335-26665dfdbd82
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::DestroyWindow
Destroys the window associated with the `CWindow` object and sets [m_hWnd](../vs140/cwindow--m_hwnd.md) to **NULL**.  
  
## Syntax  
  
```  
  
BOOL DestroyWindow( ) throw();  
```  
  
## Remarks  
 See [DestroyWindow](http://msdn.microsoft.com/library/windows/desktop/ms632682) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 It does not destroy the `CWindow` object itself.  
  
## Example  
 [!code[NVC_ATL_Windowing#5](../vs140/codesnippet/CPP/cwindow--destroywindow_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)
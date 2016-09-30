---
title: "CWindow::LockWindowUpdate"
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
  - "ATL::CWindow::LockWindowUpdate"
  - "CWindow.LockWindowUpdate"
  - "CWindow::LockWindowUpdate"
  - "ATL.CWindow.LockWindowUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LockWindowUpdate method"
ms.assetid: ba808bd0-ee91-424c-aa5b-67a1af60b6a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::LockWindowUpdate
Disables or enables drawing in the window by calling the [LockWindowUpdate](http://msdn.microsoft.com/library/windows/desktop/dd145034) Win32 function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] If **TRUE** (the default value), the window will be locked. Otherwise, it will be unlocked.  
  
## Return Value  
 **TRUE** if the window is successfully locked; otherwise, **FALSE**.  
  
## Remarks  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is **TRUE**, this method passes [m_hWnd](../vs140/cwindow--m_hwnd.md) to the Win32 function; otherwise, it passes **NULL**.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)
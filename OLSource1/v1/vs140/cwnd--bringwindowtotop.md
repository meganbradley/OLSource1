---
title: "CWnd::BringWindowToTop"
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
  - "CWnd.BringWindowToTop"
  - "CWnd::BringWindowToTop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BringWindowToTop method"
ms.assetid: 677e451f-c08e-44e8-a23d-d848b9bacc91
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::BringWindowToTop
Brings <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to the top of a stack of overlapping windows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In addition, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> activates pop-up, top-level, and MDI child windows. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function should be used to uncover any window that is partially or completely obscured by any overlapping windows.  
  
 This function just calls the Win32 [BringWindowToTop](http://msdn.microsoft.com/library/windows/desktop/ms632673\(v=vs.85\).aspx) function. Call the [SetWindowPos](../vs140/cwnd--setwindowpos.md) function to change a window's position in the Z-order. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function does not change the window style to make it a top-level window. For more information, see [What's the difference between HWND_TOP and HWND_TOPMOST?](http://blogs.msdn.com/b/oldnewthing/archive/2005/11/21/495246.aspx)  
  
## Example  
 [!code[NVC_MFCWindowing#71](../vs140/codesnippet/CPP/cwnd--bringwindowtotop_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [BringWindowToTop](http://msdn.microsoft.com/library/windows/desktop/ms632673)
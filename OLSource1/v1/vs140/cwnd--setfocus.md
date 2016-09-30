---
title: "CWnd::SetFocus"
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
  - "CWnd.SetFocus"
  - "CWnd::SetFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFocus method"
  - "window focus"
  - "focus, setting"
ms.assetid: 13db2a0d-120d-4d9a-92c1-f8c47844657e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetFocus
Claims the input focus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the window object that previously had the input focus. It is **NULL** if there is no such window. The returned pointer may be temporary and should not be stored.  
  
## Remarks  
 The input focus directs all subsequent keyboard input to this window. Any window that previously had the input focus loses it.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function sends a [WM_KILLFOCUS](http://msdn.microsoft.com/library/windows/desktop/ms646282) message to the window that loses the input focus and a [WM_SETFOCUS](http://msdn.microsoft.com/library/windows/desktop/ms646283) message to the window that receives the input focus. It also activates either the window or its parent.  
  
 If the current window is active but does not have the focus (that is, no window has the focus), any key pressed will produce the messages [WM_SYSCHAR](../vs140/cwnd--onsyschar.md), [WM_SYSKEYDOWN](../vs140/cwnd--onsyskeydown.md), or [WM_SYSKEYUP](../vs140/cwnd--onsyskeyup.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SetFocus](http://msdn.microsoft.com/library/windows/desktop/ms646312)   
 [CWnd::GetFocus](../vs140/cwnd--getfocus.md)
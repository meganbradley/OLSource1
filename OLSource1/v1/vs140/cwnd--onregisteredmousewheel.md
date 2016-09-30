---
title: "CWnd::OnRegisteredMouseWheel"
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
  - "WM_MOUSEWHEEL"
  - "OnRegisteredMouseWheel"
  - "CWnd.OnRegisteredMouseWheel"
  - "CWnd::OnRegisteredMouseWheel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_MOUSEWHEEL"
  - "OnRegisteredMouseWheel method"
ms.assetid: 592d66c5-2320-4206-89fc-3e959156c491
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnRegisteredMouseWheel
The framework calls this member function as a user rotates the mouse wheel and encounters the wheel's next notch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Horizontal position of the pointer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Vertical position of the pointer.  
  
## Return Value  
 Insignificant at this time. Always zero.  
  
## Remarks  
 Unless overridden, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> routes the message to the appropriate window (the parent window with focus), and calls the [WM_MOUSEWHEEL](http://msdn.microsoft.com/library/windows/desktop/ms645617) handler for that window.  
  
 Override this member function to provide your own message routing or to alter the mouse-wheel scrolling behavior.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> handles messages for Windows 95/98 and Windows NT 3.51. For Windows NT 4.0 message handling, use [OnMouseWheel](../vs140/cwnd--onmousewheel.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [RegisterWindowMessage](http://msdn.microsoft.com/library/windows/desktop/ms644947)
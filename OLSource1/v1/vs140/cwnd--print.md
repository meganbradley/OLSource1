---
title: "CWnd::Print"
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
  - "CWnd.Print"
  - "Print"
  - "CWnd::Print"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "printers [C++], device contexts"
  - "windows [C++], printing functions"
  - "DC functions"
  - "printer device contexts"
  - "device contexts [C++], printer"
  - "Print method"
  - "printer device contexts, drawing windows"
  - "windows [C++], drawing functions"
ms.assetid: b2b11fa0-7d82-4119-892f-500772c923f7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::Print
Call this member function to draw the current window in the specified device context, which is most commonly in a printer device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the drawing options. This parameter can be one or more of these flags:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Draw the window only if it is visible.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Draw all visible children windows.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Draw the client area of the window.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Erase the background before drawing the window.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Draw the nonclient area of the window.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Draw all owned windows.  
  
## Remarks  
 [CWnd::DefWindowProc](../vs140/cwnd--defwindowproc.md) function processes this message based on which drawing option is specified:  
  
-   If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is specified and the window is not visible, do nothing.  
  
-   If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is specified, draw the nonclient area in the given device context.  
  
-   If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is specified, send the window a [WM_ERASEBKGND](http://msdn.microsoft.com/library/windows/desktop/ms648055) message.  
  
-   If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is specified, send the window a [WM_PRINTCLIENT](http://msdn.microsoft.com/library/windows/desktop/dd145217) message.  
  
-   If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is set, send each visible child window a [WM_PRINT](http://msdn.microsoft.com/library/windows/desktop/dd145216) message.  
  
-   If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set, send each visible owned window a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> message.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_PRINT](http://msdn.microsoft.com/library/windows/desktop/dd145216)   
 [WM_PRINTCLIENT](http://msdn.microsoft.com/library/windows/desktop/dd145217)
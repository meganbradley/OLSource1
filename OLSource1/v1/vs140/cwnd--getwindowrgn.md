---
title: "CWnd::GetWindowRgn"
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
  - "CWnd.GetWindowRgn"
  - "CWnd::GetWindowRgn"
  - "GetWindowRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "window region"
  - "window region, getting"
  - "GetWindowRgn method"
ms.assetid: b981d5ee-f1d1-4334-8c59-9ff37610f3e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetWindowRgn
Call this member function to get the window region of a window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to a window region.  
  
## Return Value  
 The return value specifies the type of the region that the function obtains. It can be one of the following values:  
  
-   **NULLREGION** The region is empty.  
  
-   **SIMPLEREGION** The region is a single rectangle.  
  
-   **COMPLEXREGION** The region is more than one rectangle.  
  
-   **ERROR** An error occurred; the region is unaffected.  
  
## Remarks  
 The window region determines the area within the window where the operating system permits drawing. The operating system does not display any portion of a window that lies outside of the window region.  
  
 The coordinates of a window's window region are relative to the upper-left corner of the window, not the client area of the window.  
  
 To set the window region of a window, call [CWnd::SetWindowRgn](../vs140/cwnd--setwindowrgn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetWindowRgn](../vs140/cwnd--setwindowrgn.md)
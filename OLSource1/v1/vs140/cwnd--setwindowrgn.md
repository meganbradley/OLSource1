---
title: "CWnd::SetWindowRgn"
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
  - "CWnd::SetWindowRgn"
  - "CWnd.SetWindowRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "window region"
  - "regions, window"
  - "regions, setting"
  - "SetWindowRgn method"
  - "window region, setting"
ms.assetid: 938930e2-f166-4b09-98ea-1757a6d58b9a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetWindowRgn
Call this member function to set a window's region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to a region.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If **TRUE**, the operating system redraws the window after setting the region; otherwise, it does not. Typically, set <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to **TRUE** if the window is visible. If set to **TRUE**, the system sends the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> messages to the window.  
  
## Return Value  
 If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.  
  
## Remarks  
 The coordinates of a window's window region are relative to the upper-left corner of the window, not the client area of the window.  
  
 After a successful call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the operating system owns the region specified by the region handle <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The operating system does not make a copy of the region, so do not make any further function calls with this region handle, and do not close this region handle.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SetWindowRgn](http://msdn.microsoft.com/library/windows/desktop/dd145102)   
 [CWnd::GetWindowRgn](../vs140/cwnd--getwindowrgn.md)
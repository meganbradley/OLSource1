---
title: "CWnd::GetWindowRect"
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
  - "CWnd.GetWindowRect"
  - "CWnd::GetWindowRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindowRect method"
ms.assetid: 4db98c6a-52da-48f9-b3fe-04592f99f12e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetWindowRect
Copies the dimensions of the bounding rectangle of the `CWnd` object to the structure pointed to by `lpRect`.  
  
## Syntax  
  
```  
  
      void GetWindowRect(  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 Points to a `CRect` object or a [RECT](../vs140/rect-structure.md) structure that will receive the screen coordinates of the upper-left and lower-right corners.  
  
## Remarks  
 The dimensions are given in screen coordinates relative to the upper-left corner of the display screen. The dimensions of the caption, border, and scroll bars, if present, are included.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetClientRect](../vs140/cwnd--getclientrect.md)   
 [CWnd::MoveWindow](../vs140/cwnd--movewindow.md)   
 [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md)   
 [GetWindowRect](http://msdn.microsoft.com/library/windows/desktop/ms633519)
---
title: "CWnd::OnQueryOpen"
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
  - "OnQueryOpen"
  - "WM_QUERYOPEN"
  - "CWnd::OnQueryOpen"
  - "CWnd.OnQueryOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnQueryOpen method"
  - "WM_QUERYOPEN"
ms.assetid: b00da448-2d9d-4ad7-bf98-0e1565d81e21
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnQueryOpen
The framework calls this member function when the `CWnd` object is minimized and the user requests that the `CWnd` be restored to its preminimized size and position.  
  
## Syntax  
  
```  
  
afx_msg BOOL OnQueryOpen( );  
```  
  
## Return Value  
 Nonzero if the icon can be opened, or 0 to prevent the icon from being opened.  
  
## Remarks  
 While in `OnQueryOpen`, `CWnd` should not perform any action that would cause an activation or focus change (for example, creating a dialog box).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_QUERYOPEN](http://msdn.microsoft.com/library/windows/desktop/ms632640)
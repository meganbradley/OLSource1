---
title: "CWnd::ScreenToClient"
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
  - "CWnd::ScreenToClient"
  - "CWnd.ScreenToClient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "screen mapping functions"
  - "functions [C++], mapping"
  - "mappings, functions"
  - "CWnd class, coordinate mapping functions"
  - "ScreenToClient method"
ms.assetid: 6461c98a-7a9d-4d6c-905f-23fc13251651
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ScreenToClient
Converts the screen coordinates of a given point or rectangle on the display to client coordinates.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a [CPoint](../vs140/cpoint-class.md) object or [POINT](../vs140/point-structure.md) structure that contains the screen coordinates to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [CRect](../vs140/crect-class.md) object or [RECT](../vs140/rect-structure.md) structure that contains the screen coordinates to be converted.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function replaces the screen coordinates given in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with client coordinates. The new coordinates are relative to the upper-left corner of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> client area.  
  
## Example  
 See the example for [CListCtrl::GetItemRect](../vs140/clistctrl--getitemrect.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ClientToScreen](../vs140/cwnd--clienttoscreen.md)   
 [ScreenToClient](http://msdn.microsoft.com/library/windows/desktop/dd162952)
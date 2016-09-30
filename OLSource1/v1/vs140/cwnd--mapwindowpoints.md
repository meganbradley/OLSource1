---
title: "CWnd::MapWindowPoints"
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
  - "MapWindowPoints"
  - "CWnd::MapWindowPoints"
  - "CWnd.MapWindowPoints"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MapWindowPoints method"
  - "CWnd class, coordinate mapping functions"
ms.assetid: 567c017e-1137-4773-aa67-5f82574ba72d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::MapWindowPoints
Converts (maps) a set of points from the coordinate space of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to the coordinate space of another window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pwndTo*  
 Identifies the window to which points are converted. If this parameter is **NULL**, the points are converted to screen coordinates.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the rectangle whose points are to be converted. The first version of this function is available only for Windows 3.1 and later.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an array of [POINT](../vs140/point-structure.md) structures that contain the set of points to be converted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the number of **POINT** structures in the array pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ClientToScreen](../vs140/cwnd--clienttoscreen.md)   
 [CWnd::ScreenToClient](../vs140/cwnd--screentoclient.md)   
 [MapWindowPoints](http://msdn.microsoft.com/library/windows/desktop/dd145046)
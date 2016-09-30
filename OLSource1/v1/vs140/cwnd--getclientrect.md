---
title: "CWnd::GetClientRect"
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
  - "CWnd.GetClientRect"
  - "CWnd::GetClientRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClientRect method"
ms.assetid: fb1284b9-9f58-482a-ae5f-52e263d956cf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetClientRect
Copies the client coordinates of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> client area into the structure pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to receive the client coordinates. The **left** and **top** members will be 0. The **right** and **bottom** members will contain the width and height of the window.  
  
## Remarks  
 The client coordinates specify the upper-left and lower-right corners of the client area. Since client coordinates are relative to the upper-left corners of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> client area, the coordinates of the upper-left corner are (0,0).  
  
## Example  
 See the example for [CWnd::IsIconic](../vs140/cwnd--isiconic.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetWindowRect](../vs140/cwnd--getwindowrect.md)   
 [GetClientRect](http://msdn.microsoft.com/library/windows/desktop/ms633503)
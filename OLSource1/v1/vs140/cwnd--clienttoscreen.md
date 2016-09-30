---
title: "CWnd::ClientToScreen"
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
  - "CWnd.ClientToScreen"
  - "CWnd::ClientToScreen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd class, coordinate mapping functions"
  - "ClientToScreen method"
ms.assetid: 0c4a4b3b-48f2-4792-b94a-f34c6f45aee6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ClientToScreen
Converts the client coordinates of a given point or rectangle on the display to screen coordinates.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a [POINT](../vs140/point-structure.md) structure or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that contains the client coordinates to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that contains the client coordinates to be converted.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function uses the client coordinates in the **POINT** or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure or the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to compute new screen coordinates; it then replaces the coordinates in the structure with the new coordinates. The new screen coordinates are relative to the upper-left corner of the system display.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member function assumes that the given point or rectangle is in client coordinates.  
  
## Example  
 [!code[NVC_MFCWindowing#78](../vs140/codesnippet/CPP/cwnd--clienttoscreen_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ScreenToClient](../vs140/cwnd--screentoclient.md)   
 [ClientToScreen](http://msdn.microsoft.com/library/windows/desktop/dd183434)
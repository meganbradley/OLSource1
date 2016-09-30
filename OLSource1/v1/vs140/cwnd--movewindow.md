---
title: "CWnd::MoveWindow"
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
  - "CWnd::MoveWindow"
  - "CWnd.MoveWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveWindow method"
ms.assetid: 1b644e6d-ed92-421f-b8e6-ab95d35f8e51
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::MoveWindow
Changes the position and dimensions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the new position of the left side of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 *y*  
 Specifies the new position of the top of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the new width of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the new height of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies whether <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is to be repainted. If **TRUE**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> receives a [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message in its [OnPaint](../vs140/cwnd--onpaint.md) message handler as usual. If this parameter is **FALSE**, no repainting of any kind occurs. This applies to the client area, to the nonclient area (including the title and scroll bars), and to any part of the parent window uncovered as a result of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>'s move. When this parameter is **FALSE**, the application must explicitly invalidate or redraw any parts of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and parent window that must be redrawn.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The [CRect](../vs140/crect-class.md) object or [RECT](../vs140/rect-structure.md) structure that specifies the new size and position.  
  
## Remarks  
 For a top-level <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object, the *x* and *y* parameters are relative to the upper-left corner of the screen. For a child <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object, they are relative to the upper-left corner of the parent window's client area.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function sends the [WM_GETMINMAXINFO](../vs140/cwnd--ongetminmaxinfo.md) message. Handling this message gives <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> the opportunity to modify the default values for the largest and smallest possible windows. If the parameters to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> member function exceed these values, the values can be replaced by the minimum or maximum values in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> handler.  
  
## Example  
 See the example for [CWnd::ClientToScreen](../vs140/cwnd--clienttoscreen.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md)   
 [CWnd::OnGetMinMaxInfo](../vs140/cwnd--ongetminmaxinfo.md)   
 [MoveWindow](http://msdn.microsoft.com/library/windows/desktop/ms633534)
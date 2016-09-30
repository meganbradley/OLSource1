---
title: "CWnd::OnContextMenu"
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
  - "CWnd.OnContextMenu"
  - "OnContextMenu"
  - "CWnd::OnContextMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnContextMenu method"
ms.assetid: 0fa9df29-0c6f-411b-af7f-fac7a1af337e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnContextMenu
Called by the framework when the user has clicked the right mouse button (right clicked) in the window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the window in which the user right clicked the mouse. This can be a child window of the window receiving the message. For more information about processing this message, see the Remarks section.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Position of the cursor, in screen coordinates, at the time of the mouse click.  
  
## Remarks  
 You can process this message by displaying a context menu using the [TrackPopupMenu](../vs140/cmenu--trackpopupmenu.md).  
  
 If you do not display a context menu you should pass this message onto the [DefWindowProc](../vs140/cwnd--defwindowproc.md) function. If your window is a child window, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> sends the message to the parent. Otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> displays a default context menu if the specified position is in the window's caption.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
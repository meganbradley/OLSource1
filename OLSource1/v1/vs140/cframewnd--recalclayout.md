---
title: "CFrameWnd::RecalcLayout"
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
  - "CFrameWnd::RecalcLayout"
  - "CFrameWnd.RecalcLayout"
  - "RecalcLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RecalcLayout method"
  - "CFrameWnd class, operations"
ms.assetid: a04f3354-a6fb-4b33-998f-b92946081a04
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::RecalcLayout
Called by the framework when the standard control bars are toggled on or off or when the frame window is resized.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Determines whether the active in-place item for the frame window receives notification of the layout change. If **TRUE**, the item is notified; otherwise **FALSE**.  
  
## Remarks  
 The default implementation of this member function calls the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to reposition all the control bars in the frame as well as in the main client window (usually a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or **MDICLIENT**).  
  
 Override this member function to control the appearance and behavior of control bars after the layout of the frame window has changed. For example, call it when you turn control bars on or off or add another control bar.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::RepositionBars](../vs140/cwnd--repositionbars.md)
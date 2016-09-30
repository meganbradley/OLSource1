---
title: "CMDIFrameWndEx::PaneFromPoint"
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
  - "PaneFromPoint"
  - "CMDIFrameWndEx.PaneFromPoint"
  - "CMDIFrameWndEx::PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: f5c3864b-d569-4ed0-9d45-bd22cc552691
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::PaneFromPoint
Returns the docking pane that contains the specified point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The point (in screen coordinates).  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The window rectangle of each checked pane is enlarged in all directions by this value.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter is ignored.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If non-<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the method iterates over only the panes of the specified type.  
  
 [out] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 If a pane is found, this parameter will specify which side of the pane is closest to the specified point.  
  
## Return Value  
 A pointer to a docking pane, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if no control contains the point specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The call is redirected to the [CDockingManager Class](../vs140/cdockingmanager-class.md). See [CDockingManager::PaneFromPoint](../vs140/cdockingmanager--panefrompoint.md) for more information.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
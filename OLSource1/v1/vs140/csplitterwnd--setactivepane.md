---
title: "CSplitterWnd::SetActivePane"
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
  - "SetActivePane"
  - "CSplitterWnd.SetActivePane"
  - "CSplitterWnd::SetActivePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, operations"
  - "panes, splitter window"
  - "SetActivePane method"
  - "splitter windows, active panes"
ms.assetid: 70697a82-8d57-4612-a5bd-6267a2c9da15
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::SetActivePane
Sets a pane to be the active one in the frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is **NULL**, specifies the row in the pane that will be active.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **NULL**, specifies the column in the pane that will be active.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. If **NULL**, the pane specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is set active. If not **NULL**, specifies the pane that is set active.  
  
## Remarks  
 This member function is called by the framework to set a pane as active when the user changes the focus to a pane within the frame window. You can explicitly call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to change the focus to the specified view.  
  
 Specify pane by providing either row and column, **or** by providing <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::GetActivePane](../vs140/csplitterwnd--getactivepane.md)   
 [CSplitterWnd::GetPane](../vs140/csplitterwnd--getpane.md)   
 [CFrameWnd::SetActiveView](../vs140/cframewnd--setactiveview.md)
---
title: "CSplitterWnd::GetActivePane"
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
  - "GetActivePane"
  - "CSplitterWnd::GetActivePane"
  - "CSplitterWnd.GetActivePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActivePane method"
  - "CSplitterWnd class, overridables"
  - "splitter windows, panes"
ms.assetid: 7f4f3954-c6f8-4063-941c-400137889462
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::GetActivePane
Determines the active pane from the focus or active view in the frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an **int** to retrieve the row number of the active pane.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an **int** to retrieve the column number of the active pane.  
  
## Return Value  
 Pointer to the active pane. **NULL** if no active pane exists.  
  
## Remarks  
 This member function is called by the framework to determine the active pane in a splitter window. Override to require an action by the user before getting the active pane.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::SetActivePane](../vs140/csplitterwnd--setactivepane.md)   
 [CFrameWnd::GetActiveView](../vs140/cframewnd--getactiveview.md)   
 [CWnd::GetParentFrame](../vs140/cwnd--getparentframe.md)   
 [CWnd::GetFocus](../vs140/cwnd--getfocus.md)
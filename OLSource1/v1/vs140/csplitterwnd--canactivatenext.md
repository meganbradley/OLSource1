---
title: "CSplitterWnd::CanActivateNext"
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
  - "CSplitterWnd::CanActivateNext"
  - "CSplitterWnd.CanActivateNext"
  - "CanActivateNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, overridables"
  - "CanActivateNext method"
  - "splitter windows, overridables"
  - "splitter windows, active panes"
ms.assetid: 0ffd9d1d-0851-428d-a880-3f06f2314a79
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::CanActivateNext
Called by the framework to check to see if the Next Pane or Previous Pane command is currently possible.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates which window to activate. **TRUE** for previous; **FALSE** for next.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function is a high level command that is used by the [CView](../vs140/cview-class.md) class to delegate to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> implementation.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::ActivateNext](../vs140/csplitterwnd--activatenext.md)   
 [CSplitterWnd::SetActivePane](../vs140/csplitterwnd--setactivepane.md)
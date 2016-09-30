---
title: "CPane::DockToFrameWindow"
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
  - "CPane::DockToFrameWindow"
  - "DockToFrameWindow"
  - "CPane.DockToFrameWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockToFrameWindow method"
ms.assetid: 36297639-ed93-4450-ba44-9677f684ed71
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::DockToFrameWindow
Docks a dockable pane to a frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The side of the parent frame that you want to dock the pane to.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The specified size.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and there are other dockable panes at the side that are specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the pane is docked outside the other panes, closer to the edge of the parent frame. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the pane is docked closer to the center of the client area.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if a pane divider ([CPaneDivider Class](../vs140/cpanedivider-class.md)) cannot be created; otherwise, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockablePane::DockToFrameWindow](assetId:///c2f2024b-ed6d-4d52-882f-425352f836c5)
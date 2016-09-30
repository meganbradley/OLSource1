---
title: "CBasePane::DockToFrameWindow"
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
  - "DockToFrameWindow"
  - "CBasePane::DockToFrameWindow"
  - "CBasePane.DockToFrameWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockToFrameWindow method"
ms.assetid: b16810fc-d4a8-4e88-bf4f-68d41d6f94b1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::DockToFrameWindow
Docks a dockable pane to a frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The side of the parent frame that you want to dock the pane to.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The desired size.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and there are other dockable panes at the side specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the pane is docked outside the other panes, closer to the edge of the parent frame. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the pane is docked closer to the center of the client area.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method fails if a pane divider ([CPaneDivider Class](../vs140/cpanedivider-class.md)) cannot be created. Otherwise, it always returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
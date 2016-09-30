---
title: "CPaneFrameWnd::PaneFromPoint"
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
  - "CPaneFrameWnd.PaneFromPoint"
  - "CPaneFrameWnd::PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: 68780d0b-3229-40e7-9613-d39b4cfc16ed
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::PaneFromPoint
Returns a pane if it contains a user-supplied point inside a mini-frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The point that the user clicked, in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to specify that only visible panes should be returned; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 The pane that the user clicked, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if no pane exists at that location.  
  
## Remarks  
 Call this method to obtain a pane that contains the given point.  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
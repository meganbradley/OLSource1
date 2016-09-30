---
title: "CDockablePane::DrawCaption"
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
  - "CDockablePane.DrawCaption"
  - "DrawCaption"
  - "CDockablePane::DrawCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawCaption method"
ms.assetid: 1ec46d53-dcb6-4aea-9d6f-69c762b0367b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::DrawCaption
Draws the caption (also called the gripper) of a docking pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Represents the device context used for drawing.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle of the pane's caption.  
  
## Remarks  
 The framework calls this method to draw the caption of a dockable pane.  
  
 Override this method in a derived class to customize the appearance of the caption.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
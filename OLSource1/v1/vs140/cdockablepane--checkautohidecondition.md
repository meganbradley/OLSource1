---
title: "CDockablePane::CheckAutoHideCondition"
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
  - "CDockablePane.CheckAutoHideCondition"
  - "CDockablePane::CheckAutoHideCondition"
  - "CheckAutoHideCondition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CheckAutoHideCondition method"
ms.assetid: 0e332d83-232e-4c14-8ed8-91b6585af83d
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CheckAutoHideCondition
Determines whether the docking pane is hidden (also known as autohide mode).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the hide condition is met; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework uses a timer to periodically check whether to hide an autohide dockable pane. The method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when the pane is not active, the pane is not being resized, and the mouse pointer is not over the pane.  
  
 If all the previous conditions are met, the framework calls [CDockablePane::Slide](../vs140/cdockablepane--slide.md) to hide the pane.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
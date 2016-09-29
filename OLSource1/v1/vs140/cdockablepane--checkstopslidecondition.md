---
title: "CDockablePane::CheckStopSlideCondition"
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
  - "CheckStopSlideCondition"
  - "CDockablePane.CheckStopSlideCondition"
  - "CDockablePane::CheckStopSlideCondition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CheckStopSlideCondition method"
ms.assetid: 8bfb36d0-b7a3-4dc0-89c3-9a3ba07c9632
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CheckStopSlideCondition
Determines when an autohide docking pane should stop sliding.  
  
## Syntax  
  
```  
virtual BOOL CheckStopSlideCondition(  
    BOOL bDirection   
);  
```  
  
#### Parameters  
 [in] `bDirection`  
 `TRUE` if the pane is visible; `FALSE` if the pane is hidden.  
  
## Return Value  
 `TRUE` if the stop condition is met; otherwise, `FALSE`.  
  
## Remarks  
 When a dockable pane is set to autohide mode, the framework uses sliding effects to show or hide the pane. The framework calls this function when the pane is sliding. `CheckStopSlideCondition` returns `TRUE` when the pane is fully visible or when it is fully hidden.  
  
 Override this method in a derived class to implement custom autohide effects.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockablePane::OnSlide](../vs140/cdockablepane--onslide.md)   
 [CDockablePane::Slide](../vs140/cdockablepane--slide.md)
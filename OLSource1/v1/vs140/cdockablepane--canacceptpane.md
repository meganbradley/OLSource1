---
title: "CDockablePane::CanAcceptPane"
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
  - "CanAcceptPane"
  - "CDockablePane.CanAcceptPane"
  - "CDockablePane::CanAcceptPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAcceptPane method"
ms.assetid: f0871133-f48e-49b7-be3b-6919ac7a8178
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CanAcceptPane
Determines whether another pane can be docked to the current pane.  
  
## Syntax  
  
```  
virtual BOOL CanAcceptPane(  
    const CBasePane* pBar  
) const;  
```  
  
#### Parameters  
 [in] `pBar`  
 Specifies the pane to dock to the current pane.  
  
## Return Value  
 `TRUE` if the specified pane can be docked to this pane; otherwise, `FALSE`.  
  
## Remarks  
 The framework calls this method before a pane is docked to the current pane.  
  
 Override this function in a derived class to enable or disable docking to a specific pane.  
  
 By default, this method returns `TRUE` if either `pBar` or its parent is of type `CDockablePane`.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
---
title: "CDockablePane::SetLastPercentInPaneContainer"
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
  - "CDockablePane.SetLastPercentInPaneContainer"
  - "SetLastPercentInPaneContainer"
  - "CDockablePane::SetLastPercentInPaneContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLastPercentInPaneContainer method"
ms.assetid: b783cdae-833b-4f06-8dac-5c2243fe7c65
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::SetLastPercentInPaneContainer
Sets the percentage of space that a pane occupies in its container.  
  
## Syntax  
  
```  
void SetLastPercentInPaneContainer(  
   int n  
);  
```  
  
#### Parameters  
 [in] `n`  
 An `int` that specifies the percentage of space that the pane occupies in its container.  
  
## Remarks  
 The framework adjusts the pane to use the new value when the layout is recalculated.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
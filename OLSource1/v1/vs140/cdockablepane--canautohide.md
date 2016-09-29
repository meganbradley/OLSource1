---
title: "CDockablePane::CanAutoHide"
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
  - "CDockablePane::CanAutoHide"
  - "CanAutoHide"
  - "CDockablePane.CanAutoHide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAutoHide method"
ms.assetid: 27d253ef-77aa-4d66-bfc8-4df38d53670a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CanAutoHide
Determines whether the pane can auto-hide.  
  
## Syntax  
  
```  
virtual BOOL CanAutoHide() const;  
```  
  
## Return Value  
 `TRUE` if the pane can auto-hide; otherwise, `FALSE`.  
  
## Remarks  
 `CDockablePane::CanAutoHide` returns `FALSE` in any of the following situations:  
  
-   The pane has no parent.  
  
-   The docking manager does not allow panes to auto-hide.  
  
-   The pane is not docked.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
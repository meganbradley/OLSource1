---
title: "CDockablePane::IsResizable"
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
  - "CDockablePane.IsResizable"
  - "IsResizable"
  - "CDockablePane::IsResizable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsResizable method"
ms.assetid: da1d4576-e71d-46b7-af21-6181ea1d2c62
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::IsResizable
Specifies whether the pane is resizable.  
  
## Syntax  
  
```  
virtual BOOL IsResizable() const;  
```  
  
## Return Value  
 `TRUE` if the pane is resizable; otherwise, `FALSE`.  
  
## Remarks  
 By default, dockable panes are resizable. To prevent resizing, override this method in a derived class and return `FALSE`. Note that a `FALSE` value leads to a failed `ASSERT` in [CPane::DockPane](../vs140/cpane--dockpane.md). Use [CDockingManager::AddPane](../vs140/cdockingmanager--addpane.md) instead to dock a pane within a parent frame.  
  
 Panes that cannot be resized can neither float nor enter auto-hide mode and are always located at the outer edge of the parent frame.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
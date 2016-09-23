---
title: "CDockablePane::IsAutohideAllEnabled"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDockablePane.IsAutohideAllEnabled
  - IsAutohideAllEnabled
  - CDockablePane::IsAutohideAllEnabled
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsAutohideAllEnabled method
ms.assetid: b90a2df9-1dab-46a4-be3f-9278d39089db
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePane::IsAutohideAllEnabled
Indicates whether the docking pane and all other panes in the container can be switched to autohide mode.  
  
## Syntax  
  
```  
virtual BOOL IsAutohideAllEnabled() const;  
```  
  
## Return Value  
 `TRUE` if the dockable pane, and all other panes in the container, can be switched to autohide mode; otherwise, `FALSE`.  
  
## Remarks  
 A user enables autohide mode by clicking the docking pin button while holding the **Ctrl** key  
  
 To enable or disable this behavior, call the [CDockablePane::EnableAutohideAll](../vs140/cdockablepane--enableautohideall.md) method.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
---
title: "CPane::IsInFloatingMultiPaneFrameWnd"
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
  - "CPane::IsInFloatingMultiPaneFrameWnd"
  - "IsInFloatingMultiPaneFrameWnd"
  - "CPane.IsInFloatingMultiPaneFrameWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsInFloatingMultiPaneFrameWnd method"
ms.assetid: 9bd7068c-4130-4fea-a334-18fe975df5b5
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::IsInFloatingMultiPaneFrameWnd
Specifies whether the pane is in a multi-pane frame window ([CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)).  
  
## Syntax  
  
```  
virtual BOOL IsInFloatingMultiPaneFrameWnd() const;  
```  
  
## Return Value  
 `TRUE` if the pane is in a multi-pane frame window; otherwise, `FALSE`.  
  
## Remarks  
 Only dockable panes can float in a multi-pane frame window. Therefore, `CPane::IsInFloatingMultiPaneFrameWnd` always returns `FALSE`.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)   
 [CDockablePane::IsInFloatingMultiPaneFrameWnd](../vs140/cdockablepane--isinfloatingmultipaneframewnd.md)
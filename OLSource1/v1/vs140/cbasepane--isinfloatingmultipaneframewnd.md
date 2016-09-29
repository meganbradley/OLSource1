---
title: "CBasePane::IsInFloatingMultiPaneFrameWnd"
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
  - "IsInFloatingMultiPaneFrameWnd"
  - "CBasePane::IsInFloatingMultiPaneFrameWnd"
  - "CBasePane.IsInFloatingMultiPaneFrameWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsInFloatingMultiPaneFrameWnd method"
ms.assetid: 1b6a6aec-9384-4efc-b0f4-10e16f2086e3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::IsInFloatingMultiPaneFrameWnd
Specifies whether the pane is in a multi-pane frame window ([CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)).  
  
## Syntax  
  
```  
virtual BOOL IsInFloatingMultiPaneFrameWnd() const;  
```  
  
## Return Value  
 `TRUE` if the pane is in a multi-pane frame window; otherwise, `FALSE`.  
  
## Remarks  
 Only dockable panes can float in a multi-pane frame window. Therefore, `CBasePane::IsInFloatingMultiPaneFrameWnd` always returns `FALSE`.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
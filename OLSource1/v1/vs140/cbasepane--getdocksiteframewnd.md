---
title: "CBasePane::GetDockSiteFrameWnd"
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
  - "CBasePane.GetDockSiteFrameWnd"
  - "CBasePane::GetDockSiteFrameWnd"
  - "GetDockSiteFrameWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDockSiteFrameWnd method"
ms.assetid: f7c7f794-2e5a-43b2-b78a-87d69443e4fb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetDockSiteFrameWnd
Returns a pointer to the [CDockingPanesRow](../vs140/cdockingpanesrow-class.md)object where the pane is docked.  
  
## Syntax  
  
```  
virtual CWnd* GetDockSiteFrameWnd() const;  
```  
  
## Return Value  
 A pointer to the dock site of the pane.  
  
## Remarks  
 Call this method to retrieve a pointer to the dock site of the pane. The dock site can be either a main frame window if the pane is docked to the main frame, or a mini-frame window if the pane is floating.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
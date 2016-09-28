---
title: "CBasePane::OnRemoveFromMiniFrame"
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
  - "CBasePane::OnRemoveFromMiniFrame"
  - "CBasePane.OnRemoveFromMiniFrame"
  - "OnRemoveFromMiniFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRemoveFromMiniFrame method"
ms.assetid: 60a7e045-b84a-4730-8bc2-4c99875820c9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::OnRemoveFromMiniFrame
Called by the framework when a pane is removed from its parent mini frame window.  
  
## Syntax  
  
```  
virtual void OnRemoveFromMiniFrame(  
   CPaneFrameWnd* pMiniFrame  
);  
```  
  
#### Parameters  
 [in] `pMiniFrame`  
 A pointer to a mini-frame window from which the pane is removed.  
  
## Remarks  
 The framework calls this method when a pane is removed from its parent mini-frame window (as a result of docking, for example).  
  
 The default implementation does nothing.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
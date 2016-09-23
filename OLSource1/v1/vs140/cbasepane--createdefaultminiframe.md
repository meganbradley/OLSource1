---
title: "CBasePane::CreateDefaultMiniframe"
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
  - CBasePane.CreateDefaultMiniframe
  - CreateDefaultMiniframe
  - CBasePane::CreateDefaultMiniframe
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateDefaultMiniframe method
ms.assetid: 14d36413-16b5-4b5f-bb28-6bf01cd24353
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBasePane::CreateDefaultMiniframe
If the pane can float, this method creates a mini-frame window for it.  
  
## Syntax  
  
```  
virtual CPaneFrameWnd* CreateDefaultMiniframe(  
   CRect rectInitial   
);  
```  
  
#### Parameters  
 [in] `rectInitial`  
 Specifies the initial coordinates of the mini-frame window.  
  
## Return Value  
 A pointer to the new mini-frame window or `NULL` if the creation failed.  
  
## Remarks  
 The framework calls this method when a pane switches to a floating state. The method creates a mini-frame window and attaches the pane to this window.  
  
 The default implementation returns `NULL`.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)
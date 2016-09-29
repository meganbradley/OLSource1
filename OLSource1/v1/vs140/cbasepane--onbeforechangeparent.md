---
title: "CBasePane::OnBeforeChangeParent"
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
  - "OnBeforeChangeParent"
  - "CBasePane::OnBeforeChangeParent"
  - "CBasePane.OnBeforeChangeParent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnBeforeChangeParent method"
ms.assetid: 6b10a2b8-48ed-4b45-90fb-8432ddd87021
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::OnBeforeChangeParent
Called by the framework just before the pane changes its parent window.  
  
## Syntax  
  
```  
virtual void OnBeforeChangeParent(  
   CWnd* pWndNewParent,  
   BOOL bDelay=FALSE  
);  
```  
  
#### Parameters  
 [in] `pWndNewParent`  
 A pointer to a new parent window.  
  
 [in] `bDelay`  
 Specifies whether layout adjustments must be delayed.  
  
## Remarks  
 The framework calls this method just before the pane's parent changes, usually because of a docking, floating, or auto-hide operation.  
  
 The default implementation does nothing.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
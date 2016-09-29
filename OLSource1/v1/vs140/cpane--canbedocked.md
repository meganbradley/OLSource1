---
title: "CPane::CanBeDocked"
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
  - "CPane.CanBeDocked"
  - "CanBeDocked"
  - "CPane::CanBeDocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeDocked method"
ms.assetid: 3b4fe7fb-0571-488a-93ac-fd4b5c0a0d51
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::CanBeDocked
Determines if the pane can be docked at the specified base pane.  
  
## Syntax  
  
```  
virtual BOOL CanBeDocked(  
    CBasePane* pDockBar   
) const;  
```  
  
#### Parameters  
 [in] `pDockBar`  
 Specifies the pane where this pane is to be docked.  
  
## Return Value  
 `TRUE` if this pane can be docked at the specified docking pane; otherwise, `FALSE`.  
  
## Remarks  
 This method is usually called by the framework to determine whether a pane can be docked at the specified docking pane. To determine whether the pane can be docked, the method evaluates the pane's currently enabled docking alignment.  
  
 You enable docking to the various sides of the frame window by calling [CBasePane::EnableDocking](../vs140/cbasepane--enabledocking.md).  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
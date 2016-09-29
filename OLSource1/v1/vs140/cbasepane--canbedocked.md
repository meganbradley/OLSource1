---
title: "CBasePane::CanBeDocked"
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
  - "CanBeDocked"
  - "CBasePane::CanBeDocked"
  - "CBasePane.CanBeDocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeDocked method"
ms.assetid: e1cde857-9c55-41ce-bc17-ff314dcb70c4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanBeDocked
Determines whether the pane can be docked to another pane.  
  
## Syntax  
  
```  
virtual BOOL CanBeDocked(  
   CBasePane* pDockBar    
) const;  
```  
  
#### Parameters  
 [in] `pDockBar`  
 A pointer to another pane.  
  
## Return Value  
 `TRUE` if this pane can be docked to another pane; otherwise `FALSE`.  
  
## Remarks  
 The framework calls this method before it docks the pane specified by `pDockBar` to the current pane.  
  
 Use this method and the  [CBasePane::CanAcceptPane](../vs140/cbasepane--canacceptpane.md) method to control how panes dock to other panes in your application.  
  
 The default implementation returns `FALSE`.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
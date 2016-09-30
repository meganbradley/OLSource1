---
title: "CBasePane::IsAutoHideMode"
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
  - "CBasePane::IsAutoHideMode"
  - "CBasePane.IsAutoHideMode"
  - "IsAutoHideMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAutoHideMode method"
ms.assetid: 93509221-02fe-4993-ae62-e0b3b4cbbf98
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::IsAutoHideMode
Determines whether a pane is in auto-hide mode.  
  
## Syntax  
  
```  
virtual BOOL IsAutoHideMode() const;  
```  
  
## Return Value  
 `TRUE` if the pane is in auto-hide mode; otherwise, `FALSE`.  
  
## Remarks  
 Base panes cannot auto-hide. This method always returns `FALSE`.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
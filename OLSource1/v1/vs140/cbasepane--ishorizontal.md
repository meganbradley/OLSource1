---
title: "CBasePane::IsHorizontal"
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
  - "IsHorizontal"
  - "CBasePane::IsHorizontal"
  - "CBasePane.IsHorizontal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsHorizontal method"
ms.assetid: 03d2811d-af94-4d78-bc8b-02c3a2f81b57
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::IsHorizontal
Determines whether the pane is docked horizontally.  
  
## Syntax  
  
```  
virtual BOOL IsHorizontal() const;  
```  
  
## Return Value  
 `TRUE` if the pane is docked horizontally; otherwise `FALSE`.  
  
## Remarks  
 The default implementation checks the current docking alignment for `CBRS_ORIENT_HORZ`.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
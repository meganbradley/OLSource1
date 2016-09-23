---
title: "CBasePane::CanBeResized"
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
  - CanBeResized
  - CBasePane::CanBeResized
  - CBasePane.CanBeResized
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanBeResized method
ms.assetid: 15b65ab4-9332-4f00-bb8b-03f42f56b5ec
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBasePane::CanBeResized
Determines whether the pane can be resized.  
  
## Syntax  
  
```  
virtual BOOL CanBeResized() const;  
```  
  
## Return Value  
 `TRUE` if the pane can be resized; otherwise, `FALSE`.  
  
## Remarks  
 This method checks for the `AFX_CBRS_RESIZE` flag, which is specified by default in `CBasePane::OnCreate`. If this flag is not specified, the docking manager flags the pane internally as immovable instead of docking it.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
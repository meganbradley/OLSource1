---
title: "CPane::IsLeftOf"
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
  - "CPane::IsLeftOf"
  - "CPane.IsLeftOf"
  - "IsLeftOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsLeftOf method"
ms.assetid: e679baf2-eeee-4aca-a107-dc0d47bcc1d2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::IsLeftOf
Determines whether the pane is left of (or above) the specified rectangle.  
  
## Syntax  
  
```  
bool IsLeftOf(  
   CRect rect,  
   bool bWindowRect = true  
) const;  
```  
  
#### Parameters  
 [in] `rect`  
 A `CRect` object that is used for comparison.  
  
 [in] `bWindowRect`  
 If `TRUE`, `rect` is assumed to contain screen coordinates; if `FALSE`, `rect` is assumed to contain client coordinates.  
  
## Return Value  
  
## Remarks  
 If the pane is docked horizontally, this method checks whether its location is left of `rect`. Otherwise, this method checks whether the location is above `rect`.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
---
title: "CBasePane::PaneFromPoint"
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
  - "CBasePane::PaneFromPoint"
  - "PaneFromPoint"
  - "CBasePane.PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: a7f4ea80-b395-4187-9286-049f708672a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::PaneFromPoint
Returns the pane that contains the given point.  
  
## Syntax  
  
```  
CBasePane* PaneFromPoint(  
   CPoint point,  
   int nSensitivity,  
   bool bExactBar = false,  
   CRuntimeClass* pRTCBarType = NULL  
) const;  
```  
  
#### Parameters  
 [in] `point`  
 Specifies the point, in screen coordinates, to check.  
  
 [in] `nSensitivity`  
 Increase the search area by this amount. A pane will satisfy the search criteria if the given point falls in the increased area.  
  
 [in] `bExactBar`  
 `TRUE` to ignore the `nSensitivity` parameter; otherwise, `FALSE`.  
  
 [in] `pRTCBarType`  
 If not `NULL`, the method searches only panes of the specified type.  
  
## Return Value  
 The `CBasePane`-derived object that contains the given point, or `NULL` if no pane was found.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
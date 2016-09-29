---
title: "CDockingManager::PaneFromPoint"
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
  - "PaneFromPoint"
  - "CDockingManager.PaneFromPoint"
  - "CDockingManager::PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: f1dec025-30b2-4fea-9106-7b7357a7f0f1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::PaneFromPoint
Returns the pane that contains the given point.  
  
## Syntax  
  
```  
virtual CBasePane* PaneFromPoint(  
    CPoint point,  
    int nSensitivity,  
    bool bExactBar = false,  
    CRuntimeClass* pRTCBarType = NULL,  
    BOOL bCheckVisibility = FALSE,  
    const CBasePane* pBarToIgnore = NULL  
) const;  
virtual CBasePane* PaneFromPoint(  
    CPoint point,  
    int nSensitivity,  
    DWORD& dwAlignment,  
    CRuntimeClass* pRTCBarType = NULL,  
    const CBasePane* pBarToIgnore = NULL  
) const;  
```  
  
#### Parameters  
 [in] `point`  
 Specifies the point, in screen coordinates, to check.  
  
 [in] `nSensitivity`  
 The value to inflate the window rectangle of each checked pane. A pane satisfies the search criteria if the given point is in this inflated region.  
  
 [in] `bExactBar`  
 `TRUE` to ignore the `nSensitivity` parameter; otherwise, `FALSE`.  
  
 [in] `pRTCBarType`  
 If not `NULL`, the method searches only the panes of the specified type.  
  
 [in] `bCheckVisibility`  
 `TRUE` to check only visible panes; otherwise, `FALSE`.  
  
 [out] `dwAlignment`  
 If a pane is found at the specified point, this parameter contains the side of the pane that was closest to the specified point. For more information, see the Remarks section.  
  
 [in] `pBarToIgnore`  
 If not `NULL`, the method ignores panes specified by this parameter.  
  
## Return Value  
 The [CBasePane](../vs140/cbasepane-class.md)-derived object that contains the given point, or `NULL` if no pane was found.  
  
## Remarks  
 When the function returns and a pane was found, `dwAlignment` contains the alignment of the specified point. For example, if the point was closest to the top of the pane, `dwAlignment` is set to `CBRS_ALIGN_TOP`.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
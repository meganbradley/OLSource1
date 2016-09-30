---
title: "CSmartDockingInfo::m_uiMarkerBmpResID"
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
  - "CSmartDockingInfo.m_uiMarkerBmpResID"
  - "CSmartDockingInfo::m_uiMarkerBmpResID"
  - "m_uiMarkerBmpResID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_uiMarkerBmpResID"
  - "CSmartDockingInfo class, data members"
ms.assetid: 7e3f9540-1d04-4fbd-baee-1e92bee315fb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSmartDockingInfo::m_uiMarkerBmpResID
Defines the resource IDs of the bitmaps that are used for non-highlighted custom smart docking markers.  
  
## Syntax  
  
```  
UINT m_uiMarkerBmpResID[AFX_SD_MARKERS_NUM];  
```  
  
## Remarks  
 Fill this array with the resource IDs of the bitmaps representing the smart docking markers. `AFX_SD_MARKERS_NUM` is currently defined as 5. You fill the array as follows:  
  
 `params.m_uiMarkerBmpResID[0] = IDB_MARKER_LEFT;`  
  
 `params.m_uiMarkerBmpResID[1] = IDB_MARKER_RIGHT;`  
  
 `params.m_uiMarkerBmpResID[2] = IDB_MARKER_TOP;`  
  
 `params.m_uiMarkerBmpResID[3] = IDB_MARKER_BOTTOM;`  
  
 `params.m_uiMarkerBmpResID[4] = IDB_MARKER_CENTER;`  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CSmartDockingInfo Class](../vs140/csmartdockinginfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
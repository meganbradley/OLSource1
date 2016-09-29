---
title: "CDockingManager::IsPointNearDockSite"
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
  - "CDockingManager::IsPointNearDockSite"
  - "CDockingManager.IsPointNearDockSite"
  - "IsPointNearDockSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPointNearDockSite method"
ms.assetid: 8b3013f9-e080-4d1f-8c0b-62d72da808a0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::IsPointNearDockSite
Determines whether a specified point is near the dock site.  
  
## Syntax  
  
```  
BOOL IsPointNearDockSite(  
   CPoint point,  
   DWORD& dwBarAlignment,  
   BOOL& bOuterEdge  
) const;  
```  
  
#### Parameters  
 [in] `point`  
 The specified point.  
  
 [out] `dwBarAlignment`  
 Specifies which edge the point is near. Possible values are `CBRS_ALIGN_LEFT`, `CBRS_ALIGN_RIGHT`, `CBRS_ALIGN_TOP`, and `CBRS_ALIGN_BOTTOM`.  
  
 [out] `bOuterEdge`  
 `TRUE` if the point is near the outer border of the dock site; `FALSE` otherwise.  
  
## Return Value  
 `TRUE` if the point is near the dock site; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
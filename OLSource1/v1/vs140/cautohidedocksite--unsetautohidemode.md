---
title: "CAutoHideDockSite::UnSetAutoHideMode"
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
  - "CAutoHideDockSite.UnSetAutoHideMode"
  - "UnSetAutoHideMode"
  - "CAutoHideDockSite::UnSetAutoHideMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnSetAutoHideMode method"
ms.assetid: f2ff4e37-e066-4ca5-8b73-303b4dbece3b
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoHideDockSite::UnSetAutoHideMode
Calls [CMFCAutoHideBar::UnSetAutoHideMode](../vs140/cmfcautohidebar--unsetautohidemode.md) for objects on the dock site.  
  
## Syntax  
  
```  
void UnSetAutoHideMode(  
   CMFCAutoHideBar* pAutoHideToolbar  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pAutoHideToolbar`|A pointer to a [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md) object pane located on the [CAutoHideDockSite](../vs140/cautohidedocksite-class.md).|  
  
## Remarks  
 This method searches for the row that contains `pAutoHideToolbar`. It calls `CMFCAutoHideBar.UnSetAutoHideMode` for all the `CMFCAutoHideBar` objects on that row. If `pAutoHideToolbar` is not found or it is `NULL`, this method calls `CMFCAutoHideBar.UnSetAutoHideMode` for all the `CMFCAutoHideBar` objects on the `CAutoHideDockSite`.  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
## See Also  
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
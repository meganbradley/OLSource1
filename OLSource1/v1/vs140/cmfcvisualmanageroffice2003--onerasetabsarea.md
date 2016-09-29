---
title: "CMFCVisualManagerOffice2003::OnEraseTabsArea"
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
  - "CMFCVisualManagerOffice2003::OnEraseTabsArea"
  - "OnEraseTabsArea"
  - "CMFCVisualManagerOffice2003.OnEraseTabsArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEraseTabsArea method"
ms.assetid: 56af55cf-d73d-4d97-9892-8d6b4a28e6fa
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnEraseTabsArea
The framework calls this method when it erases the tab area of a tab window.  
  
## Syntax  
  
```  
virtual void OnEraseTabsArea(  
   CDC* pDC,  
   CRect rect,  
   const CMFCBaseTabCtrl* pTabWnd  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the tab area.  
  
 [in] `pTabWnd`  
 A pointer to a tab window. The framework erases the tab area for the specified tab window.  
  
## Remarks  
 This function is called by the framework when a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object processes a `WM_PAINT` message and erases the tab area.  
  
 Override this method in a derived visual manager to customize the appearance of tabs.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
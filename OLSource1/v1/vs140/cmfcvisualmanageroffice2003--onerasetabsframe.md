---
title: "CMFCVisualManagerOffice2003::OnEraseTabsFrame"
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
  - "CMFCVisualManagerOffice2003::OnEraseTabsFrame"
  - "CMFCVisualManagerOffice2003.OnEraseTabsFrame"
  - "OnEraseTabsFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEraseTabsFrame method"
ms.assetid: 37426f27-a7c7-455e-9f05-d3dcc8ac30b3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnEraseTabsFrame
The framework calls this method when it erases a frame on a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object.  
  
## Syntax  
  
```  
virtual BOOL OnEraseTabsFrame(  
   CDC* pDC,  
   CRect rect,  
   const CMFCBaseTabCtrl* pTabWnd  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the tab window.  
  
 [in] `pTabWnd`  
 A pointer to a tab window. The framework erases a frame for this [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md).  
  
## Return Value  
 `TRUE` if the method is successful or `FALSE` if not.  
  
## Remarks  
 This method fills the area indicated by `rect` with the background color of the active tab. It is called when a `CMFCBaseTabCtrl` object processes a `WM_PAINT` message and erases a tab frame.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
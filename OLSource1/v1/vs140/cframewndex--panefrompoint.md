---
title: "CFrameWndEx::PaneFromPoint"
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
  - "CFrameWndEx::PaneFromPoint"
  - "PaneFromPoint"
  - "CFrameWndEx.PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: a17cf0eb-9cc4-44ac-847b-43826b23f74e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::PaneFromPoint
Searches each pane for the given point.  
  
## Syntax  
  
```  
CBasePane* PaneFromPoint(  
   CPoint point,  
   int nSensitivity,  
   bool bExactBar,  
   CRuntimeClass* pRTCBarType  
) const;  
CBasePane* PaneFromPoint(  
   CPoint point,  
   int nSensitivity,  
   DWORD& dwAlignment,  
   CRuntimeClass* pRTCBarType  
) const;  
```  
  
#### Parameters  
 [in] `point`  
 The screen coordinates of the point to check.  
  
 [in] `nSensitivity`  
 Expand the bounding rectangle of each control bar by this amount when searching for point.  
  
 [in] `bExactBar`  
 `TRUE` to ignore the `nSensitivity` parameter; otherwise, `FALSE`.  
  
 [in] `pRTCBarType`  
 If not `NULL`, the method searches only the control bars of the specified type.  
  
 [out] `dwAlignment`  
 If successful, this parameter contains the side of the control bar that is closest to the specified point. Otherwise, this parameter is not initialized.  
  
## Return Value  
 A pointer to a control bar that contains the `point`; `NULL` if no control is found.  
  
## Remarks  
 This method searches all the control bars in your application for a `point`.  
  
 Use `nSensitivity` to increase the size of the search area. Use `pRTCBarType` to restrict the types of control bars that the method searches.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
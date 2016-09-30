---
title: "CMDIChildWndEx::PaneFromPoint"
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
  - "CMDIChildWndEx.PaneFromPoint"
  - "CMDIChildWndEx::PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: c5c151b5-6682-4f4d-ac42-f7731a8759b9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::PaneFromPoint
Returns the pane that contains the given point.  
  
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
 Specifies the point, in screen coordinates, to check.  
  
 [in] `nSensitivity`  
 Increase the search area by this amount. A pane satisfies the search criteria if the given point falls in the increased area.  
  
 [in] `bExactBar`  
 `TRUE` to ignore the `nSensitivity` parameter; otherwise, `FALSE`.  
  
 [in] `pRTCBarType`  
 If not `NULL`, the method searches only panes of the specified type.  
  
 [in] `dwAlignment`  
 If a pane is found at the specified point, this parameter contains the side of the pane that was closest to the specified point. For more information, see the Remarks section.  
  
## Return Value  
 A pointer to the `CBasePane`-derived object that contains the given point, or `NULL` if no pane was found.  
  
## Remarks  
 Call this method to determine whether a pane contains the specified point according to the specified conditions such as runtime class and visibility.  
  
 When the function returns and a pane was found, `dwAlignment` contains the alignment of the specified point. For example, if the point was closest to the top of the pane, `dwAlignment` is set to `CBRS_ALIGN_TOP`.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
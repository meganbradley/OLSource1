---
title: "CMDIFrameWndEx::IsPointNearDockSite"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMDIFrameWndEx::IsPointNearDockSite
  - CMDIFrameWndEx.IsPointNearDockSite
  - IsPointNearDockSite
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsPointNearDockSite method
ms.assetid: df038768-da82-4be4-84bf-538ec11a2d8f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::IsPointNearDockSite
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
 The specified point in screen coordinates.  
  
 [in] `dwBarAlignment`  
 Specifies which edge the point is near. Possible values are `CBRS_ALIGN_LEFT`, `CBRS_ALIGN_RIGHT`, `CBRS_ALIGN_TOP`, and `CBRS_ALIGN_BOTTOM`  
  
 [in] `bOuterEdge`  
 `TRUE` if the point is near the outer border of the dock site; `FALSE` otherwise.  
  
## Return Value  
 `TRUE` if the point is near the dock site; otherwise `FALSE`.  
  
## Remarks  
 The point is near the dock site when it is within the sensitivity set in the docking manager. The default sensitivity is 15 pixels.  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
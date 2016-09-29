---
title: "CMDIChildWndEx::IsPointNearDockSite"
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
  - "CMDIChildWndEx.IsPointNearDockSite"
  - "CMDIChildWndEx::IsPointNearDockSite"
  - "IsPointNearDockSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPointNearDockSite method"
ms.assetid: 0e99b9ea-0dc1-44e1-8d1a-28ed15ecd97c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::IsPointNearDockSite
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
  
 [in] `dwBarAlignment`  
 Specifies which edge the point is near. Possible values are `CBRS_ALIGN_LEFT`, `CBRS_ALIGN_RIGHT`, `CBRS_ALIGN_TOP`, and `CBRS_ALIGN_BOTTOM`  
  
 [in] `bOuterEdge`  
 `TRUE` if the point is near the outer border of the dock site; `FALSE` otherwise.  
  
## Return Value  
 `TRUE` if the point is near the dock site; otherwise `FALSE`.  
  
## Remarks  
 The point is near the dock site when it is within the sensitivity set in the docking manager. The default sensitivity is 15 pixels.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
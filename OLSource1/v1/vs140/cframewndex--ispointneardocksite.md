---
title: "CFrameWndEx::IsPointNearDockSite"
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
  - "CFrameWndEx::IsPointNearDockSite"
  - "CFrameWndEx.IsPointNearDockSite"
  - "IsPointNearDockSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPointNearDockSite method"
ms.assetid: 72836492-a22c-48bc-aca5-5a6ec90f8189
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::IsPointNearDockSite
Determines whether the point is located in an alignment zone.  
  
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
 The position of the point.  
  
 [out] `dwBarAlignment`  
 Where the point is aligned. See the table in the Remarks section for possible values.  
  
 [out] `bOuterEdge`  
 `TRUE` if the point is located close to the frame border; `FALSE` if the point is located in a client area.  
  
## Return Value  
 `TRUE` if the point is located in an alignment zone; otherwise, `FALSE`.  
  
## Remarks  
 The following table lists the possible values for the `dwBarAlignment` parameter.  
  
 `CBRS_ALIGN_TOP`  
 Aligned to the top.  
  
 `CBRS_ALIGN_RIGHT`  
 Aligned to the right.  
  
 `CBRS_ALIGN_BOTTOM`  
 Aligned to the bottom.  
  
 `CBRS_ALIGN_LEFT`  
 Aligned to the left.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
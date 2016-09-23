---
title: "CDrawingManager::DrawGradientRing"
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
  - CDrawingManager.DrawGradientRing
  - DrawGradientRing
  - CDrawingManager::DrawGradientRing
dev_langs: 
  - C++
helpviewer_keywords: 
  - DrawGradientRing method
ms.assetid: a1944efa-e8cd-46aa-b534-354f125ae65e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDrawingManager::DrawGradientRing
Draws a ring and fills it with a color gradient.  
  
## Syntax  
  
```  
BOOL DrawGradientRing(  
   CRect rect,  
   COLORREF colorStart,  
   COLORREF colorFinish,  
   COLORREF colorBorder,  
   int nAngle,  
   int nWidth,  
   COLORREF clrFace = (COLORREF)-1  
);  
```  
  
#### Parameters  
 [in] `rect`  
 A [CRect](../vs140/crect-class.md) parameter that specifies the boundary for the gradient ring.  
  
 [in] `colorStart`  
 The first color for the gradient.  
  
 [in] `colorFinish`  
 The last color for the gradient.  
  
 [in] `colorBorder`  
 The color of the border.  
  
 [in] `nAngle`  
 A parameter that specifies the initial gradient drawing angle. This value should be between 0 and 360.  
  
 [in] `nWidth`  
 The width of the border for the ring.  
  
 [in] `clrFace`  
 The color of the interior of the ring.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The rectangle defined by `rect` must be at least 5 pixels wide and 5 pixels high.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
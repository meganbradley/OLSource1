---
title: "CRectTracker::CRectTracker"
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
  - CRectTracker.CRectTracker
  - CRectTracker::CRectTracker
dev_langs: 
  - C++
helpviewer_keywords: 
  - CRectTracker class, constructor
ms.assetid: f1587f91-cd3f-4795-acca-48cb87556d68
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRectTracker::CRectTracker
Creates and initializes a `CRectTracker` object.  
  
## Syntax  
  
```  
  
      CRectTracker( );  
CRectTracker(  
   LPCRECT lpSrcRect,  
   UINT nStyle   
);  
```  
  
#### Parameters  
 `lpSrcRect`  
 The coordinates of the rectangle object.  
  
 `nStyle`  
 Specifies the style of the `CRectTracker` object. The following styles are supported:  
  
-   **CRectTracker::solidLine** Use a solid line for the rectangle border.  
  
-   **CRectTracker::dottedLine** Use a dotted line for the rectangle border.  
  
-   **CRectTracker::hatchedBorder** Use a hatched pattern for the rectangle border.  
  
-   **CRectTracker::resizeInside** Resize handles located inside the rectangle.  
  
-   **CRectTracker::resizeOutside** Resize handles located outside the rectangle.  
  
-   **CRectTracker::hatchInside** Hatched pattern covers the entire rectangle.  
  
## Remarks  
 The default constructor initializes the `CRectTracker` object with the values from `lpSrcRect` and initializes other sizes to system defaults. If the object is created with no parameters, the `m_rect` and `m_nStyle` data members are uninitialized.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::CRect](../vs140/crect--crect.md)
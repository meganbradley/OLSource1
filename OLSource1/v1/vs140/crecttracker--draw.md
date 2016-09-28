---
title: "CRectTracker::Draw"
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
  - "CRectTracker.Draw"
  - "CRectTracker::Draw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drawing, rectangles"
  - "Draw method"
  - "CRectTracker class, operations"
ms.assetid: 00740987-a321-4484-a7c0-403380cb6188
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::Draw
Call this function to draw the rectangle's outer lines and inner region.  
  
## Syntax  
  
```  
  
      void Draw(  
   CDC* pDC   
) const;  
```  
  
#### Parameters  
 `pDC`  
 Pointer to the device context on which to draw.  
  
## Remarks  
 The style of the tracker determines how the drawing is done. See the constructor for `CRectTracker` for more information on the styles available.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::DrawTrackerRect](../vs140/crecttracker--drawtrackerrect.md)   
 [CRectTracker::CRectTracker](../vs140/crecttracker--crecttracker.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)
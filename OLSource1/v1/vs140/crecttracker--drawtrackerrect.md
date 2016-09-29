---
title: "CRectTracker::DrawTrackerRect"
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
  - "CRectTracker.DrawTrackerRect"
  - "CRectTracker::DrawTrackerRect"
  - "DrawTrackerRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drawing, rectangles"
  - "drawing, borders"
  - "DrawTrackerRect method"
  - "CRectTracker class, overridables"
ms.assetid: e5bf03f9-ce5d-4910-858e-5dbdbdc46bd7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::DrawTrackerRect
Called by the framework whenever the position of the tracker has changed while inside the `Track` or `TrackRubberBand` member function.  
  
## Syntax  
  
```  
  
      virtual void DrawTrackerRect(  
   LPCRECT lpRect,  
   CWnd* pWndClipTo,  
   CDC* pDC,  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `lpRect`  
 Pointer to the `RECT` that contains the rectangle to draw.  
  
 `pWndClipTo`  
 Pointer to the window to use in clipping the rectangle.  
  
 `pDC`  
 Pointer to the device context on which to draw.  
  
 `pWnd`  
 Pointer to the window on which the drawing will occur.  
  
## Remarks  
 The default implementation makes a call to `CDC::DrawFocusRect`, which draws a dotted rectangle.  
  
 Override this function to provide different feedback during the tracking operation.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::Track](../vs140/crecttracker--track.md)   
 [CRectTracker::TrackRubberBand](../vs140/crecttracker--trackrubberband.md)   
 [CDC::DrawFocusRect](../vs140/cdc--drawfocusrect.md)
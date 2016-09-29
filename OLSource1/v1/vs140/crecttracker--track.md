---
title: "CRectTracker::Track"
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
  - "CRectTracker::Track"
  - "CRectTracker.Track"
  - "Track"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "manipulating rectangles"
  - "Track method"
  - "CRectTracker class, operations"
  - "rectangles, manipulating"
ms.assetid: 66d27c9a-1b33-4845-9418-714ee0aaac29
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::Track
Call this function to display the user interface for resizing the rectangle.  
  
## Syntax  
  
```  
  
      BOOL Track(  
   CWnd* pWnd,  
   CPoint point,  
   BOOL bAllowInvert = FALSE,  
   CWnd* pWndClipTo = NULL   
);  
```  
  
#### Parameters  
 `pWnd`  
 The window object that contains the rectangle.  
  
 `point`  
 Device coordinates of the current mouse position relative to the client area.  
  
 `bAllowInvert`  
 If **TRUE**, the rectangle can be inverted along the x-axis or y-axis; otherwise **FALSE**.  
  
 `pWndClipTo`  
 The window that drawing operations will be clipped to. If **NULL**, `pWnd` is used as the clipping rectangle.  
  
## Return Value  
 If the ESC key is pressed, the tracking process is halted, the rectangle stored in the tracker is not altered, and 0 is returned. If the change is committed, by moving the mouse and releasing the left mouse button, the new position and/or size is recorded in the tracker's rectangle and nonzero is returned.  
  
## Remarks  
 This is usually called from inside the function of your application that handles the `WM_LBUTTONDOWN` message (typically `OnLButtonDown`).  
  
 This function will capture the mouse until the user releases the left mouse button, presses the ESC key, or presses the right mouse button. As the user moves the mouse cursor, the feedback is updated by calling `DrawTrackerRect` and `OnChangedRect`.  
  
 If `bAllowInvert` is **TRUE**, the tracking rectangle can be inverted on either the x-axis or y-axis.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::DrawTrackerRect](../vs140/crecttracker--drawtrackerrect.md)   
 [CRectTracker::OnChangedRect](../vs140/crecttracker--onchangedrect.md)   
 [CRectTracker::CRectTracker](../vs140/crecttracker--crecttracker.md)   
 [CRectTracker::TrackRubberBand](../vs140/crecttracker--trackrubberband.md)
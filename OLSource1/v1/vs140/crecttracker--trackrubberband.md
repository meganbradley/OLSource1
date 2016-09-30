---
title: "CRectTracker::TrackRubberBand"
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
  - "CRectTracker::TrackRubberBand"
  - "CRectTracker.TrackRubberBand"
  - "TrackRubberBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drawing, rectangles"
  - "TrackRubberBand method"
  - "CRectTracker class, operations"
ms.assetid: d2250bf3-c9f0-4059-990a-a83eeb65b079
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::TrackRubberBand
Call this function to do rubber-band selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The window object that contains the rectangle.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Device coordinates of the current mouse position relative to the client area.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If **TRUE,** the rectangle can be inverted along the x-axis or y-axis; otherwise **FALSE**.  
  
## Return Value  
 Nonzero if the mouse has moved and the rectangle is not empty; otherwise 0.  
  
## Remarks  
 It is usually called from inside the function of your application that handles the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message (typically <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 This function will capture the mouse until the user releases the left mouse button, presses the ESC key, or presses the right mouse button. As the user moves the mouse cursor, the feedback is updated by calling <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Tracking is performed with a rubber-band-type selection from the lower-right handle. If inverting is allowed, the rectangle can be sized by dragging either up and to the left or down and to the right.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::DrawTrackerRect](../vs140/crecttracker--drawtrackerrect.md)   
 [CRectTracker::OnChangedRect](../vs140/crecttracker--onchangedrect.md)   
 [CRectTracker::CRectTracker](../vs140/crecttracker--crecttracker.md)
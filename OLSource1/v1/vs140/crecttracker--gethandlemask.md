---
title: "CRectTracker::GetHandleMask"
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
  - "CRectTracker::GetHandleMask"
  - "GetHandleMask"
  - "CRectTracker.GetHandleMask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "masks"
  - "resizing rectangles"
  - "CRectTracker class, overridables"
  - "masks, handling"
  - "GetHandleMask method"
  - "resize handles"
  - "rectangles, resizing"
ms.assetid: ac6b96ed-c76b-4197-bc52-037dc28b6d70
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::GetHandleMask
The framework calls this member function to retrieve the mask for a rectangle's resize handles.  
  
## Syntax  
  
```  
  
virtual UINT GetHandleMask( ) const;  
  
```  
  
## Return Value  
 The mask of a `CRectTracker` item's resize handles.  
  
## Remarks  
 The resize handles appear on the sides and corners of the rectangle and allow the user to control the shape and size of the rectangle.  
  
 A rectangle has 8 resize handles numbered 0–7. Each resize handle is represented by a bit in the mask; the value of that bit is 2^*n*, where *n* is the resize handle number. Bits 0–3 correspond to the corner resize handles, starting at the top left moving clockwise. Bits 4–7 correspond to the side resize handles starting at the top moving clockwise. The following illustration shows a rectangle's resize handles and their corresponding resize handle numbers and values:  
  
 ![Resize handle numbers](../vs140/media/vc35dp1.gif "vc35DP1")  
  
 The default implementation of **GetHandleMask** returns the mask of the bits so that the resize handles appear. If the single bit is on, the corresponding resize handle will be drawn.  
  
 Override this member function to hide or show the indicated resize handles.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::AdjustRect](../vs140/crecttracker--adjustrect.md)
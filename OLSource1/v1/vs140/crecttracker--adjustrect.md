---
title: "CRectTracker::AdjustRect"
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
  - "CRectTracker.AdjustRect"
  - "CRectTracker::AdjustRect"
  - "AdjustRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "handles [C++], using"
  - "resizing with handles"
  - "CRectTracker class, overridables"
  - "AdjustRect method"
ms.assetid: 730bf555-0f8e-4b8f-a310-0d9c72697e8f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::AdjustRect
Called by the framework when the tracking rectangle is resized by using a resize handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index of handle used.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the current size of the rectangle. (The size of a rectangle is given by its height and width.)  
  
## Remarks  
 The default behavior of this function allows the rectangle's orientation to change only when <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are called with inverting allowed.  
  
 Override this function to control the adjustment of the tracking rectangle during a dragging operation. One method is to adjust the coordinates specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> before returning.  
  
 Special features that are not directly supported by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, such as snap-to-grid or keep-aspect-ratio, can be implemented by overriding this function.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::Track](../vs140/crecttracker--track.md)   
 [CRectTracker::TrackRubberBand](../vs140/crecttracker--trackrubberband.md)   
 [CRectTracker::OnChangedRect](../vs140/crecttracker--onchangedrect.md)
---
title: "CRectTracker::NormalizeHit"
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
  - "NormalizeHit"
  - "CRectTracker::NormalizeHit"
  - "CRectTracker.NormalizeHit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NormalizeHit method"
  - "CRectTracker class, operations"
ms.assetid: d4bf920a-4189-48ab-9f52-972525e64b1b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::NormalizeHit
Call this function to convert a potentially inverted handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle selected by the user.  
  
## Return Value  
 The index of the normalized handle.  
  
## Remarks  
 When <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called with inverting allowed, it is possible for the rectangle to be inverted on the x-axis, the y-axis, or both. When this happens, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will return handles that are also inverted with respect to the rectangle. This is inappropriate for drawing cursor feedback because the feedback depends on the screen position of the rectangle, not the portion of the rectangle data structure that will be modified.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::HitTest](../vs140/crecttracker--hittest.md)   
 [CRectTracker::Track](../vs140/crecttracker--track.md)   
 [CRectTracker::TrackRubberBand](../vs140/crecttracker--trackrubberband.md)
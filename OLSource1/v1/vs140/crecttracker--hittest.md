---
title: "CRectTracker::HitTest"
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
  - "CRectTracker.HitTest"
  - "CRectTracker::HitTest"
  - "TrackerHit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method [MFC]"
  - "TrackerHit"
  - "CRectTracker class, operations"
  - "position, rectangle"
ms.assetid: 12a41936-b5ae-4ff0-a80d-f3678b42a80a
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::HitTest
Call this function to find out whether the user has grabbed a resize handle.  
  
## Syntax  
  
```  
  
      int HitTest(  
   CPoint point   
) const;  
```  
  
#### Parameters  
 `point`  
 The point, in device coordinates, to test.  
  
## Return Value  
 The value returned is based on the enumerated type **CRectTracker::TrackerHit** and can have one of the following values:  
  
-   **CRectTracker::hitNothing** –1  
  
-   **CRectTracker::hitTopLeft** 0  
  
-   **CRectTracker::hitTopRight** 1  
  
-   **CRectTracker::hitBottomRight** 2  
  
-   **CRectTracker::hitBottomLeft** 3  
  
-   **CRectTracker::hitTop** 4  
  
-   **CRectTracker::hitRight** 5  
  
-   **CRectTracker::hitBottom** 6  
  
-   **CRectTracker::hitLeft** 7  
  
-   **CRectTracker::hitMiddle** 8  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::NormalizeHit](../vs140/crecttracker--normalizehit.md)   
 [CRectTracker::SetCursor](../vs140/crecttracker--setcursor.md)
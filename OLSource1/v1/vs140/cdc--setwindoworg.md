---
title: "CDC::SetWindowOrg"
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
  - "SetWindowOrg"
  - "CDC::SetWindowOrg"
  - "CDC.SetWindowOrg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowOrg method"
  - "CDC class, mapping functions"
ms.assetid: ef4e9dc9-03be-4cbe-abe9-27b1a0a5652d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetWindowOrg
Sets the window origin of the device context.  
  
## Syntax  
  
```  
  
      CPoint SetWindowOrg(  
   int x,  
   int y   
);  
CPoint SetWindowOrg(  
   POINT point   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the new origin of the window.  
  
 *y*  
 Specifies the logical y-coordinate of the new origin of the window.  
  
 `point`  
 Specifies the logical coordinates of the new origin of the window. You can pass either a **POINT** structure or a `CPoint` object for this parameter.  
  
## Return Value  
 The previous origin of the window as a `CPoint` object.  
  
## Remarks  
 The window, along with the device-context viewport, defines how GDI maps points in the logical coordinate system to points in the device coordinate system.  
  
 The window origin marks the point in the logical coordinate system from which GDI maps the viewport origin, a point in the device coordinate system specified by the **SetWindowOrg** function. GDI maps all other points by following the same process required to map the window origin to the viewport origin. For example, all points in a circle around the point at the window origin will be in a circle around the point at the viewport origin. Similarly, all points in a line that passes through the window origin will be in a line that passes through the viewport origin.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPoint Class](../vs140/cpoint-class.md)   
 [POINT Structure](../vs140/point-structure.md)   
 [CDC::GetWindowOrg](../vs140/cdc--getwindoworg.md)
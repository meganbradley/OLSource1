---
title: "CDC::SetViewportOrg"
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
  - "SetViewportOrg"
  - "CDC.SetViewportOrg"
  - "CDC::SetViewportOrg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "SetViewportOrg method"
ms.assetid: 92a53b70-f11b-4b37-9c5b-71e03b3ddefa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetViewportOrg
Sets the viewport origin of the device context.  
  
## Syntax  
  
```  
  
      virtual CPoint SetViewportOrg(  
   int x,  
   int y   
);  
CPoint SetViewportOrg(  
   POINT point   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the x-coordinate (in device units) of the origin of the viewport. The value must be within the range of the device coordinate system.  
  
 *y*  
 Specifies the y-coordinate (in device units) of the origin of the viewport. The value must be within the range of the device coordinate system.  
  
 `point`  
 Specifies the origin of the viewport. The values must be within the range of the device coordinate system. You can pass either a **POINT** structure or a `CPoint` object for this parameter.  
  
## Return Value  
 The previous origin of the viewport (in device coordinates) as a `CPoint` object.  
  
## Remarks  
 The viewport, along with the device-context window, defines how GDI maps points in the logical coordinate system to points in the coordinate system of the actual device. In other words, they define how GDI converts logical coordinates into device coordinates.  
  
 The viewport origin marks the point in the device coordinate system to which GDI maps the window origin, a point in the logical coordinate system specified by the **SetWindowOrg** member function. GDI maps all other points by following the same process required to map the window origin to the viewport origin. For example, all points in a circle around the point at the window origin will be in a circle around the point at the viewport origin. Similarly, all points in a line that passes through the window origin will be in a line that passes through the viewport origin.  
  
## Example  
 See the example for [CView::OnPrepareDC](../vs140/cview--onpreparedc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetWindowOrg](../vs140/cdc--setwindoworg.md)   
 [CPoint Class](../vs140/cpoint-class.md)   
 [POINT Structure](../vs140/point-structure.md)   
 [CDC::GetViewportOrg](../vs140/cdc--getviewportorg.md)
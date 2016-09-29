---
title: "CDC::PolyPolyline"
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
  - "CDC::PolyPolyline"
  - "CDC.PolyPolyline"
  - "PolyPolyline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PolyPolyline method"
  - "CDC class, line-output functions"
ms.assetid: b51ac8e3-2388-40b6-a59f-4247a5e7a106
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::PolyPolyline
Draws multiple series of connected line segments.  
  
## Syntax  
  
```  
  
      BOOL PolyPolyline(  
   const POINT* lpPoints,  
   const DWORD* lpPolyPoints,  
   int nCount   
);  
```  
  
#### Parameters  
 `lpPoints`  
 Points to an array of structures that contains the vertices of the polylines. The polylines are specified consecutively.  
  
 `lpPolyPoints`  
 Points to an array of variables specifying the number of points in the `lpPoints` array for the corresponding polygon. Each entry must be greater than or equal to 2.  
  
 `nCount`  
 Specifies the total number of counts in the `lpPolyPoints` array.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The line segments are drawn by using the current pen. The figures formed by the segments are not filled. The current position is neither used nor updated by this function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Polyline](../vs140/cdc--polyline.md)   
 [CDC::PolylineTo](../vs140/cdc--polylineto.md)   
 [PolyPolyline](http://msdn.microsoft.com/library/windows/desktop/dd162819)
---
title: "CDC::DPtoLP"
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
  - "CDC::DPtoLP"
  - "CDC.DPtoLP"
  - "DPtoLP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DPtoLP method"
  - "CDC class, coordinate functions"
ms.assetid: a2f0ce3a-e775-4646-813d-707a00eb2e0c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DPtoLP
Converts device units into logical units.  
  
## Syntax  
  
```  
  
      void DPtoLP(  
   LPPOINT lpPoints,  
   int nCount = 1   
) const;  
void DPtoLP(  
   LPRECT lpRect   
) const;  
void DPtoLP(  
   LPSIZE lpSize   
) const;  
```  
  
#### Parameters  
 `lpPoints`  
 Points to an array of [POINT](../vs140/point-structure.md) structures or [CPoint](../vs140/cpoint-class.md) objects.  
  
 `nCount`  
 The number of points in the array.  
  
 `lpRect`  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object. This parameter is used for the simple case of converting one rectangle from device points to logical points.  
  
 `lpSize`  
 Points to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
## Remarks  
 The function maps the coordinates of each point, or dimension of a size, from the device coordinate system into GDI's logical coordinate system. The conversion depends on the current mapping mode and the settings of the origins and extents for the device's window and viewport.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::LPtoDP](../vs140/cdc--lptodp.md)   
 [CDC::HIMETRICtoDP](../vs140/cdc--himetrictodp.md)   
 [DPtoLP](http://msdn.microsoft.com/library/windows/desktop/dd162474)   
 [POINT Structure](../vs140/point-structure.md)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CDC::GetWindowExt](../vs140/cdc--getwindowext.md)   
 [CDC::GetWindowOrg](../vs140/cdc--getwindoworg.md)
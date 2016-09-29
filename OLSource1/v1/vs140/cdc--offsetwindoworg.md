---
title: "CDC::OffsetWindowOrg"
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
  - "OffsetWindowOrg"
  - "CDC::OffsetWindowOrg"
  - "CDC.OffsetWindowOrg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "OffsetWindowOrg method"
ms.assetid: 220b2e48-3a18-4828-bc2d-6dba103a5c34
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::OffsetWindowOrg
Modifies the coordinates of the window origin relative to the coordinates of the current window origin.  
  
## Syntax  
  
```  
  
      CPoint OffsetWindowOrg(  
   int nWidth,  
   int nHeight   
);  
```  
  
#### Parameters  
 `nWidth`  
 Specifies the number of logical units to add to the current origin's x-coordinate.  
  
 `nHeight`  
 Specifies the number of logical units to add to the current origin's y-coordinate.  
  
## Return Value  
 The previous window origin (in logical coordinates) as a `CPoint` object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetWindowOrg](../vs140/cdc--getwindoworg.md)   
 [CDC::OffsetViewportOrg](../vs140/cdc--offsetviewportorg.md)   
 [CDC::SetWindowOrg](../vs140/cdc--setwindoworg.md)   
 [CPoint Class](../vs140/cpoint-class.md)
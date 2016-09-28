---
title: "CRgn::OffsetRgn"
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
  - "OffsetRgn"
  - "CRgn::OffsetRgn"
  - "CRgn.OffsetRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OffsetRgn method"
  - "CRgn class, operations"
ms.assetid: 125f5269-b33e-4fae-94f9-55da0aa4ff9b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::OffsetRgn
Moves the region stored in the `CRgn` object by the specified offsets.  
  
## Syntax  
  
```  
  
      int OffsetRgn(  
   int x,  
   int y   
);  
int OffsetRgn(  
   POINT point   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the number of units to move left or right.  
  
 *y*  
 Specifies the number of units to move up or down.  
  
 `point`  
 The x-coordinate of `point` specifies the number of units to move left or right. The y-coordinate of `point` specifies the number of units to move up or down. The `point` parameter may be either a **POINT** structure or a `CPoint` object.  
  
## Return Value  
 The new region's type. It can be any one of the following values:  
  
-   **COMPLEXREGION** Region has overlapping borders.  
  
-   **ERROR** Region handle is not valid.  
  
-   **NULLREGION** Region is empty.  
  
-   **SIMPLEREGION** Region has no overlapping borders.  
  
## Remarks  
 The function moves the region *x* units along the x-axis and *y* units along the y-axis.  
  
 The coordinate values of a region must be less than or equal to 32,767 and greater than or equal to –32,768. The *x* and *y* parameters must be carefully chosen to prevent invalid region coordinates.  
  
## Example  
 See the example for [CRgn::CreateEllipticRgn](../vs140/crgn--createellipticrgn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [OffsetRgn](http://msdn.microsoft.com/library/windows/desktop/dd162747)
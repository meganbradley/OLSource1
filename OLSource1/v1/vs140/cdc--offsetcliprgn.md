---
title: "CDC::OffsetClipRgn"
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
  - "CDC::OffsetClipRgn"
  - "CDC.OffsetClipRgn"
  - "OffsetClipRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OffsetClipRgn method"
  - "CDC class, clipping functions"
ms.assetid: d39e4bca-89d2-440b-bfbb-15619f7bd2f9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::OffsetClipRgn
Moves the clipping region of the device context by the specified offsets.  
  
## Syntax  
  
```  
  
      int OffsetClipRgn(  
   int x,  
   int y   
);  
int OffsetClipRgn(  
   SIZE size   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the number of logical units to move left or right.  
  
 *y*  
 Specifies the number of logical units to move up or down.  
  
 `size`  
 Specifies the amount to offset.  
  
## Return Value  
 The new region's type. It can be any one of the following values:  
  
-   **COMPLEXREGION** Clipping region has overlapping borders.  
  
-   **ERROR** Device context is not valid.  
  
-   **NULLREGION** Clipping region is empty.  
  
-   **SIMPLEREGION** Clipping region has no overlapping borders.  
  
## Remarks  
 The function moves the region *x* units along the x-axis and *y* units along the y-axis.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SelectClipRgn](../vs140/cdc--selectcliprgn.md)   
 [OffsetClipRgn](http://msdn.microsoft.com/library/windows/desktop/dd162745)
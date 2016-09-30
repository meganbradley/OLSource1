---
title: "CDC::ScaleWindowExt"
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
  - "ScaleWindowExt"
  - "CDC::ScaleWindowExt"
  - "CDC.ScaleWindowExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "ScaleWindowExt method"
ms.assetid: 62b47e71-fdb7-42e8-acf1-ac3f49f990dd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ScaleWindowExt
Modifies the window extents relative to the current values.  
  
## Syntax  
  
```  
  
      virtual CSize ScaleWindowExt(  
   int xNum,  
   int xDenom,  
   int yNum,  
   int  
yDenom );  
```  
  
#### Parameters  
 `xNum`  
 Specifies the amount by which to multiply the current x-extent.  
  
 `xDenom`  
 Specifies the amount by which to divide the result of multiplying the current x-extent by the value of the `xNum` parameter.  
  
 `yNum`  
 Specifies the amount by which to multiply the current y-extent.  
  
 `yDenom`  
 Specifies the amount by which to divide the result of multiplying the current y-extent by the value of the `yNum` parameter.  
  
## Return Value  
 The previous window extents (in logical units) as a `CSize` object.  
  
## Remarks  
 The formulas are written as follows:  
  
 `xNewWE = ( xOldWE * xNum ) / xDenom`  
  
 `yNewWE = ( yOldWE * yNum ) / yDenom`  
  
 The new window extents are calculated by multiplying the current extents by the given numerator and then dividing by the given denominator.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetWindowExt](../vs140/cdc--getwindowext.md)   
 [CSize Class](../vs140/csize-class.md)
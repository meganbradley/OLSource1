---
title: "CDC::ScaleViewportExt"
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
  - "CDC::ScaleViewportExt"
  - "ScaleViewportExt"
  - "CDC.ScaleViewportExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "ScaleViewportExt method"
ms.assetid: 7b2ef940-ffa2-4f45-85d5-7fea81f0e530
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ScaleViewportExt
Modifies the viewport extents relative to the current values.  
  
## Syntax  
  
```  
  
      virtual CSize ScaleViewportExt(  
   int xNum,  
   int xDenom,  
   int yNum,  
   int yDenom   
);  
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
 The previous viewport extents (in device units) as a `CSize` object.  
  
## Remarks  
 The formulas are written as follows:  
  
 `xNewVE = ( xOldVE * xNum ) / xDenom`  
  
 `yNewVE = ( yOldVE * yNum ) / yDenom`  
  
 The new viewport extents are calculated by multiplying the current extents by the given numerator and then dividing by the given denominator.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetViewportExt](../vs140/cdc--getviewportext.md)   
 [CSize Class](../vs140/csize-class.md)
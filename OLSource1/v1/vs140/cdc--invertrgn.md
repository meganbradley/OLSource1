---
title: "CDC::InvertRgn"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - InvertRgn
  - CDC::InvertRgn
  - CDC.InvertRgn
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, region functions
  - InvertRgn method
ms.assetid: cfb6c105-a1b7-4f2b-ba30-250d0b3761bc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::InvertRgn
Inverts the colors in the region specified by `pRgn`.  
  
## Syntax  
  
```  
  
      BOOL InvertRgn(  
   CRgn* pRgn   
);  
```  
  
#### Parameters  
 `pRgn`  
 Identifies the region to be inverted. The coordinates for the region are specified in logical units.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 On monochrome displays, the function makes white pixels black and black pixels white. On color displays, the inversion depends on how the colors are generated for the display.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::FillRgn](../vs140/cdc--fillrgn.md)   
 [CDC::PaintRgn](../vs140/cdc--paintrgn.md)   
 [CRgn Class](../vs140/crgn-class.md)   
 [InvertRgn](http://msdn.microsoft.com/library/windows/desktop/dd145008)
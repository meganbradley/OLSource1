---
title: "CDC::GetNearestColor"
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
  - "GetNearestColor"
  - "CDC::GetNearestColor"
  - "CDC.GetNearestColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNearestColor method"
  - "CDC class, color and color palette functions"
ms.assetid: 6204fae3-f439-4434-ae8e-c18448f071b4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetNearestColor
Returns the solid color that best matches a specified logical color.  
  
## Syntax  
  
```  
  
      COLORREF GetNearestColor(  
   COLORREF crColor   
) const;  
```  
  
#### Parameters  
 `crColor`  
 Specifies the color to be matched.  
  
## Return Value  
 An RGB (red, green, blue) color value that defines the solid color closest to the `crColor` value that the device can represent.  
  
## Remarks  
 The given device must be able to represent this color.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetNearestColor](http://msdn.microsoft.com/library/windows/desktop/dd144902)   
 [CPalette::GetNearestPaletteIndex](../vs140/cpalette--getnearestpaletteindex.md)
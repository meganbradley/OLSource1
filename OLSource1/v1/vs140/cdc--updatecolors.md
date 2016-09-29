---
title: "CDC::UpdateColors"
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
  - "CDC.UpdateColors"
  - "UpdateColors"
  - "CDC::UpdateColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateColors method"
  - "CDC class, color and color palette functions"
ms.assetid: b86393c4-f7d2-4428-8db6-8b8c157d60a7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::UpdateColors
Updates the client area of the device context by matching the current colors in the client area to the system palette on a pixel-by-pixel basis.  
  
## Syntax  
  
```  
  
void UpdateColors( );  
```  
  
## Remarks  
 An inactive window with a realized logical palette may call `UpdateColors` as an alternative to redrawing its client area when the system palette changes.  
  
 For more information about using color palettes, see [UpdateColors](http://msdn.microsoft.com/library/windows/desktop/dd145166) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The `UpdateColors` member function typically updates a client area faster than redrawing the area. However, because the function performs the color translation based on the color of each pixel before the system palette changed, each call to this function results in the loss of some color accuracy.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::RealizePalette](../vs140/cdc--realizepalette.md)   
 [CPalette Class](../vs140/cpalette-class.md)   
 [UpdateColors](http://msdn.microsoft.com/library/windows/desktop/dd145166)
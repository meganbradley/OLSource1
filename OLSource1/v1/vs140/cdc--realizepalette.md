---
title: "CDC::RealizePalette"
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
  - "RealizePalette"
  - "CDC::RealizePalette"
  - "CDC.RealizePalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RealizePalette method"
  - "CDC class, color and color palette functions"
ms.assetid: 5b55e0a3-dfa2-484b-b24d-ffa05bffcd90
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::RealizePalette
Maps entries from the current logical palette to the system palette.  
  
## Syntax  
  
```  
  
UINT RealizePalette( );  
```  
  
## Return Value  
 Indicates how many entries in the logical palette were mapped to different entries in the system palette. This represents the number of entries that this function remapped to accommodate changes in the system palette since the logical palette was last realized.  
  
## Remarks  
 A logical color palette acts as a buffer between color-intensive applications and the system, allowing an application to use as many colors as needed without interfering with its own displayed colors or with colors displayed by other windows.  
  
 When a window has the input focus and calls `RealizePalette`, Windows ensures that the window will display all the requested colors, up to the maximum number simultaneously available on the screen. Windows also displays colors not found in the window's palette by matching them to available colors.  
  
 In addition, Windows matches the colors requested by inactive windows that call the function as closely as possible to the available colors. This significantly reduces undesirable changes in the colors displayed in inactive windows.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SelectPalette](../vs140/cdc--selectpalette.md)   
 [CPalette Class](../vs140/cpalette-class.md)   
 [RealizePalette](http://msdn.microsoft.com/library/windows/desktop/dd162896)
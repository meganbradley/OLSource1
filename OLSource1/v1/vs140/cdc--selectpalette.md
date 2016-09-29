---
title: "CDC::SelectPalette"
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
  - "CDC.SelectPalette"
  - "CDC::SelectPalette"
  - "SelectPalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectPalette method"
  - "color palettes, selecting"
  - "palettes, selecting"
  - "CDC class, color and color palette functions"
ms.assetid: d3897fe0-7222-4a7d-bd52-089d2376b29d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SelectPalette
Selects the logical palette that is specified by `pPalette` as the selected palette object of the device context.  
  
## Syntax  
  
```  
  
      CPalette* SelectPalette(  
   CPalette* pPalette,  
   BOOL bForceBackground   
);  
```  
  
#### Parameters  
 `pPalette`  
 Identifies the logical palette to be selected. This palette must already have been created with the `CPalette` member function [CreatePalette](../vs140/cpalette--createpalette.md).  
  
 `bForceBackground`  
 Specifies whether the logical palette is forced to be a background palette. If `bForceBackground` is nonzero, the selected palette is always a background palette, regardless of whether the window has the input focus. If `bForceBackground` is 0 and the device context is attached to a window, the logical palette is a foreground palette when the window has the input focus.  
  
## Return Value  
 A pointer to a `CPalette` object identifying the logical palette replaced by the palette specified by `pPalette`. It is **NULL** if there is an error.  
  
## Remarks  
 The new palette becomes the palette object used by GDI to control colors displayed in the device context and replaces the previous palette.  
  
 An application can select a logical palette into more than one device context. However, changes to a logical palette will affect all device contexts for which it is selected. If an application selects a palette into more than one device context, the device contexts must all belong to the same physical device.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::RealizePalette](../vs140/cdc--realizepalette.md)   
 [CPalette Class](../vs140/cpalette-class.md)   
 [SelectPalette](http://msdn.microsoft.com/library/windows/desktop/dd162958)
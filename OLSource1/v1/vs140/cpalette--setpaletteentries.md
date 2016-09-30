---
title: "CPalette::SetPaletteEntries"
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
  - "SetPaletteEntries"
  - "CPalette.SetPaletteEntries"
  - "CPalette::SetPaletteEntries"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPaletteEntries method"
  - "palettes, setting values"
  - "CPalette class, attributes"
  - "colors, setting values in logical palettes"
  - "RGB values"
  - "color palettes, setting values"
ms.assetid: ca326b37-418a-4aa9-9b79-2e415e02525d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPalette::SetPaletteEntries
Sets RGB color values and flags in a range of entries in a logical palette.  
  
## Syntax  
  
```  
  
      UINT SetPaletteEntries(  
   UINT nStartIndex,  
   UINT nNumEntries,  
   LPPALETTEENTRY lpPaletteColors   
);  
```  
  
#### Parameters  
 `nStartIndex`  
 Specifies the first entry in the logical palette to be set.  
  
 `nNumEntries`  
 Specifies the number of entries in the logical palette to be set.  
  
 `lpPaletteColors`  
 Points to an array of [PALETTEENTRY](http://msdn.microsoft.com/library/windows/desktop/dd162769) data structures to receive the palette entries. The array must contain at least as many data structures as specified by `nNumEntries`.  
  
## Return Value  
 The number of entries set in the logical palette; 0 if the function failed.  
  
## Remarks  
 If the logical palette is selected into a device context when the application calls `SetPaletteEntries`, the changes will not take effect until the application calls [CDC::RealizePalette](../vs140/cdc--realizepalette.md).  
  
 For more information on the Windows structure **PALETTEENTRY**, see [PALETTEENTRY](http://msdn.microsoft.com/library/windows/desktop/dd162769) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPalette Class](../vs140/cpalette-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::RealizePalette](../vs140/cdc--realizepalette.md)   
 [CPalette::GetPaletteEntries](../vs140/cpalette--getpaletteentries.md)   
 [SetPaletteEntries](http://msdn.microsoft.com/library/windows/desktop/dd145077)
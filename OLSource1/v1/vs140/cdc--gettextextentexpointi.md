---
title: "CDC::GetTextExtentExPointI"
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
  - "CDC::GetTextExtentExPointI"
  - "GetTextExtentExPointI"
  - "CDC.GetTextExtentExPointI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextExtentExPointI method"
  - "CDC class, text functions"
ms.assetid: 3ecddf3a-a4a6-418c-bac6-ba28fa24abbd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetTextExtentExPointI
Retrieves the number of characters in a specified string that will fit within a specified space and fills an array with the text extent for each of those characters.  
  
## Syntax  
  
```  
  
      BOOL GetTextExtentExPointI(  
   LPWORD pgiIn,  
   int cgi,  
   int nMaxExtent,  
   LPINT lpnFit,  
   LPINT alpDx,  
   LPSIZE lpSize  
) const;  
```  
  
#### Parameters  
 `pgiIn`  
 A pointer to an array of glyph indices for which extents are to be retrieved.  
  
 `cgi`  
 Specifies the number of glyphs in the array pointed to by `pgiIn`.  
  
 `nMaxExtent`  
 Specifies the maximum allowable width, in logical units, of the formatted string.  
  
 `lpnFit`  
 A pointer to an integer that receives a count of the maximum number of characters that will fit in the space specified by `nMaxExtent`. When `lpnFit` is **NULL**, `nMaxExtent` is ignored.  
  
 *alpDx*  
 A pointer to an array of integers that receives partial glyph extents. Each element in the array gives the distance, in logical units, between the beginning of the glyph indices array and one of the glyphs that fits in the space specified by `nMaxExtent`. Although this array should have at least as many elements as glyph indices specified by `cgi`, the function fills the array with extents only for as many glyph indices as are specified by `lpnFit`. If *lpnDx* is **NULL**, the function does not compute partial string widths.  
  
 `lpSize`  
 Pointer to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure that receives the dimensions of the glyph indices array, in logical units. This value cannot be **NULL**.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [GetTextExtentExPointI](http://msdn.microsoft.com/library/windows/desktop/dd144936), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTextExtentPointI](../vs140/cdc--gettextextentpointi.md)
---
title: "CBrush::CreatePatternBrush"
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
  - "CBrush.CreatePatternBrush"
  - "CBrush::CreatePatternBrush"
  - "CreatePatternBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pattern brushes"
  - "CreatePatternBrush method"
  - "pattern brushes, creating"
ms.assetid: 521ebcf8-ae9b-402f-8085-32610fac6a4e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBrush::CreatePatternBrush
Initializes a brush with a pattern specified by a bitmap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies a bitmap.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The brush can subsequently be selected for any device context that supports raster operations. The bitmap identified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is typically initialized by using the [CBitmap::CreateBitmap](../vs140/cbitmap--createbitmap.md), [CBitmap::CreateBitmapIndirect](../vs140/cbitmap--createbitmapindirect.md), [CBitmap::LoadBitmap](../vs140/cbitmap--loadbitmap.md), or [CBitmap::CreateCompatibleBitmap](../vs140/cbitmap--createcompatiblebitmap.md) function.  
  
 Bitmaps used as fill patterns should be 8 pixels by 8 pixels. If the bitmap is larger, Windows will only use the bits corresponding to the first 8 rows and columns of pixels in the upper-left corner of the bitmap.  
  
 A pattern brush can be deleted without affecting the associated bitmap. This means the bitmap can be used to create any number of pattern brushes.  
  
 A brush created using a monochrome bitmap (1 color plane, 1 bit per pixel) is drawn using the current text and background colors. Pixels represented by a bit set to 0 are drawn with the current text color. Pixels represented by a bit set to 1 are drawn with the current background color.  
  
 For information about using [CreatePatternBrush](http://msdn.microsoft.com/library/windows/desktop/dd183508), a Windows function, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#25](../vs140/codesnippet/CPP/cbrush--createpatternbrush_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBrush Class](../vs140/cbrush-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [CBrush::CreateBrushIndirect](../vs140/cbrush--createbrushindirect.md)   
 [CBrush::CreateDIBPatternBrush](../vs140/cbrush--createdibpatternbrush.md)   
 [CBrush::CreateHatchBrush](../vs140/cbrush--createhatchbrush.md)   
 [CBrush::CreateSolidBrush](../vs140/cbrush--createsolidbrush.md)   
 [CGdiObject::CreateStockObject](../vs140/cgdiobject--createstockobject.md)
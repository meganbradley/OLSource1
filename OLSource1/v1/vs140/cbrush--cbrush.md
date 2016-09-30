---
title: "CBrush::CBrush"
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
  - "CBrush::CBrush"
  - "HS_BDIAGONAL"
  - "HS_CROSS"
  - "HS_FDIAGONAL"
  - "HS_DIAGCROSS"
  - "HS_VERTICAL"
  - "CBrush.CBrush"
  - "HS_HORIZONTAL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HS_VERTICAL constant"
  - "HS_BDIAGONAL constant"
  - "HS_HORIZONTAL constant"
  - "HS_CROSS constant"
  - "brushes, colors"
  - "CBrush class, constructor"
  - "HS_DIAGCROSS constant"
  - "colors, brush"
  - "HS_FDIAGONAL constant"
ms.assetid: b094feeb-15f8-4f47-b532-08015086c009
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBrush::CBrush
Constructs a `CBrush` object.  
  
## Syntax  
  
```  
  
      CBrush( );  
CBrush(  
   COLORREF crColor   
);  
CBrush(  
   int nIndex,  
   COLORREF crColor   
);  
explicit CBrush(  
   CBitmap* pBitmap   
);  
```  
  
#### Parameters  
 `crColor`  
 Specifies the foreground color of the brush as an RGB color. If the brush is hatched, this parameter specifies the color of the hatching.  
  
 `nIndex`  
 Specifies the hatch style of the brush. It can be any one of the following values:  
  
-   `HS_BDIAGONAL` Downward hatch (left to right) at 45 degrees  
  
-   `HS_CROSS` Horizontal and vertical crosshatch  
  
-   `HS_DIAGCROSS` Crosshatch at 45 degrees  
  
-   `HS_FDIAGONAL` Upward hatch (left to right) at 45 degrees  
  
-   `HS_HORIZONTAL` Horizontal hatch  
  
-   `HS_VERTICAL` Vertical hatch  
  
 `pBitmap`  
 Points to a `CBitmap` object that specifies a bitmap with which the brush paints.  
  
## Remarks  
 `CBrush` has four overloaded constructors.The constructor with no arguments constructs an uninitialized `CBrush` object that must be initialized before it can be used.  
  
 If you use the constructor with no arguments, you must initialize the resulting `CBrush` object with [CreateSolidBrush](../vs140/cbrush--createsolidbrush.md), [CreateHatchBrush](../vs140/cbrush--createhatchbrush.md), [CreateBrushIndirect](../vs140/cbrush--createbrushindirect.md), [CreatePatternBrush](../vs140/cbrush--createpatternbrush.md), or [CreateDIBPatternBrush](../vs140/cbrush--createdibpatternbrush.md). If you use one of the constructors that takes arguments, then no further initialization is necessary. The constructors with arguments can throw an exception if errors are encountered, while the constructor with no arguments will always succeed.  
  
 The constructor with a single [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter constructs a solid brush with the specified color. The color specifies an RGB value and can be constructed with the `RGB` macro in WINDOWS.H.  
  
 The constructor with two parameters constructs a hatch brush. The `nIndex` parameter specifies the index of a hatched pattern. The `crColor` parameter specifies the color.  
  
 The constructor with a `CBitmap` parameter constructs a patterned brush. The parameter identifies a bitmap. The bitmap is assumed to have been created by using [CBitmap::CreateBitmap](../vs140/cbitmap--createbitmap.md), [CBitmap::CreateBitmapIndirect](../vs140/cbitmap--createbitmapindirect.md), [CBitmap::LoadBitmap](../vs140/cbitmap--loadbitmap.md), or [CBitmap::CreateCompatibleBitmap](../vs140/cbitmap--createcompatiblebitmap.md). The minimum size for a bitmap to be used in a fill pattern is 8 pixels by 8 pixels.  
  
## Example  
 [!code[NVC_MFCDocView#21](../vs140/codesnippet/CPP/cbrush--cbrush_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBrush Class](../vs140/cbrush-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush::CreateSolidBrush](../vs140/cbrush--createsolidbrush.md)   
 [CBrush::CreateHatchBrush](../vs140/cbrush--createhatchbrush.md)   
 [CBrush::CreateBrushIndirect](../vs140/cbrush--createbrushindirect.md)   
 [CBrush::CreatePatternBrush](../vs140/cbrush--createpatternbrush.md)   
 [CBrush::CreateDIBPatternBrush](../vs140/cbrush--createdibpatternbrush.md)   
 [CGdiObject::CreateStockObject](../vs140/cgdiobject--createstockobject.md)
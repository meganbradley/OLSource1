---
title: "CBrush::CreateBrushIndirect"
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
  - "CBrush.CreateBrushIndirect"
  - "CreateBrushIndirect"
  - "CBrush::CreateBrushIndirect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LOGBRUSH structure"
  - "CreateBrushIndirect method"
ms.assetid: 32979cad-6ccf-4bb1-aacc-44bd1c1fa430
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBrush::CreateBrushIndirect
Initializes a brush with a style, color, and pattern specified in a [LOGBRUSH](http://msdn.microsoft.com/library/windows/desktop/dd145035) structure.  
  
## Syntax  
  
```  
  
      BOOL CreateBrushIndirect(  
   const LOGBRUSH* lpLogBrush   
);  
```  
  
#### Parameters  
 *lpLogBrush*  
 Points to a [LOGBRUSH](http://msdn.microsoft.com/library/windows/desktop/dd145035) structure that contains information about the brush.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The brush can subsequently be selected as the current brush for any device context.  
  
 A brush created using a monochrome (1 plane, 1 bit per pixel) bitmap is drawn using the current text and background colors. Pixels represented by a bit set to 0 will be drawn with the current text color. Pixels represented by a bit set to 1 will be drawn with the current background color.  
  
## Example  
 [!code[NVC_MFCDocView#22](../vs140/codesnippet/CPP/cbrush--createbrushindirect_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBrush Class](../vs140/cbrush-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush::CreateDIBPatternBrush](../vs140/cbrush--createdibpatternbrush.md)   
 [CBrush::CreatePatternBrush](../vs140/cbrush--createpatternbrush.md)   
 [CBrush::CreateSolidBrush](../vs140/cbrush--createsolidbrush.md)   
 [CBrush::CreateHatchBrush](../vs140/cbrush--createhatchbrush.md)   
 [CGdiObject::CreateStockObject](../vs140/cgdiobject--createstockobject.md)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)   
 [CreateBrushIndirect](http://msdn.microsoft.com/library/windows/desktop/dd183487)
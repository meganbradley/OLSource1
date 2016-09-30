---
title: "CBrush::CreateHatchBrush"
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
  - "CBrush::CreateHatchBrush"
  - "CBrush.CreateHatchBrush"
  - "CreateHatchBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hatch brushes"
  - "CreateHatchBrush method"
ms.assetid: 30028a59-abe1-4a6e-958e-a57eb832a2e5
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBrush::CreateHatchBrush
Initializes a brush with the specified hatched pattern and color.  
  
## Syntax  
  
```  
  
      BOOL CreateHatchBrush(  
   int nIndex,  
   COLORREF crColor   
);  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the hatch style of the brush. It can be any one of the following values:  
  
-   `HS_BDIAGONAL` Downward hatch (left to right) at 45 degrees  
  
-   `HS_CROSS` Horizontal and vertical crosshatch  
  
-   `HS_DIAGCROSS` Crosshatch at 45 degrees  
  
-   `HS_FDIAGONAL` Upward hatch (left to right) at 45 degrees  
  
-   `HS_HORIZONTAL` Horizontal hatch  
  
-   `HS_VERTICAL` Vertical hatch  
  
 `crColor`  
 Specifies the foreground color of the brush as an RGB color (the color of the hatches). See [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The brush can subsequently be selected as the current brush for any device context.  
  
## Example  
 [!code[NVC_MFCDocView#24](../vs140/codesnippet/CPP/cbrush--createhatchbrush_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBrush Class](../vs140/cbrush-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush::CreateBrushIndirect](../vs140/cbrush--createbrushindirect.md)   
 [CBrush::CreateDIBPatternBrush](../vs140/cbrush--createdibpatternbrush.md)   
 [CBrush::CreatePatternBrush](../vs140/cbrush--createpatternbrush.md)   
 [CBrush::CreateSolidBrush](../vs140/cbrush--createsolidbrush.md)   
 [CGdiObject::CreateStockObject](../vs140/cgdiobject--createstockobject.md)   
 [CreateHatchBrush](http://msdn.microsoft.com/library/windows/desktop/dd183504)
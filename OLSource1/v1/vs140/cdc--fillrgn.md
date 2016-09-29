---
title: "CDC::FillRgn"
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
  - "FillRgn"
  - "CDC.FillRgn"
  - "CDC::FillRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, region functions"
  - "FillRgn method"
ms.assetid: f40489dc-526a-4917-b265-25120bfb1167
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::FillRgn
Fills the region specified by `pRgn` with the brush specified by `pBrush`.  
  
## Syntax  
  
```  
  
      BOOL FillRgn(  
   CRgn* pRgn,  
   CBrush* pBrush   
);  
```  
  
#### Parameters  
 `pRgn`  
 A pointer to the region to be filled. The coordinates for the given region are specified in logical units.  
  
 `pBrush`  
 Identifies the brush to be used to fill the region.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The brush must either be created using the `CBrush` member functions `CreateHatchBrush`, `CreatePatternBrush`, `CreateSolidBrush`, or be retrieved by **GetStockObject**.  
  
## Example  
 See the example for [CRgn::CreateRoundRectRgn](../vs140/crgn--createroundrectrgn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::PaintRgn](../vs140/cdc--paintrgn.md)   
 [CDC::FillRect](../vs140/cdc--fillrect.md)   
 [CBrush Class](../vs140/cbrush-class.md)   
 [CRgn Class](../vs140/crgn-class.md)   
 [FillRgn](http://msdn.microsoft.com/library/windows/desktop/dd162720)
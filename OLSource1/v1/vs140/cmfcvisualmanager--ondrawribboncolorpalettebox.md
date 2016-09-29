---
title: "CMFCVisualManager::OnDrawRibbonColorPaletteBox"
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
  - "CMFCVisualManager::OnDrawRibbonColorPaletteBox"
  - "OnDrawRibbonColorPaletteBox"
  - "CMFCVisualManager.OnDrawRibbonColorPaletteBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonColorPaletteBox method"
ms.assetid: 85713aa0-9530-43ce-bb5f-bc83052dda74
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonColorPaletteBox
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
```  
virtual void OnDrawRibbonColorPaletteBox(  
   CDC* pDC,  
   CMFCRibbonColorButton* pColorButton,  
   CMFCRibbonGalleryIcon* pIcon,  
   COLORREF color,  
   CRect rect,  
   BOOL bDrawTopEdge,  
   BOOL bDrawBottomEdge,  
   BOOL bIsHighlighted,  
   BOOL bIsChecked,  
   BOOL bIsDisabled  
);  
```  
  
#### Parameters  
 [in] `pDC`  
  [in] `pColorButton`  
  [in] `pIcon`  
  [in] `color`  
  [in] `rect`  
  [in] `bDrawTopEdge`  
  [in] `bDrawBottomEdge`  
  [in] `bIsHighlighted`  
  [in] `bIsChecked`  
  [in] `bIsDisabled`  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
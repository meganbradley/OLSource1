---
title: "CMFCVisualManager::OnDrawCaptionBarBorder"
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
  - "OnDrawCaptionBarBorder"
  - "CMFCVisualManager::OnDrawCaptionBarBorder"
  - "CMFCVisualManager.OnDrawCaptionBarBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawCaptionBarBorder method"
ms.assetid: de607c39-0c2e-426e-afb4-e795033b68d4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawCaptionBarBorder
The framework calls this method when it draws the border of a [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawCaptionBarBorder(  
   CDC* pDC,  
   CMFCCaptionBar* pBar,  
   CRect rect,  
   COLORREF clrBarBorder,  
   BOOL bFlatBorder   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pBar`  
 A pointer to a `CMFCCaptionBar` object. The framework draws this caption bar.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the caption bar.  
  
 [in] `clrBarBorder`  
 The color of the border.  
  
 [in] `bFlatBorder`  
 A Boolean parameter that specifies whether the border has a flat, 2D appearance.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of the border of a caption bar.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)
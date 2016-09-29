---
title: "CMFCVisualManager::OnDrawRibbonSliderThumb"
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
  - "CMFCVisualManager::OnDrawRibbonSliderThumb"
  - "OnDrawRibbonSliderThumb"
  - "CMFCVisualManager.OnDrawRibbonSliderThumb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonSliderThumb method"
ms.assetid: ba547e95-50e7-4e81-b3d8-30d4df6d50cd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonSliderThumb
The framework calls this method when it draws the thumb of a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawRibbonSliderThumb(  
   CDC* pDC,  
   CMFCRibbonSlider* pSlider,  
   CRect rect,  
   BOOL bIsHighlighted,  
   BOOL bIsPressed,  
   BOOL bIsDisabled  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pSlider`  
 A pointer to a `CMFCRibbonSlider`. The framework draws the thumb for this ribbon slider.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the thumb for the ribbon slider.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that indicates if the thumb is highlighted.  
  
 [in] `bIsPressed`  
 A Boolean parameter that indicates if the thumb is pressed.  
  
 [in] `bIsDisabled`  
 A Boolean parameter that indicates if the thumb is unavailable.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the thumb for a `CMFCRibbonSlider`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonSlider Class](../vs140/cmfcribbonslider-class.md)
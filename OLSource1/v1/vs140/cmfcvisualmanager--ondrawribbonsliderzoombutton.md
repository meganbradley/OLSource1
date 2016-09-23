---
title: "CMFCVisualManager::OnDrawRibbonSliderZoomButton"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCVisualManager.OnDrawRibbonSliderZoomButton
  - OnDrawRibbonSliderZoomButton
  - CMFCVisualManager::OnDrawRibbonSliderZoomButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawRibbonSliderZoomButton method
ms.assetid: 5d91f726-419f-4acc-91ef-4defcb43f97e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnDrawRibbonSliderZoomButton
The framework calls this method when it draws the zoom buttons for a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawRibbonSliderZoomButton(  
   CDC* pDC,  
   CMFCRibbonSlider* pSlider,  
   CRect rect,  
   BOOL bIsZoomOut,  
   BOOL bIsHighlighted,  
   BOOL bIsPressed,  
   BOOL bIsDisabled  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pSlider`  
 A pointer to a `CMFCRibbonSlider` object. The framework draws this ribbon slider.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the zoom buttons on the ribbon slider.  
  
 [in] `bIsZoomOut`  
 A Boolean parameter that indicates which button the framework draws. A value of `TRUE` indicates the left button with a "-" for zoom out. A value of `FALSE` indicates the right button with a "+" for zoom in.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that indicates whether the button is highlighted.  
  
 [in] `bIsPressed`  
 A Boolean parameter that indicates whether the button is pressed.  
  
 [in] `bIsDisabled`  
 A Boolean parameter that indicates whether the button is unavailable.  
  
## Remarks  
 By default, the zoom buttons on the ribbon slider are a circle with either a + or - sign in the center. To customize the appearance of zoom buttons, override this method in a derived visual manager.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonSlider Class](../vs140/cmfcribbonslider-class.md)
---
title: "CMFCToolBarComboBoxButton::OnDraw"
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
  - "OnDraw"
  - "CMFCToolBarComboBoxButton::OnDraw"
  - "CMFCToolBarComboBoxButton.OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: d4801aa7-2514-4bf4-b1ca-2bef76137820
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::OnDraw
Called by the framework to draw the combo box button by using the specified styles and options.  
  
## Syntax  
  
```  
virtual void OnDraw(  
   CDC* pDC,  
   const CRect& rect,  
   CMFCToolBarImages* pImages,  
   BOOL bHorz = TRUE,  
   BOOL bCustomizeMode = FALSE,  
   BOOL bHighlight = FALSE,  
   BOOL bDrawBorder = TRUE,  
   BOOL bGrayDisabledButtons = TRUE  
);  
```  
  
#### Parameters  
 [in] `Pdc`  
 The device context that displays the button.  
  
 [in] `rect`  
 The bounding rectangle of the button.  
  
 [in] `pImages`  
 The collection of images that is associated with the button.  
  
 [in] `bHorz`  
 The dock state of the parent toolbar. `TRUE` when the toolbar is docked horizontally and `FALSE` when the toolbar is docked vertically.  
  
 [in] `bCustomizeMode`  
 Whether the application is in customization mode.  
  
 [in] `bHighlight`  
 Whether to draw the combo box button highlighted.  
  
 [in] `bDrawBorder`  
 Whether to draw the combo box button with a border.  
  
 [in] `bGrayDisabledButtons`  
 `TRUE` to draw shaded disabled buttons; `FALSE` to use the disabled images collection.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
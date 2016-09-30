---
title: "CMFCDropDownToolbarButton::OnDraw"
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
  - "CMFCDropDownToolbarButton::OnDraw"
  - "CMFCDropDownToolbarButton.OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: 0199fc49-77eb-4890-96f1-37ba0c07c921
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownToolbarButton::OnDraw
Called by the framework to draw the button by using the specified styles and options.  
  
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
 [in] `pDC`  
 The device context that displays the button.  
  
 [in] `rect`  
 The bounding rectangle of the button.  
  
 [in] `pImages`  
 The collection of toolbar images that is associated with the button.  
  
 [in] `bHorz`  
 The dock state of the parent toolbar. This parameter is `TRUE` when the button is docked horizontally and `FALSE` when the button is docked vertically.  
  
 [in] `bCustomizeMode`  
 Specifies whether the toolbar is in customization mode. This parameter is `TRUE` when the toolbar is in customization mode and `FALSE` when the toolbar is not in customization mode.  
  
 [in] `bHighlight`  
 Specifies whether the button is highlighted. This parameter is `TRUE` when the button is highlighted and `FALSE` when the button is not highlighted.  
  
 [in] `bDrawBorder`  
 Specifies whether the button should display its border. This parameter is `TRUE` when the button should display its border and `FALSE` when the button should not display its border.  
  
 [in] `bGrayDisabledButtons`  
 Specifies whether to shade disabled buttons or use the disabled images collection. This parameter is `TRUE` when disabled buttons should be shaded and `FALSE` when this method should use the disabled images collection.  
  
## Remarks  
 Override this method to customize toolbar button drawing.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
---
title: "CMFCRibbonColorButton::CMFCRibbonColorButton"
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
  - "CMFCRibbonColorButton.CMFCRibbonColorButton"
  - "CMFCRibbonColorButton::CMFCRibbonColorButton"
  - "CMFCRibbonColorButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonColorButton, constructor"
ms.assetid: 1002bdff-edee-4ae8-bcf6-777c52fd037b
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonColorButton::CMFCRibbonColorButton
Constructs a `CMFCRibbonColorButton` object.  
  
## Syntax  
  
```  
CMFCRibbonColorButton( );  
  
CMFCRibbonColorButton(  
   UINT nID,  
   LPCTSTR lpszText,  
   int nSmallImageIndex,  
   COLORREF color = RGB(0,0,0)  
);  
  
CMFCRibbonColorButton(  
   UINT nID,  
   LPCTSTR lpszText,  
   BOOL bSimpleButtonLook,  
   int nSmallImageIndex,  
   int nLargeImageIndex,  
   COLORREF color = RGB(0,0,0)  
);  
```  
  
#### Parameters  
 [in] `nID`  
 Specifies the command ID of the command to execute when a user clicks the button.  
  
 [in] `lpszText`  
 Specifies the text to appear on the button.  
  
 [in] `nSmallImageIndex`  
 The zero-based index of the small image to appear on the button.  
  
 [in] `color`  
 The color of the button (defaults to black).  
  
 [in] `bSimpleButtonLook`  
 If `TRUE`, the button is drawn as a simple rectangle.  
  
 [in] `nLargeImageIndex`  
 The zero-based index of the large image to appear on the button.  
  
## Return Value  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncolorbutton.h  
  
## See Also  
 [CMFCRibbonColorButton Class](../vs140/cmfcribboncolorbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
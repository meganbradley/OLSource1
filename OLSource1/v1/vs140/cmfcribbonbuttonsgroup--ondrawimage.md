---
title: "CMFCRibbonButtonsGroup::OnDrawImage"
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
  - "CMFCRibbonButtonsGroup.OnDrawImage"
  - "OnDrawImage"
  - "CMFCRibbonButtonsGroup::OnDrawImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawImage method"
ms.assetid: df847369-d47f-4289-aae4-13ed2640b0a7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButtonsGroup::OnDrawImage
Draws the appropriate image for a specified button, depending on whether the button is normal, highlighted or disabled.  
  
## Syntax  
  
```  
virtual void OnDrawImage(  
   CDC* pDC,  
   CRect rectImage,  
   CMFCRibbonBaseElement* pButton,  
   int nImageIndex  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to the device context of the `CMFCRibbonButtonsGroup` object.  
  
 [in] `rectImage`  
 The rectangle within which to draw the image.  
  
 [in] `pButton`  
 The button for which to draw the image.  
  
 [in] `nImageIndex`  
 The index of the image to draw on the button (in one of the three image arrays for normal, highlighted or disabled buttons).  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonbuttonsgroup.h  
  
## See Also  
 [CMFCRibbonButtonsGroup Class](../vs140/cmfcribbonbuttonsgroup-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
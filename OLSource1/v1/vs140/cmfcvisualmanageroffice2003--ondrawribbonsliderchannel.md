---
title: "CMFCVisualManagerOffice2003::OnDrawRibbonSliderChannel"
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
  - "CMFCVisualManagerOffice2003::OnDrawRibbonSliderChannel"
  - "OnDrawRibbonSliderChannel"
  - "CMFCVisualManagerOffice2003.OnDrawRibbonSliderChannel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonSliderChannel method"
ms.assetid: 89ca6bc6-67ac-483a-84d1-49db07ffe230
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawRibbonSliderChannel
The framework calls this method when it draws the channel of a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawRibbonSliderChannel(  
   CDC* pDC,  
   CMFCRibbonSlider* pSlider,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `pSlider`  
 A pointer to a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object. The framework draws the channel for this ribbon slider.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries for the channel of the ribbon slider.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of the channel of the ribbon slider.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
---
title: "CMFCVisualManager::OnDrawRibbonSliderChannel"
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
  - "CMFCVisualManager::OnDrawRibbonSliderChannel"
  - "CMFCVisualManager.OnDrawRibbonSliderChannel"
  - "OnDrawRibbonSliderChannel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonSliderChannel method"
ms.assetid: 70a6405e-6cfc-4ba1-bc31-db65336da7cd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonSliderChannel
The framework calls this method when it draws the channel of a [CMFCRibbonSlider Class](../vs140/cmfcribbonslider-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a CMFCRibbonSlider object. The framework draws the channel for this ribbon slider.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries for the channel of the ribbon slider.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of the channel of the ribbon slider.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonSlider Class](../vs140/cmfcribbonslider-class.md)
---
title: "CMFCVisualManagerOffice2003::OnDrawRibbonSliderThumb"
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
  - "OnDrawRibbonSliderThumb"
  - "CMFCVisualManagerOffice2003.OnDrawRibbonSliderThumb"
  - "CMFCVisualManagerOffice2003::OnDrawRibbonSliderThumb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonSliderThumb method"
ms.assetid: f2bae237-ac4c-4a00-bb29-94aa9a6d6c69
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawRibbonSliderThumb
The framework calls this method when it draws the thumb of a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md). The framework draws the thumb for this ribbon slider.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the thumb for the ribbon slider.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the thumb is highlighted.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the thumb is pressed.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the thumb is unavailable.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the thumb for a ribbon slider.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
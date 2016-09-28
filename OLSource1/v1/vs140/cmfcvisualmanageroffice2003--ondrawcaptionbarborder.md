---
title: "CMFCVisualManagerOffice2003::OnDrawCaptionBarBorder"
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
  - "CMFCVisualManagerOffice2003.OnDrawCaptionBarBorder"
  - "CMFCVisualManagerOffice2003::OnDrawCaptionBarBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawCaptionBarBorder method"
ms.assetid: 000f4aab-ac9d-40ef-a4d3-b72a6a65cca0
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawCaptionBarBorder
The framework calls this method when it draws the border of a [CMFCCaptionBar](../vs140/cmfccaptionbar-class.md) object.  
  
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
 A pointer to a [CMFCCaptionBar](../vs140/cmfccaptionbar-class.md) object. The framework draws this caption bar.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the caption bar.  
  
 [in] `clrBarBorder`  
 The color of the border.  
  
 [in] `bFlatBorder`  
 `TRUE` if the border should have a flat, 2D appearance, or `FALSE` if not.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of the border of a caption bar.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
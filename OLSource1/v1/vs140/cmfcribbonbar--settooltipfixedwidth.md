---
title: "CMFCRibbonBar::SetTooltipFixedWidth"
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
  - "CMFCRibbonBar::SetTooltipFixedWidth"
  - "SetTooltipFixedWidth"
  - "CMFCRibbonBar.SetTooltipFixedWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTooltipFixedWidth method"
ms.assetid: cabf3aa7-eb3e-4ffb-a00b-1b0bfbd3a1d9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::SetTooltipFixedWidth
Sets the regular and large sizes of tooltip fixed widths for the ribbon bar.  
  
## Syntax  
  
```  
void SetTooltipFixedWidth(  
   int nWidthRegular,  
   int nWidthLargeImage  
);  
```  
  
#### Parameters  
 [in] `nWidthRegular`  
 The width, in pixels, of a regular fixed sized tooltip.  
  
 [in] `nWidthLargeImage`  
 The width, in pixels, of a large fixed sized tooltip.  
  
## Remarks  
 Setting a parameter to 0 causes the corresponding width to vary.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
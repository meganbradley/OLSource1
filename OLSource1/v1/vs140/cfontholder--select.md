---
title: "CFontHolder::Select"
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
  - "CFontHolder.Select"
  - "CFontHolder::Select"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Select method"
ms.assetid: c7226852-5a65-4aaf-8472-76b68f88ec3b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontHolder::Select
Call this function to select your control's font into the specified device context.  
  
## Syntax  
  
```  
  
      CFont* Select(  
   CDC* pDC,  
   long cyLogical,  
   long cyHimetric   
);  
```  
  
#### Parameters  
 `pDC`  
 Device context into which the font is selected.  
  
 `cyLogical`  
 Height, in logical units, of the rectangle in which the control is drawn.  
  
 `cyHimetric`  
 Height, in `MM_HIMETRIC` units, of the control.  
  
## Return Value  
 A pointer to the font that is being replaced.  
  
## Remarks  
 See [GetFontHandle](../vs140/cfontholder--getfonthandle.md) for a discussion of the `cyLogical` and `cyHimetric` parameters.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CFontHolder Class](../vs140/cfontholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
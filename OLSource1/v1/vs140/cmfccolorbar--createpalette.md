---
title: "CMFCColorBar::CreatePalette"
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
  - "CMFCColorBar::CreatePalette"
  - "CreatePalette"
  - "CMFCColorBar.CreatePalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePalette method"
  - "CMFCColorBar::CreatePalette"
ms.assetid: 48c716a6-802f-49c9-898e-a6968203b794
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::CreatePalette
Initializes a palette with the colors in a specified array of colors.  
  
## Syntax  
  
```  
static BOOL CreatePalette(  
   const CArray<COLORREF, COLORREF>& arColors,   
   CPalette& palette  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `arColors`|An array of colors.|  
|[in] `palette`|A palette of colors.|  
  
## Return Value  
 `TRUE` if this method is successful; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [CPalette Class](../vs140/cpalette-class.md)
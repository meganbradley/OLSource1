---
title: "CMFCColorBar::InitColors"
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
  - "CMFCColorBar::InitColors"
  - "CMFCColorBar.InitColors"
  - "InitColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitColors method"
  - "CMFCColorBar::InitColors"
ms.assetid: 4b376add-24f9-4542-ad87-086c51e329d5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::InitColors
Initializes an array of colors with the colors in a specified palette, or with the system default palette.  
  
## Syntax  
  
```  
static int InitColors(  
   CPalette* pPalette,   
   CArray<COLORREF, COLORREF>& arColors  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pPalette`|A pointer to a palette object, or `NULL`. If this parameter is `NULL`, this method uses the default palette of the operating system.|  
|[in] `arColors`|An array of colors.|  
  
## Return Value  
 The number of elements in the array of colors.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [CPalette Class](../vs140/cpalette-class.md)
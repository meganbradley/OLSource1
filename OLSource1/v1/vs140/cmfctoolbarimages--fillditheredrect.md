---
title: "CMFCToolBarImages::FillDitheredRect"
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
  - "CMFCToolBarImages::FillDitheredRect"
  - "CMFCToolBarImages.FillDitheredRect"
  - "FillDitheredRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillDitheredRect method"
ms.assetid: a5e3a982-c9c9-4165-8635-28a3bd129858
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::FillDitheredRect
Fills a rectangle with the toolbar background colors.  
  
## Syntax  
  
```  
static void FillDitheredRect(  
   CDC* pDC,  
   const CRect& rect   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 The coordinates of a rectangle to fill.  
  
## Remarks  
 Use this method to fill a rectangle with a color that is the average of the system colors COLOR_BTNFACE and COLOR_BTNHIGHLIGHT. If the system is using 256 or fewer colors, the rectangle will be filled with a dithered pattern of those two colors instead.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
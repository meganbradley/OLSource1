---
title: "CDrawingManager::Fill4ColorsGradient"
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
  - "Fill4ColorsGradient"
  - "CDrawingManager::Fill4ColorsGradient"
  - "CDrawingManager.Fill4ColorsGradient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Fill4ColorsGradient method"
ms.assetid: f2ca6395-f07f-4976-99b4-00f0da6f6a21
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::Fill4ColorsGradient
Fills a rectangular area with two color gradients.  
  
## Syntax  
  
```  
void Fill4ColorsGradient(  
   CRect rect,  
   COLORREF colorStart1,  
   COLORREF colorFinish1,  
   COLORREF colorStart2,  
   COLORREF colorFinish2,  
   BOOL bHorz = TRUE,  
   int nPercentage = 50  
);  
```  
  
#### Parameters  
 [in] `rect`  
 The rectangle to fill.  
  
 [in] `colorStart1`  
 The initial color for the first color gradient.  
  
 [in] `colorFinish1`  
 The final color for the first color gradient.  
  
 [in] `colorStart2`  
 The initial color for the second color gradient.  
  
 [in] `colorFinish2`  
 The final color for the second color gradient.  
  
 [in] `bHorz`  
 A Boolean parameter that indicates whether `Fill4ColorsGradient` colors a horizontal or vertical gradient. `TRUE` indicates a horizontal gradient.  
  
 [in] `nPercentage`  
 An integer from 0-100. This value indicates the percentage of the rectangle to fill with the first color gradient.  
  
## Remarks  
 When a rectangle is filled with two color gradients, they are either located above each other or next to each other, depending on the value of `bHorz`. Each color gradient is calculated independently with the method [CDrawingManager::FillGradient](../vs140/cdrawingmanager--fillgradient.md).  
  
 This method generates an assertion failure if `nPercentage` is less than 0 or more than 100.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
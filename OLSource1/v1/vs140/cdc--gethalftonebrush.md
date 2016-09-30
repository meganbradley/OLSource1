---
title: "CDC::GetHalftoneBrush"
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
  - "GetHalftoneBrush"
  - "CDC::GetHalftoneBrush"
  - "CDC.GetHalftoneBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHalftoneBrush method"
  - "CDC class, color and color palette functions"
ms.assetid: 8592d5f3-dc4a-486c-aa0c-2f6014e4ce3f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetHalftoneBrush
Call this member function to retrieve a halftone brush.  
  
## Syntax  
  
```  
  
static CBrush* PASCAL GetHalftoneBrush( );  
  
```  
  
## Return Value  
 A pointer to a `CBrush` object if successful; otherwise **NULL**.  
  
## Remarks  
 A halftone brush shows pixels that are alternately foreground and background colors to create a dithered pattern. The following is an example of a dithered pattern created by a halftone brush.  
  
 ![Detail of a dithered pen stroke](../vs140/media/vc318s1.gif "vc318S1")  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush Class](../vs140/cbrush-class.md)
---
title: "CDrawingManager::MirrorRect"
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
  - "MirrorRect"
  - "CDrawingManager.MirrorRect"
  - "CDrawingManager::MirrorRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MirrorRect method"
ms.assetid: 90917834-3576-4dd5-878b-9d4b47018f96
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::MirrorRect
Flips a rectangular area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The bounding rectangle of the area to flip.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the rectangle flips horizontally or vertically.  
  
## Remarks  
 This method can flip any area of the device context owned by the [CDrawingManager Class](../vs140/cdrawingmanager-class.md). If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, this method flips the area horizontally. Otherwise, it flips the area vertically.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
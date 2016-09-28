---
title: "CD2DRectU::CD2DRectU"
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
  - "afxrendertarget/CD2DRectU::CD2DRectU"
  - "CD2DRectU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DRectU class, constructor"
ms.assetid: c88d569c-bdfc-4c19-94fd-018b0ff435df
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DRectU::CD2DRectU
Constructs a CD2DRectU object from CRect object.  
  
## Syntax  
  
```  
CD2DRectU(  
   const CRect& rect  
);  
CD2DRectU(  
   const D2D1_RECT_U& rect  
);  
CD2DRectU(  
   const D2D1_RECT_U* rect  
);  
CD2DRectU(  
   UINT32 uLeft = 0,  
   UINT32 uTop = 0,  
   UINT32 uRight = 0,  
   UINT32 uBottom = 0  
);  
```  
  
#### Parameters  
 `rect`  
 source rectangle  
  
 `uLeft`  
 source left coordinate  
  
 `uTop`  
 source top coordinate  
  
 `uRight`  
 source right coordinate  
  
 `uBottom`  
 source bottom coordinate  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DRectU Class](../vs140/cd2drectu-class.md)
---
title: "CD2DPointU::CD2DPointU"
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
  - "CD2DPointU"
  - "afxrendertarget/CD2DPointU::CD2DPointU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DPointU class, constructor"
ms.assetid: 5ebf0ff4-2142-4fbb-a0b5-953cb3b67165
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DPointU::CD2DPointU
Constructs a CD2DPointU object from CPoint object.  
  
## Syntax  
  
```  
CD2DPointU(  
   const CPoint& pt  
);  
CD2DPointU(  
   const D2D1_POINT_2U& pt  
);  
CD2DPointU(  
   const D2D1_POINT_2U* pt  
);  
CD2DPointU(  
   UINT32 uX = 0,  
   UINT32 uY = 0  
);  
```  
  
#### Parameters  
 `pt`  
 source point  
  
 `uX`  
 source X  
  
 `uY`  
 source Y  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DPointU Class](../vs140/cd2dpointu-class.md)
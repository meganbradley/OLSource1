---
title: "CD2DPointF::CD2DPointF"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CD2DPointF
  - afxrendertarget/CD2DPointF::CD2DPointF
dev_langs: 
  - C++
helpviewer_keywords: 
  - CD2DPointF class, constructor
ms.assetid: 915dace3-daaa-4016-955c-46a1f4ff0244
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DPointF::CD2DPointF
Constructs a CD2DPointF object from CPoint object.  
  
## Syntax  
  
```  
CD2DPointF(  
   const CPoint& pt  
);  
CD2DPointF(  
   const D2D1_POINT_2F& pt  
);  
CD2DPointF(  
   const D2D1_POINT_2F* pt  
);  
CD2DPointF(  
   FLOAT fX = 0.,  
   FLOAT fY = 0.  
);  
```  
  
#### Parameters  
 `pt`  
 source point  
  
 `fX`  
 source X  
  
 `fY`  
 source Y  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DPointF Class](../vs140/cd2dpointf-class.md)
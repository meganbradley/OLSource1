---
title: "CD2DPathGeometry::CD2DPathGeometry"
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
  - afxrendertarget/CD2DPathGeometry::CD2DPathGeometry
  - CD2DPathGeometry
dev_langs: 
  - C++
helpviewer_keywords: 
  - CD2DPathGeometry class, constructor
ms.assetid: c1f4cca5-d034-4d34-9fd0-be526b273306
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DPathGeometry::CD2DPathGeometry
Constructs a CD2DPathGeometry object.  
  
## Syntax  
  
```  
CD2DPathGeometry(  
   CRenderTarget* pParentTarget,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DPathGeometry Class](../vs140/cd2dpathgeometry-class.md)
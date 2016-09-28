---
title: "CD2DGeometry::CD2DGeometry"
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
  - "afxrendertarget/CD2DGeometry::CD2DGeometry"
  - "CD2DGeometry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DGeometry class, constructor"
ms.assetid: b04bb80b-f5e2-4642-9d19-02b3076f0901
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::CD2DGeometry
Constructs a CD2DGeometry object.  
  
## Syntax  
  
```  
CD2DGeometry(  
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
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)
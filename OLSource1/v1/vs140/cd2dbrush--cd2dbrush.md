---
title: "CD2DBrush::CD2DBrush"
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
  - afxrendertarget/CD2DBrush::CD2DBrush
  - CD2DBrush
dev_langs: 
  - C++
helpviewer_keywords: 
  - CD2DBrush class, constructor
ms.assetid: ce5681e2-4701-4b17-80e1-8a254e834a7a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DBrush::CD2DBrush
Constructs a CD2DBrush object.  
  
## Syntax  
  
```  
CD2DBrush(  
   CRenderTarget* pParentTarget,  
   CD2DBrushProperties* pBrushProperties = NULL,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `pBrushProperties`  
 A pointer to the opacity and transformation of a brush.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBrush Class](../vs140/cd2dbrush-class.md)
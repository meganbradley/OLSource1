---
title: "CD2DLayer::CD2DLayer"
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
  - afxrendertarget/CD2DLayer::CD2DLayer
  - CD2DLayer
dev_langs: 
  - C++
helpviewer_keywords: 
  - CD2DLayer class, constructor
ms.assetid: fe6e9135-60fc-4df5-9486-2fb5e55194ad
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DLayer::CD2DLayer
Constructs a CD2DLayer object.  
  
## Syntax  
  
```  
CD2DLayer(  
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
 [CD2DLayer Class](../vs140/cd2dlayer-class.md)
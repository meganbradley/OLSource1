---
title: "CD2DMesh::CD2DMesh"
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
  - "afxrendertarget/CD2DMesh::CD2DMesh"
  - "CD2DMesh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DMesh class, constructor"
ms.assetid: b2ed5b57-b985-43c6-a96e-9283353868ad
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DMesh::CD2DMesh
Constructs a CD2DMesh object.  
  
## Syntax  
  
```  
CD2DMesh(  
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
 [CD2DMesh Class](../vs140/cd2dmesh-class.md)
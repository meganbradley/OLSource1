---
title: "CRenderTarget::FillMesh"
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
  - "afxrendertarget/CRenderTarget::FillMesh"
  - "FillMesh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillMesh method"
ms.assetid: 17373d1f-8707-45b2-8c32-5aac9da0c091
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::FillMesh
Paints the interior of the specified mesh.  
  
## Syntax  
  
```  
void FillMesh(  
   CD2DMesh* pMesh,  
   CD2DBrush* pBrush  
);  
```  
  
#### Parameters  
 `pMesh`  
 The mesh to paint.  
  
 `pBrush`  
 The brush used to paint the mesh.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)
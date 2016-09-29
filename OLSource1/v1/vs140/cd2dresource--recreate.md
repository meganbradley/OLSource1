---
title: "CD2DResource::ReCreate"
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
  - "afxrendertarget/CD2DResource::ReCreate"
  - "ReCreate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReCreate method"
ms.assetid: 09a41f5b-bf06-4f02-9dd5-11dc444bd78c
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DResource::ReCreate
Re-creates a CD2DResource.  
  
## Syntax  
  
```  
virtual HRESULT ReCreate(  
   CRenderTarget* pRenderTarget  
);  
```  
  
#### Parameters  
 `pRenderTarget`  
 A pointer to the render target.  
  
## Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DResource Class](../vs140/cd2dresource-class.md)
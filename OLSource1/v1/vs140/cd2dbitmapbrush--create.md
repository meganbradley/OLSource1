---
title: "CD2DBitmapBrush::Create"
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
  - "Create"
  - "afxrendertarget/CD2DBitmapBrush::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 6bda57e8-da72-4d6d-b03a-c89862ed5949
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBitmapBrush::Create
Creates a CD2DBitmapBrush.  
  
## Syntax  
  
```  
virtual HRESULT Create(  
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
 [CD2DBitmapBrush Class](../vs140/cd2dbitmapbrush-class.md)
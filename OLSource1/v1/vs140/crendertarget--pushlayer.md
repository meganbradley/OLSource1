---
title: "CRenderTarget::PushLayer"
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
  - "afxrendertarget/CRenderTarget::PushLayer"
  - "PushLayer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PushLayer method"
ms.assetid: dcab8b72-8adb-4581-80f3-ec8d29c1f1b0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::PushLayer
Adds the specified layer to the render target so that it receives all subsequent drawing operations until PopLayer is called.  
  
## Syntax  
  
```  
void PushLayer(  
   const D2D1_LAYER_PARAMETERS& layerParameters,  
   CD2DLayer& layer  
);  
```  
  
#### Parameters  
 `layerParameters`  
 The content bounds, geometric mask, opacity, opacity mask, and antialiasing options for the layer.  
  
 `layer`  
 The layer that receives subsequent drawing operations.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)
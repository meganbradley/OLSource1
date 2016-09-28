---
title: "CRenderTarget::Attach"
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
  - "afxrendertarget/CRenderTarget::Attach"
  - "Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method"
ms.assetid: a77758c8-fb8b-4325-8c34-3ef938bbcc89
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::Attach
Attaches existing render target interface to the object  
  
## Syntax  
  
```  
void Attach(  
   ID2D1RenderTarget* pRenderTarget  
);  
```  
  
#### Parameters  
 `pRenderTarget`  
 Existing render target interface. Cannot be NULL  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)
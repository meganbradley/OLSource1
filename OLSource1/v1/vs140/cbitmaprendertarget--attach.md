---
title: "CBitmapRenderTarget::Attach"
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
  - "Attach"
  - "afxrendertarget/CBitmapRenderTarget::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method"
ms.assetid: f6af564a-0ce3-4d17-a082-dbb32e276b94
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmapRenderTarget::Attach
Attaches existing render target interface to the object  
  
## Syntax  
  
```  
void Attach(  
   ID2D1BitmapRenderTarget* pTarget  
);  
```  
  
#### Parameters  
 `pTarget`  
 Existing render target interface. Cannot be NULL  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CBitmapRenderTarget Class](../vs140/cbitmaprendertarget-class.md)
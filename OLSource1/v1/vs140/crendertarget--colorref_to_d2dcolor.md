---
title: "CRenderTarget::COLORREF_TO_D2DCOLOR"
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
  - "COLORREF_TO_D2DCOLOR"
  - "afxrendertarget/CRenderTarget::COLORREF_TO_D2DCOLOR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COLORREF_TO_D2DCOLOR method"
ms.assetid: 926a8ad2-96be-4934-817d-c6df5bc692d8
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::COLORREF_TO_D2DCOLOR
Converts GDI color and alpha values to the D2D1_COLOR_F object.  
  
## Syntax  
  
```  
static D2D1_COLOR_F COLORREF_TO_D2DCOLOR(  
   COLORREF color,  
   int nAlpha = 255  
);  
```  
  
#### Parameters  
 `color`  
 RGB value.  
  
 `nAlpha`  
  
## Return Value  
 D2D1_COLOR_F value.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)
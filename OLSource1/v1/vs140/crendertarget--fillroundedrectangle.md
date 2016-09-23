---
title: "CRenderTarget::FillRoundedRectangle"
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
  - afxrendertarget/CRenderTarget::FillRoundedRectangle
  - FillRoundedRectangle
dev_langs: 
  - C++
helpviewer_keywords: 
  - FillRoundedRectangle method
ms.assetid: 4037ae68-e4cd-4eb2-b19f-57f8aa1baeb6
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRenderTarget::FillRoundedRectangle
Paints the interior of the specified rounded rectangle.  
  
## Syntax  
  
```  
void FillRoundedRectangle(  
   const CD2DRoundedRect& rectRounded,  
   CD2DBrush* pBrush  
);  
```  
  
#### Parameters  
 `rectRounded`  
 The dimensions of the rounded rectangle to paint, in device independent pixels.  
  
 `pBrush`  
 The brush used to paint the interior of the rounded rectangle.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)
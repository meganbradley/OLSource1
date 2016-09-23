---
title: "CRenderTarget::PushAxisAlignedClip"
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
  - afxrendertarget/CRenderTarget::PushAxisAlignedClip
  - PushAxisAlignedClip
dev_langs: 
  - C++
helpviewer_keywords: 
  - PushAxisAlignedClip method
ms.assetid: 31a66236-aac5-40f9-a42d-f4521b00fcb6
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRenderTarget::PushAxisAlignedClip
Removes the last axis-aligned clip from the render target. After this method is called, the clip is no longer applied to subsequent drawing operations.  
  
## Syntax  
  
```  
void PushAxisAlignedClip(  
   const CD2DRectF& rectClip,  
   D2D1_ANTIALIAS_MODE mode = D2D1_ANTIALIAS_MODE_PER_PRIMITIVE  
);  
```  
  
#### Parameters  
 `rectClip`  
 The size and position of the clipping area, in device-independent pixels.  
  
 `mode`  
 The antialiasing mode that is used to draw the edges of clip rects that have subpixel boundaries, and to blend the clip with the scene contents. The blending is performed once when the PopAxisAlignedClip method is called, and does not apply to each primitive within the layer.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)
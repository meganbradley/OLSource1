---
title: "CD2DBitmap::CopyFromMemory"
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
  - "CopyFromMemory"
  - "afxrendertarget/CD2DBitmap::CopyFromMemory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyFromMemory method"
ms.assetid: 5fe55ddb-e9bc-411a-9066-87b4d3702014
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBitmap::CopyFromMemory
Copies the specified region from memory into the current bitmap  
  
## Syntax  
  
```  
HRESULT CopyFromMemory(  
   const void *srcData,  
   UINT32 pitch,  
   const CD2DRectU* destRect = NULL  
);  
```  
  
#### Parameters  
 `srcData`  
 The data to copy  
  
 `pitch`  
 The stride, or pitch, of the source bitmap stored in srcData. The stride is the byte count of a scanline (one row of pixels in memory). The stride can be computed from the following formula: pixel width * bytes per pixel + memory padding  
  
 `destRect`  
 In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied  
  
## Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBitmap Class](../vs140/cd2dbitmap-class.md)
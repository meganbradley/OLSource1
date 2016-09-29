---
title: "CBitmap::CreateBitmap"
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
  - "CreateBitmap"
  - "CBitmap::CreateBitmap"
  - "CBitmap.CreateBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateBitmap method"
ms.assetid: a769e4a7-360a-495b-89b1-161a133fd66d
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmap::CreateBitmap
Initializes a device-dependent memory bitmap that has the specified width, height, and bit pattern.  
  
## Syntax  
  
```  
  
BOOL CreateBitmap(  
   int nWidth,  
   int nHeight,  
   UINT nPlanes,  
   UINT nBitcount,  
   const void* lpBits   
);  
```  
  
#### Parameters  
 `nWidth`  
 Specifies the width (in pixels) of the bitmap.  
  
 `nHeight`  
 Specifies the height (in pixels) of the bitmap.  
  
 `nPlanes`  
 Specifies the number of color planes in the bitmap.  
  
 `nBitcount`  
 Specifies the number of color bits per display pixel.  
  
 `lpBits`  
 Points to an array of bytes that contains the initial bitmap bit values. If it is **NULL**, the new bitmap is left uninitialized.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 For a color bitmap, either the `nPlanes` or `nBitcount` parameter should be set to 1. If both of these parameters are set to 1, `CreateBitmap` creates a monochrome bitmap.  
  
 Although a bitmap cannot be directly selected for a display device, it can be selected as the current bitmap for a "memory device context" by using [CDC::SelectObject](../vs140/cdc--selectobject.md) and copied to any compatible device context by using the [CDC::BitBlt](../vs140/cdc--bitblt.md) function.  
  
 When you finish with the `CBitmap` object created by the `CreateBitmap` function, first select the bitmap out of the device context, then delete the `CBitmap` object.  
  
 For more information, see the description of the **bmBits** field in the **BITMAP** structure. The [BITMAP](../vs140/bitmap-structure.md) structure is described under the [CBitmap::CreateBitmapIndirect](../vs140/cbitmap--createbitmapindirect.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SelectObject](../vs140/cdc--selectobject.md)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)   
 [CDC::BitBlt](../vs140/cdc--bitblt.md)   
 [CreateBitmap](http://msdn.microsoft.com/library/windows/desktop/dd183485)
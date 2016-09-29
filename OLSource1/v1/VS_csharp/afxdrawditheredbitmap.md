---
title: "AfxDrawDitheredBitmap"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxDrawDitheredBitmap"
  - "AFXWIN/AfxDrawDitheredBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxDrawDitheredBitmap function"
ms.assetid: b41e9c4b-b567-4e3c-b8e0-b45e9dd1a7a3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxDrawDitheredBitmap
Draws a bitmap, replacing its background with a dithered (checker) pattern.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxDrawDitheredBitmap(  
   CDC *pDC,  
   int x,  
   int y,  
   const CBitmap &rSrc,  
   COLORREF cr1,  
   COLORREF cr2  
);  
```  
  
#### Parameters  
 `pDC`  
 Points to the destination DC.  
  
 *x*  
 The destination x-coordinate.  
  
 *y*  
 The destination y-coordinate.  
  
 `rSrc`  
 The source bitmap.  
  
 `cr1`  
 One of the two dither colors, typically white.  
  
 `cr2`  
 The other dither color, typically light gray (COLOR_MENU).  
  
## Remarks  
 The source bitmap is drawn on the destination DC with a two-color (`cr1` and `cr2`) checkered pattern replacing the bitmap's background. The background of the source bitmap is defined as its white pixels and all pixels matching the color of the pixel in the upper-left corner of the bitmap.  
  
 ![Comparison of dithered and original icon versions](../VS_csharp/media/vcditheredbitmap.gif "vcDitheredBitmap")  
  
## Example  
 [!code[NVC_MFCDocView#190](../VS_csharp/codesnippet/CPP/afxdrawditheredbitmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [Gray and Dithered Bitmap Functions](../VS_csharp/gray-and-dithered-bitmap-functions.md)   
 [AfxGetDitheredBitmap](../VS_csharp/afxgetditheredbitmap.md)   
 [AfxDrawGrayBitmap](../VS_csharp/afxdrawgraybitmap.md)
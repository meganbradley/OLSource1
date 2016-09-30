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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the destination DC.  
  
 *x*  
 The destination x-coordinate.  
  
 *y*  
 The destination y-coordinate.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The source bitmap.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 One of the two dither colors, typically white.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The other dither color, typically light gray (COLOR_MENU).  
  
## Remarks  
 The source bitmap is drawn on the destination DC with a two-color (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) checkered pattern replacing the bitmap's background. The background of the source bitmap is defined as its white pixels and all pixels matching the color of the pixel in the upper-left corner of the bitmap.  
  
 ![Comparison of dithered and original icon versions](../vs140/media/vcditheredbitmap.gif "vcDitheredBitmap")  
  
## Example  
 [!code[NVC_MFCDocView#190](../vs140/codesnippet/CPP/afxdrawditheredbitmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Gray and Dithered Bitmap Functions](../vs140/gray-and-dithered-bitmap-functions.md)   
 [AfxGetDitheredBitmap](../vs140/afxgetditheredbitmap.md)   
 [AfxDrawGrayBitmap](../vs140/afxdrawgraybitmap.md)
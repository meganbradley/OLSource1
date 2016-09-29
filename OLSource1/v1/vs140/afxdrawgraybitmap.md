---
title: "AfxDrawGrayBitmap"
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
  - "AfxDrawGrayBitmap"
  - "AFXWIN/AfxDrawGrayBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxDrawGrayBitmap function"
ms.assetid: 90e0afce-933b-4422-8bba-7b211c5d52ca
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxDrawGrayBitmap
Draws a gray version of a bitmap.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxDrawGrayBitmap(  
   CDC *pDC,  
   int x,  
   int y,  
   const CBitmap &rSrc,  
   COLORREF crBackground  
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
  
 `crBackground`  
 The new background color (typically gray, such as COLOR_MENU).  
  
## Remarks  
 A bitmap drawn with `AfxDrawGrayBitmap` will have the appearance of a disabled control.  
  
 ![Comparison of gray and original icon versions](../vs140/media/vcgraybitmap.gif "vcGrayBitmap")  
  
## Example  
 [!code[NVC_MFCDocView#191](../vs140/codesnippet/CPP/afxdrawgraybitmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Gray and Dithered Bitmap Functions](../vs140/gray-and-dithered-bitmap-functions.md)   
 [AfxGetGrayBitmap](../vs140/afxgetgraybitmap.md)   
 [AfxDrawDitheredBitmap](../vs140/afxdrawditheredbitmap.md)
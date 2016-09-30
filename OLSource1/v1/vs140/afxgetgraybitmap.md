---
title: "AfxGetGrayBitmap"
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
  - "AFXWIN/AfxGetGrayBitmap"
  - "AfxGetGrayBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxGetGrayBitmap function"
ms.assetid: 4f48b35e-c6d5-4f3f-a86a-b5979f965b1b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxGetGrayBitmap
Copies a gray version of a bitmap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The source bitmap.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The destination bitmap.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The new background color (typically gray, such as COLOR_MENU).  
  
## Remarks  
 A bitmap copied with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will have the appearance of a disabled control.  
  
 ![Comparison of gray and original icon versions](../vs140/media/vcgraybitmap.gif "vcGrayBitmap")  
  
## Example  
 [!code[NVC_MFCDocView#193](../vs140/codesnippet/CPP/afxgetgraybitmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Gray and Dithered Bitmap Functions](../vs140/gray-and-dithered-bitmap-functions.md)   
 [AfxDrawGrayBitmap](../vs140/afxdrawgraybitmap.md)   
 [AfxGetDitheredBitmap](../vs140/afxgetditheredbitmap.md)
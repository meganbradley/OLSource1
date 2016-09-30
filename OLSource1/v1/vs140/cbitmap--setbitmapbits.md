---
title: "CBitmap::SetBitmapBits"
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
  - "CBitmap.SetBitmapBits"
  - "SetBitmapBits"
  - "CBitmap::SetBitmapBits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBitmapBits method"
ms.assetid: 36b3b068-09f4-45d9-8eea-6c3757dcc74d
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmap::SetBitmapBits
Sets the bits of a bitmap to the bit values given by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of bytes pointed to by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to the **BYTE** array that contains the pixel values to be copied to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. In order for the bitmap to be able to render its image correctly, the values should be formatted to conform to the height, width and color depth values that were specified when the CBitmap instance was created. For more information, see [CBitmap::CreateBitmap](../vs140/cbitmap--createbitmap.md).  
  
## Return Value  
 The number of bytes used in setting the bitmap bits; 0 if the function fails.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SetBitmapBits](http://msdn.microsoft.com/library/windows/desktop/dd162962)
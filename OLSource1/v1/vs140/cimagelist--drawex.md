---
title: "CImageList::DrawEx"
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
  - "DrawEx"
  - "CImageList.DrawEx"
  - "CImageList::DrawEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawEx method"
ms.assetid: 65b63d87-0fad-46d1-a207-ea6b9915dfa0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::DrawEx
Draws an image list item in the specified device context.  
  
## Syntax  
  
```  
  
      BOOL DrawEx(  
   CDC* pDC,  
   int nImage,  
   POINT pt,  
   SIZE sz,  
   COLORREF clrBk,  
   COLORREF clrFg,  
   UINT nStyle   
);  
```  
  
#### Parameters  
 `pDC`  
 Pointer to the destination device context.  
  
 `nImage`  
 Zero-based index of the image to draw.  
  
 `pt`  
 Location at which to draw within the specified device context.  
  
 `sz`  
 Size of the portion of the image to draw relative to the upper-left corner of the image. See `dx` and *dy* in [ImageList_DrawEx](http://msdn.microsoft.com/library/windows/desktop/bb761536) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 *clrBk*  
 Background color of the image. See *rgbBk* in [ImageList_DrawEx](http://msdn.microsoft.com/library/windows/desktop/bb761536) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 *clrFg*  
 Foreground color of the image. See *rgbFg* in [ImageList_DrawEx](http://msdn.microsoft.com/library/windows/desktop/bb761536) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 `nStyle`  
 Flag specifying the drawing style. See *fStyle* in [ImageList_DrawEx](http://msdn.microsoft.com/library/windows/desktop/bb761536) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The function uses the specified drawing style and blends the image with the specified color.  
  
## Example  
 [!code[NVC_MFC_CImageList#10](../vs140/codesnippet/CPP/cimagelist--drawex_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::BeginDrag](../vs140/cimagelist--begindrag.md)   
 [CImageList::EndDrag](../vs140/cimagelist--enddrag.md)   
 [CImageList::DragMove](../vs140/cimagelist--dragmove.md)   
 [CImageList::Draw](../vs140/cimagelist--draw.md)
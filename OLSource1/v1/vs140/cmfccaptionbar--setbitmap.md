---
title: "CMFCCaptionBar::SetBitmap"
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
  - "SetBitmap"
  - "CMFCCaptionBar::SetBitmap"
  - "CMFCCaptionBar.SetBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBitmap method"
ms.assetid: 10a98402-ceb9-481d-bd23-12a9f9ddf20a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::SetBitmap
Sets the bitmap image for the caption bar.  
  
## Syntax  
  
```  
void SetBitmap(  
   HBITMAP hBitmap,  
   COLORREF clrTransparent,  
   BOOL bStretch=FALSE,  
   BarElementAlignment bmpAlignment=ALIGN_RIGHT   
);  
void SetBitmap(  
   UINT uiBmpResID,  
   COLORREF clrTransparent,  
   BOOL bStretch=FALSE,  
   BarElementAlignment bmpAlignment=ALIGN_RIGHT   
);  
```  
  
#### Parameters  
 [in] `hBitmap`  
 The handle to the bitmap to set.  
  
 [in] `clrTransparent`  
 An RGB value that specifies the transparent color of the bitmap.  
  
 [in] `bStretch`  
 If `TRUE`, the bitmap is stretched if it does not fit to the image bounding rectangle. Otherwise the bitmap is not stretched.  
  
 [in] `bmpAlignment`  
 The alignment of the bitmap.  
  
## Remarks  
 Use this method to set a bitmap on a caption bar.  
  
 The previous bitmap is destroyed automatically. If the caption bar displays an icon because you called the [CMFCCaptionBar::SetIcon](../vs140/cmfccaptionbar--seticon.md) method, the bitmap will not be displayed unless you remove the icon by calling [CMFCCaptionBar::RemoveIcon](../vs140/cmfccaptionbar--removeicon.md).  
  
 The bitmap is aligned as specified by the `bmpAlignment` parameter.  This parameter can be one of the following `BarElementAlignment` values:  
  
-   ALIGN_INVALID  
  
-   ALIGN_LEFT  
  
-   ALIGN_RIGHT  
  
-   ALIGN_CENTER  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
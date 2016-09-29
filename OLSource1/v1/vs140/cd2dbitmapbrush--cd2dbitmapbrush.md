---
title: "CD2DBitmapBrush::CD2DBitmapBrush"
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
  - "CD2DBitmapBrush"
  - "afxrendertarget/CD2DBitmapBrush::CD2DBitmapBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DBitmapBrush class, constructor"
ms.assetid: 8125ffb4-e1de-4bdc-a89c-efc91bc39b1d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBitmapBrush::CD2DBitmapBrush
Constructs a CD2DBitmapBrush object.  
  
## Syntax  
  
```  
CD2DBitmapBrush(  
   CRenderTarget* pParentTarget,  
   D2D1_BITMAP_BRUSH_PROPERTIES* pBitmapBrushProperties = NULL,  
   CD2DBrushProperties* pBrushProperties = NULL,  
   BOOL bAutoDestroy = TRUE  
);  
CD2DBitmapBrush(  
   CRenderTarget* pParentTarget,  
   UINT uiResID,  
   LPCTSTR lpszType = NULL,  
   CD2DSizeU sizeDest = CD2DSizeU(0,  
   0),  
   D2D1_BITMAP_BRUSH_PROPERTIES* pBitmapBrushProperties = NULL,  
   CD2DBrushProperties* pBrushProperties = NULL,  
   BOOL bAutoDestroy = TRUE  
);  
CD2DBitmapBrush(  
   CRenderTarget* pParentTarget,  
   LPCTSTR lpszImagePath,  
   CD2DSizeU sizeDest = CD2DSizeU(0,  
   0),  
   D2D1_BITMAP_BRUSH_PROPERTIES* pBitmapBrushProperties = NULL,  
   CD2DBrushProperties* pBrushProperties = NULL,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `pBitmapBrushProperties`  
 A pointer to the extend modes and the interpolation mode of a bitmap brush.  
  
 `pBrushProperties`  
 A pointer to the opacity and transformation of a brush.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
 `uiResID`  
 The resource ID number of the resource.  
  
 `lpszType`  
 Pointer to a null-terminated string that contains the resource type.  
  
 `sizeDest`  
 Destination size of the bitmap.  
  
 `lpszImagePath`  
 Pointer to a null-terminated string that contains the name of file.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBitmapBrush Class](../vs140/cd2dbitmapbrush-class.md)
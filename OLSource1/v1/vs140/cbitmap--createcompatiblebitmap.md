---
title: "CBitmap::CreateCompatibleBitmap"
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
  - "CBitmap::CreateCompatibleBitmap"
  - "CBitmap.CreateCompatibleBitmap"
  - "CreateCompatibleBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateCompatibleBitmap method"
ms.assetid: 354bbd19-ef9d-4d18-aa3d-c1574501cd13
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmap::CreateCompatibleBitmap
Initializes a bitmap that is compatible with the device specified by `pDC`.  
  
## Syntax  
  
```  
  
      BOOL CreateCompatibleBitmap(  
   CDC* pDC,  
   int nWidth,  
   int nHeight   
);  
```  
  
#### Parameters  
 `pDC`  
 Specifies the device context.  
  
 `nWidth`  
 Specifies the width (in pixels) of the bitmap.  
  
 `nHeight`  
 Specifies the height (in pixels) of the bitmap.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The bitmap has the same number of color planes or the same bits-per-pixel format as the specified device context. It can be selected as the current bitmap for any memory device that is compatible with the one specified by `pDC`.  
  
 If `pDC` is a memory device context, the bitmap returned has the same format as the currently selected bitmap in that device context. A "memory device context" is a block of memory that represents a display surface. It can be used to prepare images in memory before copying them to the actual display surface of the compatible device.  
  
 When a memory device context is created, GDI automatically selects a monochrome stock bitmap for it.  
  
 Since a color memory device context can have either color or monochrome bitmaps selected, the format of the bitmap returned by the `CreateCompatibleBitmap` function is not always the same; however, the format of a compatible bitmap for a nonmemory device context is always in the format of the device.  
  
 When you finish with the `CBitmap` object created with the `CreateCompatibleBitmap` function, first select the bitmap out of the device context, then delete the `CBitmap` object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CreateCompatibleBitmap](http://msdn.microsoft.com/library/windows/desktop/dd183488)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)
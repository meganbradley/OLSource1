---
title: "CStatic::SetBitmap"
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
  - "CStatic.SetBitmap"
  - "CStatic::SetBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStatic class, operations"
  - "SetBitmap method"
ms.assetid: 943e0dbb-63a2-456d-8dc3-c7b5a2111300
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatic::SetBitmap
Associates a new bitmap with the static control.  
  
## Syntax  
  
```  
HBITMAP SetBitmap(  
   HBITMAP hBitmap   
);  
```  
  
#### Parameters  
 `hBitmap`  
 Handle of the bitmap to be drawn in the static control.  
  
## Return Value  
 The handle of the bitmap that was previously associated with the static control, or `NULL` if no bitmap was associated with the static control.  
  
## Remarks  
 The bitmap will be automatically drawn in the static control. By default, it will be drawn in the upper-left corner and the static control will be resized to the size of the bitmap.  
  
 You can use various window and static control styles, including these:  
  
-   SS_BITMAP   Use this style always for bitmaps.  
  
-   SS_CENTERIMAGE   Use to center the image in the static control. If the image is larger than the static control, it will be clipped. If it is smaller than the static control, the empty space around the image will be filled by the color of the pixel in the upper left corner of the bitmap.  
  
-   MFC provides the class `CBitmap`, which you can use when you have to do more with a bitmap image than just call the Win32 function `LoadBitmap`. `CBitmap`, which contains one kind of GDI object, is often used in cooperation with `CStatic`, which is a `CWnd` class that is used for displaying a graphic object as a static control.  
  
 `CImage` is an ATL/MFC class that lets you more easily work with device independent bitmaps (DIB). For more information, see [CImage Class](../vs140/cimage-class.md).  
  
-   Typical usage is to give `CStatic::SetBitmap` a GDI object that is returned by the HBITMAP operator of a `CBitmap` or `CImage` object. The code to do this resembles the following line.  
  
```  
MyStaticControl.SetBitmap(HBITMAP(MyBitmap));  
```  
  
 The following example creates two `CStatic` objects on the heap. It then loads one with a system bitmap using `CBitmap::LoadOEMBitmap` and the other from a file using `CImage::Load`.  
  
## Example  
 [!code[NVC_MFC_CStatic#3](../vs140/codesnippet/CPP/cstatic--setbitmap_1.cpp)]  
  
## Requirements  
 Header: afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::GetBitmap](../vs140/cstatic--getbitmap.md)   
 [STM_SETIMAGE](http://msdn.microsoft.com/library/windows/desktop/bb760782)   
 [Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183377)   
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [CImage Class](../vs140/cimage-class.md)
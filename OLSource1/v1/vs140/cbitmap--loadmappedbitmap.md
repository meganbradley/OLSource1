---
title: "CBitmap::LoadMappedBitmap"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - LoadMappedBitmap
  - CBitmap.LoadMappedBitmap
  - CBitmap::LoadMappedBitmap
dev_langs: 
  - C++
helpviewer_keywords: 
  - LoadMappedBitmap method
ms.assetid: 78292b16-3515-4924-8d0d-d48d1d7715b2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBitmap::LoadMappedBitmap
Call this member function to load a bitmap and map the colors to the current system colors.  
  
## Syntax  
  
```  
  
      BOOL LoadMappedBitmap(  
   UINT nIDBitmap,  
   UINT nFlags = 0,  
   LPCOLORMAP lpColorMap = NULL,  
   int nMapSize = 0   
);  
```  
  
#### Parameters  
 `nIDBitmap`  
 The ID of the bitmap resource.  
  
 `nFlags`  
 A flag for a bitmap. Can be zero or **CMB_MASKED**.  
  
 `lpColorMap`  
 A pointer to a **COLORMAP** structure that contains the color information needed to map the bitmaps. If this parameter is **NULL**, the function uses the default color map.  
  
 *nMapSize*  
 The number of color maps pointed to by `lpColorMap`.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 By default, `LoadMappedBitmap` will map colors commonly used in button glyphs.  
  
 For information about creating a mapped bitmap, see the Windows function [CreateMappedBitmap](http://go.microsoft.com/fwlink/?LinkID=230562) and the [COLORMAP](http://msdn.microsoft.com/library/windows/desktop/bb760448) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LoadBitmap](http://msdn.microsoft.com/library/windows/desktop/dd145033)   
 [CreateMappedBitmap](http://msdn.microsoft.com/library/windows/desktop/bb787467)
---
title: "CMFCToolBar::GetLargeDisabledImages"
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
  - GetLargeDisabledImages
  - CMFCToolBar.GetLargeDisabledImages
  - CMFCToolBar::GetLargeDisabledImages
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetLargeDisabledImages method
ms.assetid: 94646734-bcce-4eba-b148-057d65b59be1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::GetLargeDisabledImages
Returns a pointer to the collection of large disabled toolbar button images in the application.  
  
## Syntax  
  
```  
static CMFCToolBarImages* GetLargeDisabledImages();  
```  
  
## Return Value  
 A pointer to the collection of large disabled toolbar button images.  
  
## Remarks  
 Large images are large versions of the regular toolbar button images. Call [LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md) or [CMFCToolBar::LoadBitmap](../vs140/cmfctoolbar--loadbitmap.md) to load the large images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md)   
 [CMFCToolBar::LoadBitmap](../vs140/cmfctoolbar--loadbitmap.md)
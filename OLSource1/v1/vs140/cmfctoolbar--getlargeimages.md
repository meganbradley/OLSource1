---
title: "CMFCToolBar::GetLargeImages"
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
  - "GetLargeImages"
  - "CMFCToolBar::GetLargeImages"
  - "CMFCToolBar.GetLargeImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLargeImages method"
ms.assetid: 291e3ba8-c8f7-4445-8faa-b2185630cb2c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetLargeImages
Returns a pointer to the collection of large toolbar button images in the application.  
  
## Syntax  
  
```  
static CMFCToolBarImages* GetLargeImages();  
```  
  
## Return Value  
 A pointer to the collection of large toolbar button images.  
  
## Remarks  
 Large images are large versions of the regular toolbar button images. Call [LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md) to load the large images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md)
---
title: "CMFCToolBarImages::GetImageWell"
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
  - "CMFCToolBarImages.GetImageWell"
  - "CMFCToolBarImages::GetImageWell"
  - "GetImageWell"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImageWell method"
ms.assetid: 0f354426-3333-4c9c-9ad2-70a0d298b0ee
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::GetImageWell
Returns the handle to the bitmap that contains all the toolbar images.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A handle to a bitmap that contains toolbar images.  
  
## Remarks  
 The toolbar images are stored in a row in a single bitmap that is known as an *image well*. To find a toolbar image in the image well, multiply the index of the image by the width of the toolbar images (see [CMFCToolBarImages::GetImageSize](../vs140/cmfctoolbarimages--getimagesize.md)) to obtain the horizontal offset of the image inside the image well.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
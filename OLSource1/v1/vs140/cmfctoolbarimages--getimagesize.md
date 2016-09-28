---
title: "CMFCToolBarImages::GetImageSize"
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
  - "CMFCToolBarImages.GetImageSize"
  - "CMFCToolBarImages::GetImageSize"
  - "GetImageSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImageSize method"
ms.assetid: 40cda928-92aa-4c74-b829-e07955dca5ca
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::GetImageSize
Retrieves either the size of the toolbar images that are stored in memory (source size), or the size of the toolbar images that are drawn on the screen (destination size).  
  
## Syntax  
  
```  
SIZE GetImageSize(  
   BOOL bDest=FALSE   
) const;  
```  
  
#### Parameters  
 [in] `bDest`  
 `TRUE` to retrieve the destination size; `FALSE` to retrieve the source image size.  
  
## Return Value  
 A `SIZE` structure, which specifies the size of an image in pixels.  
  
## Remarks  
 The size of the source image is the size of the images that are stored in the [CMFCToolbarImages](../vs140/cmfctoolbarimages-class.md) object. You can call [CMFCToolBarImages::SetImageSize](../vs140/cmfctoolbarimages--setimagesize.md) to set the source size. The default value is 16x15 pixels.  
  
 By default, the destination image size is 0x0. You specify the destination size when you call [CMFCToolBarImages::PrepareDrawImage](../vs140/cmfctoolbarimages--preparedrawimage.md). The [CMFCToolBarImages::EndDrawImage](../vs140/cmfctoolbarimages--enddrawimage.md) method resets the destination size to the default value.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
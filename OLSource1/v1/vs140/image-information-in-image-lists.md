---
title: "Image Information in Image Lists"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - CImageList class, image information in
  - image lists [C++], image information in
ms.assetid: 73c41543-fa91-405d-b15b-0feffa6a72c1
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Image Information in Image Lists
[CImageList](../vs140/cimagelist-class.md) includes a number of functions that retrieve information from an image list. The [GetImageInfo](../vs140/cimagelist--getimageinfo.md) member function fills an `IMAGEINFO` structure with information about a single image, including the handles of the image and mask bitmaps, the number of color planes and bits per pixel, and the bounding rectangle of the image within the image bitmap. You can use this information to directly manipulate the bitmaps for the image.  
  
 The [GetImageCount](../vs140/cimagelist--getimagecount.md) member function retrieves the number of images in an image list.  
  
 You can create an icon based on an image and mask in an image list by using the [ExtractIcon](../vs140/cimagelist--extracticon.md) member function. The function returns the handle of the new icon.  
  
## See Also  
 [Using CImageList](../vs140/using-cimagelist.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)
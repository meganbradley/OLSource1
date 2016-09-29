---
title: "Image Overlays in Image Lists"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overlays"
  - "image lists [C++], image overlays in"
  - "CImageList class, image overlays in"
ms.assetid: aaf4e1c4-cd12-42c8-9af4-1bb458889b4e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Image Overlays in Image Lists
Every image list ([CImageList](../vs140/cimagelist-class.md)) includes a list of images to use as overlay masks. An "overlay mask" is an image drawn transparently over another image. Any image can be used as an overlay mask. You can specify up to four overlay masks per image list.  
  
 You add the index of an image to the list of overlay masks by using the [SetOverlayImage](../vs140/cimagelist--setoverlayimage.md) member function, the index of an image, and the index of an overlay mask. Note that the indices for the overlay masks are one-based rather than zero-based.  
  
 You draw an overlay mask over an image using a single call to **Draw**. The parameters include the index of the image to draw and the index of an overlay mask. You must use the [INDEXTOOVERLAYMASK](http://msdn.microsoft.com/library/windows/desktop/bb761408) macro to specify the index of the overlay mask. You can also specify an overlay image when calling the [DrawIndirect](../vs140/cimagelist--drawindirect.md) member function.  
  
## See Also  
 [Using CImageList](../vs140/using-cimagelist.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)
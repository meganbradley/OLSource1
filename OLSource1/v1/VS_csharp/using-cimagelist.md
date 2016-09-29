---
title: "Using CImageList"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "image list control"
  - "CImageList class, using"
ms.assetid: 3d2a909e-d641-46b7-aada-81cab1a29b41
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using CImageList
An image list, represented by class [CImageList](../VS_csharp/cimagelist-class.md), is a collection of same-sized images, each of which can be referred to by its index. Image lists are used to efficiently manage large sets of icons or bitmaps. Image lists are not themselves controls since they are not windows; however, they are used with several different types of controls, including list controls ([CListCtrl](../VS_csharp/clistctrl-class.md)), tree controls ([CTreeCtrl](../VS_csharp/ctreectrl-class.md)), and tab controls ([CTabCtrl](../VS_csharp/ctabctrl-class.md)).  
  
 All images in an image list are contained in a single, wide bitmap in screen-device format. An image list may also include a monochrome bitmap that contains masks used to draw images transparently (icon style). `CImageList` provides member functions that enable you to draw images, create and destroy image lists, add and remove images, replace images, merge images, and drag images.  
  
## What do you want to know more about?  
  
-   [Types of Image Lists](../VS_csharp/types-of-image-lists.md)  
  
-   [Using an Image List](../VS_csharp/using-an-image-list.md)  
  
-   [Manipulating Image Lists](../VS_csharp/manipulating-image-lists.md)  
  
-   [Drawing Images from an Image List](../VS_csharp/drawing-images-from-an-image-list.md)  
  
-   [Image Overlays in Image Lists](../VS_csharp/image-overlays-in-image-lists.md)  
  
-   [Dragging Images from an Image List](../VS_csharp/dragging-images-from-an-image-list.md)  
  
-   [Image Information in Image Lists](../VS_csharp/image-information-in-image-lists.md)  
  
## See Also  
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)
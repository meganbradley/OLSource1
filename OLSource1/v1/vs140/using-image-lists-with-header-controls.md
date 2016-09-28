---
title: "Using Image Lists with Header Controls"
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
  - "header controls, image lists"
  - "CHeaderCtrl class, image lists"
  - "image lists [C++], header controls"
ms.assetid: d5e9b310-6278-406c-909c-eefa09549a47
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Image Lists with Header Controls
Header items have the ability to display an image within a header item. This image, stored in an associated image list, is 16 x 16 pixels and has the same characteristics as the icon images used in a list view control. In order to implement this behavior successfully, you must first create and initialize the image list, associate the list with the header control, and then modify the attributes of the header item that will display the image.  
  
 The following procedure illustrates the details, using a pointer to a header control (`m_pHdrCtrl`) and a pointer to an image list (`m_pHdrImages`).  
  
### To display an image in a header item  
  
1.  Construct a new image list (or use an existing image list object) using the [CImageList](../vs140/cimagelist-class.md) constructor, storing the resultant pointer.  
  
2.  Initialize the new image list object by calling [CImageList::Create](../vs140/cimagelist--create.md). The following code is one example of this call.  
  
     [!code[NVC_MFCControlLadenDialog#15](../vs140/codesnippet/CPP/using-image-lists-with-header-controls_1.cpp)]  
  
3.  Add the images for each header item. The following code adds two predefined images.  
  
     [!code[NVC_MFCControlLadenDialog#16](../vs140/codesnippet/CPP/using-image-lists-with-header-controls_2.cpp)]  
  
4.  Associate the image list with the header control with a call to [CHeaderCtrl::SetImageList](../vs140/cheaderctrl--setimagelist.md).  
  
5.  Modify the header item to display an image from the associated image list. The following example assigns the first image, from `m_phdrImages`, to the first header item, `m_pHdrCtrl`.  
  
     [!code[NVC_MFCControlLadenDialog#17](../vs140/codesnippet/CPP/using-image-lists-with-header-controls_3.cpp)]  
  
 For detailed information on the parameter values used, consult the pertinent [CHeaderCtrl](../vs140/cheaderctrl-class.md).  
  
> [!NOTE]
>  It is possible to have multiple controls using the same image list. For instance, in a standard list view control, there could be an image list (of 16 x 16 pixel images) used by both the small icon view of a list view control and the header items of the list view control.  
  
## See Also  
 [Using CHeaderCtrl](../vs140/using-cheaderctrl.md)
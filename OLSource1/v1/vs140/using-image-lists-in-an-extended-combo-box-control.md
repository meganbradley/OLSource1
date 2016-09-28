---
title: "Using Image Lists in an Extended Combo Box Control"
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
  - "image lists [C++], combo boxes"
  - "extended combo boxes, images"
  - "images [C++], combo box items"
ms.assetid: dfff25fe-af70-47a2-8032-3901d1e6842d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Image Lists in an Extended Combo Box Control
The main feature of extended combo box controls is the ability to associate images from an image list with individual items in a combo box control. Each item is able to display three different images: one for its selected state, one for its nonselected state, and a third for an overlay image.  
  
 The following procedure associates an image list with an extended combo box control:  
  
### To associate an image list with an extended combo box control  
  
1.  Construct a new image list (or use an existing image list object), using the [CImageList](../vs140/cimagelist-class.md) constructor and storing the resultant pointer.  
  
2.  Initialize the new image list object by calling [CImageList::Create](../vs140/cimagelist--create.md). The following code is one example of this call.  
  
     [!code[NVC_MFCControlLadenDialog#10](../vs140/codesnippet/CPP/using-image-lists-in-an-extended-combo-box-control_1.cpp)]  
  
3.  Add optional images for each possible state: selected or nonselected, and an overlay. The following code adds three predefined images.  
  
     [!code[NVC_MFCControlLadenDialog#11](../vs140/codesnippet/CPP/using-image-lists-in-an-extended-combo-box-control_2.cpp)]  
  
4.  Associate the image list with the control with a call to [CComboBoxEx::SetImageList](../vs140/ccomboboxex--setimagelist.md).  
  
 Once the image list has been associated with the control, you can individually specify the images each item will use for the three possible states. For more information, see [Setting the Images for an Individual Item](../vs140/setting-the-images-for-an-individual-item.md).  
  
## See Also  
 [Using CComboBoxEx](../vs140/using-ccomboboxex.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)
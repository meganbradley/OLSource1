---
title: "CImageList::SetOverlayImage"
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
  - SetOverlayImage
  - CImageList.SetOverlayImage
  - CImageList::SetOverlayImage
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetOverlayImage method
ms.assetid: 105c740c-93ee-4c1b-99c4-ec5c04ca774b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImageList::SetOverlayImage
Call this function to add the zero-based index of an image to the list of images to be used as overlay masks.  
  
## Syntax  
  
```  
  
      BOOL SetOverlayImage(  
   int nImage,  
   int nOverlay   
);  
```  
  
#### Parameters  
 `nImage`  
 Zero-based index of the image to use as an overlay mask.  
  
 *nOverlay*  
 One-based index of the overlay mask.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Up to four indices can be added to the list.  
  
 An overlay mask is an image drawn transparently over another image. Draw an overlay mask over an image by using the [CImageList::Draw](../vs140/cimagelist--draw.md) member function with the one-based index of the overlay mask specified by using the **INDEXTOOVERLAYMASK** macro.  
  
## Example  
 [!code[NVC_MFC_CImageList#22](../vs140/codesnippet/CPP/cimagelist--setoverlayimage_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::Add](../vs140/cimagelist--add.md)
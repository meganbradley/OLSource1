---
title: "CImageList::GetImageInfo"
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
  - "CImageList.GetImageInfo"
  - "IMAGEINFO"
  - "CImageList::GetImageInfo"
  - "GetImageInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImageInfo method"
  - "IMAGEINFO"
ms.assetid: 73299abb-daa3-4259-a7fb-76667be33d91
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::GetImageInfo
Call this function to retrieve information about an image.  
  
## Syntax  
  
```  
  
      BOOL GetImageInfo(  
   int nImage,  
   IMAGEINFO* pImageInfo   
) const;  
```  
  
#### Parameters  
 `nImage`  
 Zero-based index of the image.  
  
 *pImageInfo*  
 Pointer to an [IMAGEINFO](http://msdn.microsoft.com/library/windows/desktop/bb761393) structure that receives information about the image. The information in this structure can be used to directly manipulate the bitmaps for the image.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The `IMAGEINFO` structure contains information about an image in an image list.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::GetImageCount](../vs140/cimagelist--getimagecount.md)
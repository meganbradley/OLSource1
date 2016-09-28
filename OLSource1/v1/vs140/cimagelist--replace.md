---
title: "CImageList::Replace"
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
  - "CImageList.Replace"
  - "CImageList::Replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Replace method"
ms.assetid: feab2fcd-3fec-49ba-abb8-64311f776adb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::Replace
Call this function to replace an image in an image list with a new image.  
  
## Syntax  
  
```  
  
      BOOL Replace(  
   int nImage,  
   CBitmap* pbmImage,  
   CBitmap* pbmMask   
);  
int Replace(  
   int nImage,  
   HICON hIcon   
);  
```  
  
#### Parameters  
 `nImage`  
 Zero-based index of the image to replace.  
  
 `pbmImage`  
 A pointer to the bitmap containing the image.  
  
 `pbmMask`  
 A pointer to the bitmap containing the mask. If no mask is used with the image list, this parameter is ignored.  
  
 `hIcon`  
 A handle to the icon that contains the bitmap and mask for the new image.  
  
## Return Value  
 The version returning **BOOL** returns nonzero if successful; otherwise 0.  
  
 The version returning `int` returns the zero-based index of the image if successful; otherwise – 1.  
  
## Remarks  
 Call this member function after calling [SetImageCount](../vs140/cimagelist--setimagecount.md) to assign the new, valid images to the placeholder image index numbers.  
  
## Example  
 See the example for [CImageList::SetImageCount](../vs140/cimagelist--setimagecount.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::Remove](../vs140/cimagelist--remove.md)
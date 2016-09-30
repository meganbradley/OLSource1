---
title: "CImageList::SetImageCount"
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
  - "CImageList.SetImageCount"
  - "SetImageCount"
  - "CImageList::SetImageCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImageCount method"
ms.assetid: 8ce75a9e-d8b8-40d3-991c-de26d78a218d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::SetImageCount
Call this member function to reset the number of images in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *uNewCount*  
 The value specifying the new total number of images in the image list.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 If you call this member function to increase the number of images in the image list, then call [Replace](../vs140/cimagelist--replace.md) for each additional image to assign the new indexes to valid images. If you fail to assign the indexes to valid images, draw operations that create the new images will be unpredictable.  
  
 If you decrease the size of an image list by using this function, the truncated images are freed.  
  
## Example  
 [!code[NVC_MFC_CImageList#21](../vs140/codesnippet/CPP/cimagelist--setimagecount_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
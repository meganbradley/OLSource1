---
title: "CImageList::Add"
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
  - CImageList.Add
  - CImageList::Add
dev_langs: 
  - C++
helpviewer_keywords: 
  - Add method [MFC]
ms.assetid: d6987b93-e16a-4c30-a579-8f96a5b7900d
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImageList::Add
Call this function to add one or more images or an icon to an image list.  
  
## Syntax  
  
```  
  
      int Add(  
   CBitmap* pbmImage,  
   CBitmap* pbmMask   
);  
int Add(  
   CBitmap* pbmImage,  
   COLORREF crMask   
);  
int Add(  
   HICON hIcon   
);  
```  
  
#### Parameters  
 `pbmImage`  
 Pointer to the bitmap containing the image or images. The number of images is inferred from the width of the bitmap.  
  
 `pbmMask`  
 Pointer to the bitmap containing the mask. If no mask is used with the image list, this parameter is ignored.  
  
 `crMask`  
 Color used to generate the mask. Each pixel of this color in the given bitmap is changed to black and the corresponding bit in the mask is set to one.  
  
 `hIcon`  
 Handle of the icon that contains the bitmap and mask for the new image.  
  
## Return Value  
 Zero-based index of the first new image if successful; otherwise – 1.  
  
## Remarks  
 You are responsible for releasing the icon handle when you are done with it.  
  
## Example  
 [!code[NVC_MFC_CImageList#1](../vs140/codesnippet/CPP/cimagelist--add_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::Remove](../vs140/cimagelist--remove.md)   
 [CImageList::Replace](../vs140/cimagelist--replace.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)
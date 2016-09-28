---
title: "CImageList::Create"
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
  - "Create"
  - "CImageList::Create"
  - "CImageList.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: f4ea5d1c-11d1-4f7d-9da3-f99fb22e9381
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::Create
Initializes an image list and attaches it to a [CImageList](../vs140/cimagelist-class.md) object.  
  
## Syntax  
  
```  
  
      BOOL Create(  
   int cx,  
   int cy,  
   UINT nFlags,  
   int nInitial,  
   int nGrow   
);  
BOOL Create(  
   UINT nBitmapID,  
   int cx,  
   int nGrow,  
   COLORREF crMask   
);  
BOOL Create(  
   LPCTSTR lpszBitmapID,  
   int cx,  
   int nGrow,  
   COLORREF crMask   
);  
BOOL Create(  
   CImageList& imagelist1,  
   int nImage1,  
   CImageList& imagelist2,  
   int nImage2,  
   int dx,  
   int dy   
);  
BOOL Create(  
   CImageList* pImageList   
);  
```  
  
#### Parameters  
 `cx`  
 Dimensions of each image, in pixels.  
  
 `cy`  
 Dimensions of each image, in pixels.  
  
 `nFlags`  
 Specifies the type of image list to create. This parameter can be a combination of the following values, but it can include only one of the `ILC_COLOR` values.  
  
|Value|Meaning|  
|-----------|-------------|  
|`ILC_COLOR`|Use the default behavior if none of the other `ILC_COLOR`* flags is specified. Typically, the default is `ILC_COLOR4`; but for older display drivers, the default is `ILC_COLORDDB`.|  
|`ILC_COLOR4`|Use a 4-bit (16 color) device-independent bitmap (DIB) section as the bitmap for the image list.|  
|`ILC_COLOR8`|Use an 8-bit DIB section. The colors used for the color table are the same colors as the halftone palette.|  
|`ILC_COLOR16`|Use a 16-bit (32/64k color) DIB section.|  
|`ILC_COLOR24`|Use a 24-bit DIB section.|  
|`ILC_COLOR32`|Use a 32-bit DIB section.|  
|`ILC_COLORDDB`|Use a device-dependent bitmap.|  
|`ILC_MASK`|Uses a mask. The image list contains two bitmaps, one of which is a monochrome bitmap used as a mask. If this value is not included, the image list contains only one bitmap. See [Drawing Images from an Image List](../vs140/drawing-images-from-an-image-list.md) for additional information on masked images.|  
  
 `nInitial`  
 Number of images that the image list initially contains.  
  
 `nGrow`  
 Number of images by which the image list can grow when the system needs to resize the list to make room for new images. This parameter represents the number of new images the resized image list can contain.  
  
 `nBitmapID`  
 Resource IDs of the bitmap to be associated with the image list.  
  
 `crMask`  
 Color used to generate a mask. Each pixel of this color in the specified bitmap is changed to black, and the corresponding bit in the mask is set to one.  
  
 `lpszBitmapID`  
 A string containing the resource IDs of the images.  
  
 `imagelist1`  
 A reference to a `CImageList` object.  
  
 `nImage1`  
 Index of the first existing image.  
  
 `imagelist2`  
 A reference to a `CImageList` object.  
  
 `nImage2`  
 Index of the second existing image.  
  
 `dx`  
 Offset of the x-axis of the second image in relationship to the first image, in pixels.  
  
 `dy`  
 Offset of the y-axis of the second image in relationship to the first image, in pixels.  
  
 `pImageList`  
 A pointer to a `CImageList` object.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You construct a `CImageList` in two steps. First, call the constructor and then call `Create`, which creates the image list and attaches it to the `CImageList`object.  
  
## Example  
 [!code[NVC_MFC_CImageList#7](../vs140/codesnippet/CPP/cimagelist--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::CImageList](../vs140/cimagelist--cimagelist.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [Drawing Images from an Image List](../vs140/drawing-images-from-an-image-list.md)
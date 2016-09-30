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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::Create
Initializes an image list and attaches it to a [CImageList](../vs140/cimagelist-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Dimensions of each image, in pixels.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Dimensions of each image, in pixels.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the type of image list to create. This parameter can be a combination of the following values, but it can include only one of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> values.  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Use the default behavior if none of the other <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>* flags is specified. Typically, the default is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; but for older display drivers, the default is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Use a 4-bit (16 color) device-independent bitmap (DIB) section as the bitmap for the image list.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Use an 8-bit DIB section. The colors used for the color table are the same colors as the halftone palette.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Use a 16-bit (32/64k color) DIB section.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Use a 24-bit DIB section.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Use a 32-bit DIB section.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Use a device-dependent bitmap.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Uses a mask. The image list contains two bitmaps, one of which is a monochrome bitmap used as a mask. If this value is not included, the image list contains only one bitmap. See [Drawing Images from an Image List](../vs140/drawing-images-from-an-image-list.md) for additional information on masked images.|  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Number of images that the image list initially contains.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Number of images by which the image list can grow when the system needs to resize the list to make room for new images. This parameter represents the number of new images the resized image list can contain.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Resource IDs of the bitmap to be associated with the image list.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Color used to generate a mask. Each pixel of this color in the specified bitmap is changed to black, and the corresponding bit in the mask is set to one.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A string containing the resource IDs of the images.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Index of the first existing image.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Index of the second existing image.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Offset of the x-axis of the second image in relationship to the first image, in pixels.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Offset of the y-axis of the second image in relationship to the first image, in pixels.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> in two steps. First, call the constructor and then call <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, which creates the image list and attaches it to the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>object.  
  
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
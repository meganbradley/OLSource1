---
title: "CMFCButton::SetImage"
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
  - CMFCButton::SetImage
  - SetImage
  - CMFCButton.SetImage
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetImage method
ms.assetid: ebc1a843-c48f-4ca8-b30a-31d3df9cfe34
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCButton::SetImage
Sets the image for a button.  
  
## Syntax  
  
```  
void SetImage(  
   HICON hIcon,  
   BOOL bAutoDestroy=TRUE,  
   HICON hIconHot=NULL,  
   HICON hIconDisabled=NULL,  
   BOOL bAlphaBlend=FALSE   
);  
void SetImage(  
   HBITMAP hBitmap,  
   BOOL bAutoDestroy=TRUE,  
   HBITMAP hBitmapHot=NULL,  
   BOOL bMap3dColors=TRUE,  
   HBITMAP hBitmapDisabled=NULL   
);  
void SetImage(  
   UINT uiBmpResId,  
   UINT uiBmpHotResId=0,  
   UINT uiBmpDsblResID=0   
);  
```  
  
#### Parameters  
 [in] `hIcon`  
 Handle to the icon that contains the bitmap and mask for the new image.  
  
 [in] `bAutoDestroy`  
 `TRUE` to specify that bitmap resources be destroyed automatically; otherwise, `FALSE`. The default is `TRUE`.  
  
 [in] `hIconHot`  
 Handle to the icon that contains the image for the selected state.  
  
 [in] `hBitmap`  
 Handle to the bitmap that contains the image for the non-selected state.  
  
 [in] `hBitmapHot`  
 Handle to the bitmap that contains the image for the selected state.  
  
 [in] `uiBmpResId`  
 Resource ID for the non-selected image.  
  
 [in] `uiBmpHotResId`  
 Resource ID for the selected image.  
  
 [in] `bMap3dColors`  
 Specifies a transparent color for the button background; that is, the face of the button. `TRUE` to use the color value RGB(192, 192, 192); `FALSE` to use the color value defined by `AFX_GLOBAL_DATA::clrBtnFace`.  
  
 [in] `hIconDisabled`  
 Handle to the icon for the disabled image.  
  
 [in] `hBitmapDisabled`  
 Handle to the bitmap that contains the disabled image.  
  
 [in] `uiBmpDsblResID`  
 Resource ID of the disabled bitmap.  
  
 [in] `bAlphaBlend`  
 `TRUE` to use only 32-bit images that use the alpha channel; `FALSE`, to not use only alpha channel images. The default is `FALSE`.  
  
## Remarks  
  
## Example  
 The following example demonstrates how to use various versions of the `SetImage` method in the `CMFCButton` class. The example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#28](../vs140/codesnippet/CPP/cmfcbutton--setimage_1.h)]
  
[!code[NVC_MFC_NewControls#31](../vs140/codesnippet/CPP/cmfcbutton--setimage_2.cpp)]
  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
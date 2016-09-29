---
title: "CMFCEditBrowseCtrl::SetBrowseButtonImage"
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
  - "CMFCEditBrowseCtrl.SetBrowseButtonImage"
  - "SetBrowseButtonImage"
  - "CMFCEditBrowseCtrl::SetBrowseButtonImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBrowseButtonImage method"
ms.assetid: 9016bfbf-648d-42e1-a541-d00752786d10
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCEditBrowseCtrl::SetBrowseButtonImage
Sets a custom image on the browse button of the edit browse control.  
  
## Syntax  
  
```  
void SetBrowseButtonImage(  
   HICON hIcon,  
   BOOL bAutoDestroy = TRUE  
);  
void SetBrowseButtonImage(  
   HBITMAP hBitmap,  
   BOOL bAutoDestroy = TRUE  
);  
void SetBrowseButtonImage(  
   UINT uiBmpResId  
);  
```  
  
#### Parameters  
 `hIcon`  
 The handle of an icon.  
  
 `hBitmap`  
 The handle of a bitmap.  
  
 `uiBmpResId`  
 The resource ID of a bitmap.  
  
 `bAutoDestroy`  
 `TRUE` to delete the specified icon or bitmap when this method exits; otherwise, `FALSE`. The default value is `TRUE`.  
  
## Remarks  
 Use this method to apply a custom image to the browse button. By default, the framework obtains a standard image when the edit browse control is in *file browse* or *folder browse* mode.  
  
## Requirements  
 **Header:** afxeditbrowsectrl.h  
  
## See Also  
 [CMFCEditBrowseCtrl Class](../vs140/cmfceditbrowsectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
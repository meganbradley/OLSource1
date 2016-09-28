---
title: "CToolBarCtrl::SetImageList"
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
  - "CToolBarCtrl::SetImageList"
  - "CToolBarCtrl.SetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImageList method"
ms.assetid: ea89c227-951f-4fc4-95c7-c36d048b94a7
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetImageList
Sets the image list that the toolbar will use to display buttons that are in their default state.  
  
## Syntax  
  
```  
  
      CImageList* SetImageList(  
   CImageList* pImageList   
);  
```  
  
#### Parameters  
 `pImageList`  
 A pointer to a `CImageList` object containing the images to be used by the toolbar control to display button images in their default state.  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object that was previously used by the toolbar control to display button images in their default state.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_SETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787433), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The MFC implementation of `SetImageList` uses a `CImageList` object containing the toolbar control's button images, rather than a handle to an image list.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetImageList](../vs140/ctoolbarctrl--getimagelist.md)   
 [CToolBarCtrl::SetDisabledImageList](../vs140/ctoolbarctrl--setdisabledimagelist.md)   
 [CToolBarCtrl::SetHotImageList](../vs140/ctoolbarctrl--sethotimagelist.md)
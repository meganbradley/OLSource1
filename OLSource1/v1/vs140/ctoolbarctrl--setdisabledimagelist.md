---
title: "CToolBarCtrl::SetDisabledImageList"
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
  - "CToolBarCtrl.SetDisabledImageList"
  - "SetDisabledImageList"
  - "CToolBarCtrl::SetDisabledImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDisabledImageList method"
ms.assetid: ebff85c2-ef48-41ca-96dc-1bf5eac00e69
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetDisabledImageList
Sets the image list that the toolbar control will use to display disabled buttons.  
  
## Syntax  
  
```  
  
      CImageList* SetDisabledImageList(  
   CImageList* pImageList   
);  
```  
  
#### Parameters  
 `pImageList`  
 A pointer to a `CImageList` object containing the images to be used by the toolbar control to display disabled button images.  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object that was previously used by the toolbar control to display disabled button images.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_SETDISABLEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787423), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The MFC implementation of `SetDisabledImageList` uses a `CImageList` object containing the toolbar control's disabled button images, rather than a handle to an image list.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetDisabledImageList](../vs140/ctoolbarctrl--getdisabledimagelist.md)   
 [CToolBarCtrl::SetHotImageList](../vs140/ctoolbarctrl--sethotimagelist.md)   
 [CToolBarCtrl::SetImageList](../vs140/ctoolbarctrl--setimagelist.md)
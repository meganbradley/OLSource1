---
title: "CToolBarCtrl::GetDisabledImageList"
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
  - "CToolBarCtrl::GetDisabledImageList"
  - "CToolBarCtrl.GetDisabledImageList"
  - "GetDisabledImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "image lists [C++], retrieving"
  - "GetDisabledImageList method"
  - "disabled image list"
ms.assetid: bab771ec-ff12-4158-b2a8-d2109d5a8869
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetDisabledImageList
Retrieves the image list that a toolbar control uses to display disabled buttons.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object, or **NULL** if no disabled image list is set.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETDISABLEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787329), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The MFC implementation of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> uses a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object containing the toolbar control's button images, rather than a handle to an image list.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetDisabledImageList](../vs140/ctoolbarctrl--setdisabledimagelist.md)   
 [CToolBarCtrl::GetHotImageList](../vs140/ctoolbarctrl--gethotimagelist.md)   
 [CToolBarCtrl::GetImageList](../vs140/ctoolbarctrl--getimagelist.md)
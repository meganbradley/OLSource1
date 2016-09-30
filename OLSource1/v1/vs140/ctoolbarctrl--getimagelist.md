---
title: "CToolBarCtrl::GetImageList"
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
  - "CToolBarCtrl.GetImageList"
  - "CToolBarCtrl::GetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "image lists [C++], retrieving"
  - "GetImageList method"
ms.assetid: ddeab856-cf3d-428e-8c6f-185a4e749dc6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetImageList
Retrieves the image list that a toolbar control uses to display buttons in their default state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object, or **NULL** if no image list is set.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787337), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetDisabledImageList](../vs140/ctoolbarctrl--getdisabledimagelist.md)   
 [CToolBarCtrl::GetHotImageList](../vs140/ctoolbarctrl--gethotimagelist.md)
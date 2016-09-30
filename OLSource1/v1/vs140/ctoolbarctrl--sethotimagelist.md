---
title: "CToolBarCtrl::SetHotImageList"
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
  - "SetHotImageList"
  - "CToolBarCtrl.SetHotImageList"
  - "CToolBarCtrl::SetHotImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHotImageList method"
ms.assetid: fab24c55-da98-4618-93c8-837835cb55c2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetHotImageList
Sets the image list that the toolbar control will use to display "hot" buttons.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object containing the images to be used by the toolbar control to display hot button images.  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object that was previously used by the toolbar control to display hot button images.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_SETHOTIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787429), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The MFC implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> uses a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object containing the toolbar control's hot button images, rather than a handle to an image list. A hot button appears highlighted when the pointer is above it.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetHotImageList](../vs140/ctoolbarctrl--gethotimagelist.md)   
 [CToolBarCtrl::SetDisabledImageList](../vs140/ctoolbarctrl--setdisabledimagelist.md)   
 [CToolBarCtrl::SetImageList](../vs140/ctoolbarctrl--setimagelist.md)
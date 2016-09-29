---
title: "CToolBarCtrl::GetHotImageList"
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
  - "GetHotImageList"
  - "CToolBarCtrl.GetHotImageList"
  - "CToolBarCtrl::GetHotImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "image lists [C++], retrieving"
  - "GetHotImageList method"
  - "hot image list"
ms.assetid: 6e442d71-c445-437d-85c2-054f82eefb4f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetHotImageList
Retrieves the image list that a toolbar control uses to display "hot" buttons. A hot button appears highlighted when the mouse pointer is above it.  
  
## Syntax  
  
```  
  
CImageList* GetHotImageList( ) const;  
  
```  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object, or **NULL** if no disabled image list is set.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETHOTIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787334), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. A hot button appears highlighted when the mouse pointer is above it.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetDisabledImageList](../vs140/ctoolbarctrl--getdisabledimagelist.md)   
 [CToolBarCtrl::GetImageList](../vs140/ctoolbarctrl--getimagelist.md)
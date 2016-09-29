---
title: "CToolBarCtrl::GetPressedImageList"
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
  - "CToolBarCtrl::GetPressedImageList"
  - "GetPressedImageList method"
  - "CToolBarCtrl.GetPressedImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPressedImageList method"
ms.assetid: bf056c54-5ef2-4e99-9055-ee83bd20dfd2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetPressedImageList
Retrieves the image list that the current toolbar control uses to represent buttons in the pressed state.  
  
## Syntax  
  
```  
CImageList* GetPressedImageList();  
```  
  
## Return Value  
 Pointer to a [CImageList](../vs140/cimagelist-class.md) that contains the image list for the current control, or `NULL` if no such image list is set.  
  
## Remarks  
 This method sends the [TB_GETPRESSEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787345) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TB_GETPRESSEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787345)   
 [CImageList](../vs140/cimagelist-class.md)   
 [CToolBarCtrl::SetPressedImageList](../vs140/ctoolbarctrl--setpressedimagelist.md)
---
title: "CHeaderCtrl::SetImageList"
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
  - "CHeaderCtrl.SetImageList"
  - "CHeaderCtrl::SetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImageList method"
ms.assetid: eba5917b-98c9-4f7f-900f-e0820a5e6249
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::SetImageList
Assigns an image list to a header control.  
  
## Syntax  
  
```  
  
      CImageList* SetImageList(  
   CImageList* pImageList   
);  
```  
  
#### Parameters  
 `pImageList`  
 A pointer to a `CImageList` object containing the image list to be assigned to the header control.  
  
## Return Value  
 A pointer to the [CImageList](../vs140/cimagelist-class.md) object previously assigned to the header control.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [HDM_SETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb775365), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The `CImageList` object to which the returned pointer points is a temporary object and is deleted in the next idle-time processing.  
  
## Example  
 See the example for [CHeaderCtrl::GetImageList](../vs140/cheaderctrl--getimagelist.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::GetImageList](../vs140/cheaderctrl--getimagelist.md)   
 [CHeaderCtrl::CreateDragImage](../vs140/cheaderctrl--createdragimage.md)
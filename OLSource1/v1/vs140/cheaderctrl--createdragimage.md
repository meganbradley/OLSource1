---
title: "CHeaderCtrl::CreateDragImage"
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
  - "CHeaderCtrl.CreateDragImage"
  - "CHeaderCtrl::CreateDragImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDragImage method"
ms.assetid: f8aadfd4-940a-4155-8d1a-5a30342521d8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::CreateDragImage
Creates a transparent version of an item's image within a header control.  
  
## Syntax  
  
```  
  
      CImageList* CreateDragImage(  
   int nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 The zero-based index of the item within the header control. The image assigned to this item is the basis for the transparent image.  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object if successful; otherwise **NULL**. The returned list contains only one image.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [HDM_CREATEDRAGIMAGE](http://msdn.microsoft.com/library/windows/desktop/bb775308), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item drag and drop.  
  
 The `CImageList` object to which the returned pointer points is a temporary object and is deleted in the next idle-time processing.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::GetImageList](../vs140/cheaderctrl--getimagelist.md)   
 [CHeaderCtrl::SetImageList](../vs140/cheaderctrl--setimagelist.md)
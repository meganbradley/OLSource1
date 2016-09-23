---
title: "CListCtrl::SetImageList"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CListCtrl.SetImageList
  - CListCtrl::SetImageList
dev_langs: 
  - C++
helpviewer_keywords: 
  - LVSIL_STATE
  - LVSIL_SMALL
  - LVSIL_NORMAL
  - SetImageList method
ms.assetid: 4734bcef-9850-40b5-9f05-4baebe9d0a26
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::SetImageList
Assigns an image list to a list view control.  
  
## Syntax  
  
```  
  
      CImageList* SetImageList(  
   CImageList* pImageList,  
   int nImageListType   
);  
```  
  
#### Parameters  
 `pImageList`  
 Pointer to the image list to assign.  
  
 `nImageListType`  
 Type of image list. It can be one of these values:  
  
-   `LVSIL_NORMAL` Image list with large icons.  
  
-   `LVSIL_SMALL` Image list with small icons.  
  
-   `LVSIL_STATE` Image list with state images.  
  
## Return Value  
 A pointer to the previous image list.  
  
## Example  
 See the example for [CListCtrl::GetImageList](../vs140/clistctrl--getimagelist.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList Class](../vs140/cimagelist-class.md)   
 [CListCtrl::GetImageList](../vs140/clistctrl--getimagelist.md)
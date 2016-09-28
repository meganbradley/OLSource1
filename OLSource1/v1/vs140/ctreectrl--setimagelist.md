---
title: "CTreeCtrl::SetImageList"
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
  - "CTreeCtrl.SetImageList"
  - "CTreeCtrl::SetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TVSIL_NORMAL"
  - "SetImageList method"
  - "TVSIL_STATE"
ms.assetid: 545d758a-f6cf-40d0-b529-dc65897519d4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetImageList
Call this function to set the normal or state image list for a tree view control and redraw the control using the new images.  
  
## Syntax  
  
```  
  
      CImageList* SetImageList(  
   CImageList * pImageList,  
   int nImageListType   
);  
```  
  
#### Parameters  
 `pImageList`  
 Pointer to the image list to assign. If `pImageList` is **NULL**, all images are removed from the tree view control.  
  
 `nImageListType`  
 Type of image list to set. The image list can be one of the following values:  
  
-   `TVSIL_NORMAL` Sets the normal image list, which contains the selected and nonselected images for the tree view item. You must use this state for overlay images.  
  
-   `TVSIL_STATE` Sets the state image list, which contains the images for tree view items that are in a user-defined state.  
  
## Return Value  
 Pointer to the previous image list, if any; otherwise **NULL**.  
  
## Example  
 See the example for [CTreeCtrl::GetImageList](../vs140/ctreectrl--getimagelist.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList Class](../vs140/cimagelist-class.md)   
 [CTreeCtrl::GetImageList](../vs140/ctreectrl--getimagelist.md)
---
title: "CTreeCtrl::GetItemImage"
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
  - "CTreeCtrl.GetItemImage"
  - "GetItemImage"
  - "CTreeCtrl::GetItemImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemImage method"
ms.assetid: ea4f4fb1-cec8-4401-a9f4-1edc54b77992
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetItemImage
Each item in a tree view control can have a pair of bitmapped images associated with it.  
  
## Syntax  
  
```  
  
      BOOL GetItemImage(  
   HTREEITEM hItem,  
   int& nImage,  
   int& nSelectedImage   
) const;  
```  
  
#### Parameters  
 `hItem`  
 The handle of the item whose image is to be retrieved.  
  
 `nImage`  
 An integer that receives the index of the item's image within the tree view control's image list.  
  
 `nSelectedImage`  
 An integer that receives the index of the item's selected image within the tree view control's image list.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The images appear on the left side of an item's label. One image is displayed when the item is selected, and the other is displayed when the item is not selected. For example, an item might display an open folder when it is selected and a closed folder when it is not selected.  
  
 Call this function to retrieve the index of the item's image and its selected image within the tree view control's image list.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#16](../vs140/codesnippet/CPP/ctreectrl--getitemimage_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetItemImage](../vs140/ctreectrl--setitemimage.md)   
 [CImageList Class](../vs140/cimagelist-class.md)
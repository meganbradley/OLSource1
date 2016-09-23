---
title: "CTreeCtrl::CreateDragImage"
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
  - CTreeCtrl.CreateDragImage
  - CTreeCtrl::CreateDragImage
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateDragImage method
ms.assetid: b3748a06-598f-48d8-bcb5-643544e7ae08
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::CreateDragImage
Call this function to create a dragging bitmap for the given item in a tree view control, create an image list for the bitmap, and add the bitmap to the image list.  
  
## Syntax  
  
```  
  
      CImageList* CreateDragImage(  
   HTREEITEM hItem   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of the tree item to be dragged.  
  
## Return Value  
 Pointer to the image list to which the dragging bitmap was added, if successful; otherwise **NULL**.  
  
## Remarks  
 An application uses the image-list functions to display the image when the item is being dragged.  
  
 The `CImageList` object is permanent, and you must delete it when finished. For example:  
  
 [!code[NVC_MFC_CTreeCtrl#2](../vs140/codesnippet/CPP/ctreectrl--createdragimage_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SelectDropTarget](../vs140/ctreectrl--selectdroptarget.md)   
 [CTreeCtrl::GetDropHilightItem](../vs140/ctreectrl--getdrophilightitem.md)   
 [CTreeCtrl::SetImageList](../vs140/ctreectrl--setimagelist.md)
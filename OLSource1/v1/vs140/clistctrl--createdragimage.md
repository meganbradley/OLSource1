---
title: "CListCtrl::CreateDragImage"
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
  - "CListCtrl.CreateDragImage"
  - "CListCtrl::CreateDragImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDragImage method"
ms.assetid: 9d57d7f3-15aa-4c78-8a7b-9f8a74c12c42
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::CreateDragImage
Creates a drag image list for the item specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Index of the item whose drag image list is to be created.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Address of a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that receives the initial location of the upper-left corner of the image, in view coordinates.  
  
## Return Value  
 A pointer to the drag image list if successful; otherwise **NULL**.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is permanent, and you must delete it when finished. For example:  
  
 [!code[NVC_MFC_CListCtrl#3](../vs140/codesnippet/CPP/clistctrl--createdragimage_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList Class](../vs140/cimagelist-class.md)   
 [CListCtrl::GetImageList](../vs140/clistctrl--getimagelist.md)
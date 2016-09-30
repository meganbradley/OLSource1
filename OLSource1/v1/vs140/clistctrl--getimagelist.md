---
title: "CListCtrl::GetImageList"
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
  - "LVSIL_SMALL"
  - "CListCtrl::GetImageList"
  - "LVSIL_STATE"
  - "LVSIL_NORMAL"
  - "CListCtrl.GetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVSIL_STATE"
  - "LVSIL_SMALL"
  - "LVSIL_NORMAL"
  - "GetImageList method"
ms.assetid: 727575c9-ab06-407b-b1ec-8bdae89f7f08
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetImageList
Retrieves the handle of an image list used for drawing list view items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Value specifying which image list to retrieve. It can be one of these values:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Image list with large icons.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Image list with small icons.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Image list with state images.  
  
## Return Value  
 A pointer to the image list used for drawing list view items.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#20](../vs140/codesnippet/CPP/clistctrl--getimagelist_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList Class](../vs140/cimagelist-class.md)   
 [CListCtrl::SetImageList](../vs140/clistctrl--setimagelist.md)
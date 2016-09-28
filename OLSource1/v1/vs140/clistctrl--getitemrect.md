---
title: "CListCtrl::GetItemRect"
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
  - "LVIR_LABEL"
  - "LVIR_ICON"
  - "CListCtrl.GetItemRect"
  - "CListCtrl::GetItemRect"
  - "LVIR_BOUNDS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVIR_LABEL"
  - "GetItemRect method [MFC]"
  - "LVIR_BOUNDS"
  - "LVIR_ICON"
ms.assetid: fb8f9641-5ceb-49e9-99af-500a8ca981d1
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetItemRect
Retrieves the bounding rectangle for all or part of an item in the current view.  
  
## Syntax  
  
```  
  
      BOOL GetItemRect(  
   int nItem,  
   LPRECT lpRect,  
   UINT nCode   
) const;  
```  
  
#### Parameters  
 `nItem`  
 The index of the item whose position is to be retrieved.  
  
 `lpRect`  
 Address of a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that receives the bounding rectangle.  
  
 `nCode`  
 Portion of the list view item for which to retrieve the bounding rectangle. It can be one of these values:  
  
-   `LVIR_BOUNDS` Returns the bounding rectangle of the entire item, including the icon and label.  
  
-   `LVIR_ICON` Returns the bounding rectangle of the icon or small icon.  
  
-   `LVIR_LABEL` Returns the bounding rectangle of the item text.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#23](../vs140/codesnippet/CPP/clistctrl--getitemrect_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItemPosition](../vs140/clistctrl--getitemposition.md)   
 [CListCtrl::SetItemPosition](../vs140/clistctrl--setitemposition.md)   
 [CListCtrl::GetOrigin](../vs140/clistctrl--getorigin.md)
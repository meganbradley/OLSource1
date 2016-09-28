---
title: "CListCtrl::GetItemPosition"
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
  - "CListCtrl.GetItemPosition"
  - "CListCtrl::GetItemPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemPosition method"
ms.assetid: 74a95ba4-f295-4503-898f-1993aef2cec9
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetItemPosition
Retrieves the position of a list view item.  
  
## Syntax  
  
```  
  
      BOOL GetItemPosition(  
   int nItem,  
   LPPOINT lpPoint   
) const;  
```  
  
#### Parameters  
 `nItem`  
 The index of the item whose position is to be retrieved.  
  
 `lpPoint`  
 Address of a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that receives the position of the item's upper-left corner, in view coordinates.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#22](../vs140/codesnippet/CPP/clistctrl--getitemposition_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetItemPosition](../vs140/clistctrl--setitemposition.md)   
 [CListCtrl::GetOrigin](../vs140/clistctrl--getorigin.md)
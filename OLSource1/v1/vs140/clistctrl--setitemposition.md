---
title: "CListCtrl::SetItemPosition"
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
  - "CListCtrl::SetItemPosition"
  - "CListCtrl.SetItemPosition"
  - "SetItemPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemPosition method"
ms.assetid: 16cd3d27-b75a-4694-8fb0-1e9e4b04f9c2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetItemPosition
Moves an item to a specified position in a list view control.  
  
## Syntax  
  
```  
  
      BOOL SetItemPosition(  
   int nItem,  
   POINT pt   
);  
```  
  
#### Parameters  
 `nItem`  
 Index of the item whose position is to be set.  
  
 `pt`  
 A [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure specifying the new position, in view coordinates, of the item's upper-left corner.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The control must be in icon or small icon view.  
  
 If the list view control has the `LVS_AUTOARRANGE` style, the list view is arranged after the position of the item is set.  
  
## Example  
 See the example for [CListCtrl::GetItemPosition](../vs140/clistctrl--getitemposition.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItemPosition](../vs140/clistctrl--getitemposition.md)   
 [CListCtrl::GetOrigin](../vs140/clistctrl--getorigin.md)
---
title: "CTabCtrl::GetItemRect"
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
  - "CTabCtrl.GetItemRect"
  - "CTabCtrl::GetItemRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemRect method [MFC]"
ms.assetid: db48c976-2db6-4c3c-9d84-0c1872d94fba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::GetItemRect
Retrieves the bounding rectangle for the specified tab in a tab control.  
  
## Syntax  
  
```  
  
      BOOL GetItemRect(  
  int nItem,  
  LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `nItem`  
 Zero-based index of the tab item.  
  
 `lpRect`  
 Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that receives the bounding rectangle of the tab. These coordinates use the viewport's current mapping mode.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 See the example for [CPropertySheet::GetTabControl](../vs140/cpropertysheet--gettabcontrol.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::SetItemSize](../vs140/ctabctrl--setitemsize.md)   
 [CTabCtrl::AdjustRect](../vs140/ctabctrl--adjustrect.md)
---
title: "CListCtrl::GetCheck"
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
  - "CListCtrl.GetCheck"
  - "CListCtrl::GetCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCheck method"
ms.assetid: 874903ad-7e3e-4052-94c2-b1451457b241
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetCheck
Retrieves the current display status of the state image that is associated with an item.  
  
## Syntax  
  
```  
  
      BOOL GetCheck(  
   int nItem   
) const;  
```  
  
#### Parameters  
 `nItem`  
 The zero-based index of a list control item.  
  
## Return Value  
 Nonzero if the item is selected, otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetCheckState](http://msdn.microsoft.com/library/windows/desktop/bb761250), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CListCtrl::SetCheck](../vs140/clistctrl--setcheck.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetCheck](../vs140/clistctrl--setcheck.md)
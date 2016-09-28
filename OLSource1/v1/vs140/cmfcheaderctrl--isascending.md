---
title: "CMFCHeaderCtrl::IsAscending"
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
  - "CMFCHeaderCtrl.IsAscending"
  - "IsAscending"
  - "CMFCHeaderCtrl::IsAscending"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAscending method"
ms.assetid: aebe7857-5f73-48e2-847d-e39d693c23d9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCHeaderCtrl::IsAscending
Indicates whether any column in the header control is sorted in ascending order.  
  
## Syntax  
  
```  
BOOL IsAscending() const;  
```  
  
## Return Value  
 `TRUE` if any column in the header control is sorted in ascending order; otherwise, `FALSE`.  
  
## Remarks  
 The value that this method returns is used to display the appropriate sort arrow on the header control item. Use the [CMFCHeaderCtrl::SetSortColumn](../vs140/cmfcheaderctrl--setsortcolumn.md) method to set the sort order.  
  
## Requirements  
 **Header:** afxheaderctrl.h  
  
## See Also  
 [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCHeaderCtrl::SetSortColumn](../vs140/cmfcheaderctrl--setsortcolumn.md)
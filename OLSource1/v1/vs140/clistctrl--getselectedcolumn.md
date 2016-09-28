---
title: "CListCtrl::GetSelectedColumn"
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
  - "CListCtrl.GetSelectedColumn"
  - "CListCtrl::GetSelectedColumn"
  - "GetSelectedColumn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelectedColumn"
  - "CListCtrl class, operations"
ms.assetid: 539e0869-a767-4d47-9235-6fb5b2f4eec8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetSelectedColumn
Retrieves the index of the currently-selected column in the list control.  
  
## Syntax  
  
```  
  
UINT GetSelectedColumn( ) const;  
  
```  
  
## Return Value  
 The index of the selected column.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_GETSELECTEDCOLUMN](http://msdn.microsoft.com/library/windows/desktop/bb761067) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl::SetSelectedColumn](../vs140/clistctrl--setselectedcolumn.md)   
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
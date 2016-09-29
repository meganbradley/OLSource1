---
title: "CMFCListCtrl::EnableMultipleSort"
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
  - "CMFCListCtrl::EnableMultipleSort"
  - "CMFCListCtrl.EnableMultipleSort"
  - "EnableMultipleSort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableMultipleSort method"
ms.assetid: 6518ff5d-b9c6-4e39-9a3e-4e69aa95a7f5
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCListCtrl::EnableMultipleSort
Enables sorting the rows of data in the list control by multiple columns.  
  
## Syntax  
  
```  
void EnableMultipleSort(  
   BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 A Boolean that specifies whether to enable multiple column sort mode.  
  
## Remarks  
 When you enable sorting based on multiple columns, the columns do have a hierarchy. The rows of data will first be sorted by the primary column. Any equivalent values are then sorted by each subsequent column based on priority.  
  
## Requirements  
 **Header:** afxlistctrl.h  
  
## See Also  
 [CMFCListCtrl Class](../vs140/cmfclistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
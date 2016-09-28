---
title: "CMFCHeaderCtrl::GetSortColumn"
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
  - "GetSortColumn"
  - "CMFCHeaderCtrl.GetSortColumn"
  - "CMFCHeaderCtrl::GetSortColumn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSortColumn method"
ms.assetid: ebb9ee01-f64b-4545-8e32-10139a44ecb7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCHeaderCtrl::GetSortColumn
Retrieves the zero-based index of the first sorted column in the header control.  
  
## Syntax  
  
```  
int GetSortColumn() const;  
```  
  
## Return Value  
 The index of a sorted column, or -1 if no sorted column is found.  
  
## Remarks  
 If the header control is in *multiple column sort* mode and you compiled the application in debug mode, this method asserts and advises you to use the [CMFCHeaderCtrl::GetColumnState](../vs140/cmfcheaderctrl--getcolumnstate.md) method instead. If the header control is in multiple column sort mode and you compiled the application in retail mode, this method returns -1.  
  
## Requirements  
 **Header:** afxheaderctrl.h  
  
## See Also  
 [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCHeaderCtrl::SetSortColumn](../vs140/cmfcheaderctrl--setsortcolumn.md)
---
title: "CMFCListCtrl::OnGetCellBkColor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnGetCellBkColor
  - CMFCListCtrl::OnGetCellBkColor
  - CMFCListCtrl.OnGetCellBkColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnGetCellBkColor method
ms.assetid: bbcc477e-d70d-42bf-a47a-d9762d0bcd8f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCListCtrl::OnGetCellBkColor
The framework calls this method when it must determine the background color of an individual cell.  
  
## Syntax  
  
```  
virtual COLORREF OnGetCellBkColor(  
   int nRow,  
   int nColumn   
);  
```  
  
#### Parameters  
 [in] `nRow`  
 The row of the cell in question.  
  
 [in] `nColumn`  
 The column of the cell in question.  
  
## Return Value  
 A `COLOREF` value that specifies the background color of the cell.  
  
## Remarks  
 The default implementation of `OnGetCellBkColor` does not use the supplied input parameters and instead simply calls `GetBkColor`. Therefore, by default, the whole list control will have the same background color. You can override `OnGetCellBkColor` in a derived class to mark individual cells with a separate background color.  
  
## Requirements  
 **Header:** afxlistctrl.h  
  
## See Also  
 [CMFCListCtrl Class](../vs140/cmfclistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
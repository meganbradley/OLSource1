---
title: "CListCtrl::GetColumn"
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
  - "CListCtrl::GetColumn"
  - "LVCF_FMT"
  - "LV_COLUMN"
  - "LVCF_WIDTH"
  - "LVCF_SUBITEM"
  - "GetColumn"
  - "CListCtrl.GetColumn"
  - "LVCF_TEXT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetColumn method"
  - "LV_COLUMN"
  - "LVCF_SUBITEM"
  - "LVCF_WIDTH"
  - "LVCF_TEXT"
  - "LVCF_FMT"
ms.assetid: ad6950d4-71d9-4f7d-a4f4-4317128a261a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetColumn
Retrieves the attributes of a list view control's column.  
  
## Syntax  
  
```  
  
      BOOL GetColumn(  
   int nCol,  
   LVCOLUMN* pColumn   
) const;  
```  
  
#### Parameters  
 `nCol`  
 Index of the column whose attributes are to be retrieved.  
  
 `pColumn`  
 Address of an [LVCOLUMN](http://msdn.microsoft.com/library/windows/desktop/bb774743) structure that specifies the information to retrieve and receives information about the column. The **mask** member specifies which column attributes to retrieve. If the **mask** member specifies the `LVCF_TEXT` value, the **pszText** member must contain the address of the buffer that receives the item text and the **cchTextMax** member must specify the size of the buffer.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The **LVCOLUMN** structure contains information about a column in report view.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#11](../vs140/codesnippet/CPP/clistctrl--getcolumn_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetColumn](../vs140/clistctrl--setcolumn.md)   
 [CListCtrl::GetColumnWidth](../vs140/clistctrl--getcolumnwidth.md)
---
title: "CListCtrl::InsertColumn"
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
  - "InsertColumn"
  - "CListCtrl::InsertColumn"
  - "CListCtrl.InsertColumn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertColumn method"
ms.assetid: 7457d8e5-8848-40fb-a91a-d038ba052a0d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::InsertColumn
Inserts a new column in a list view control.  
  
## Syntax  
  
```  
  
      int InsertColumn(  
   int nCol,  
   const LVCOLUMN* pColumn   
);  
int InsertColumn(  
   int nCol,  
   LPCTSTR lpszColumnHeading,  
   int nFormat = LVCFMT_LEFT,  
   int nWidth = -1,  
   int nSubItem = -1   
);  
```  
  
#### Parameters  
 `nCol`  
 The index of the new column.  
  
 `pColumn`  
 Address of an **LVCOLUMN** structure that contains the attributes of the new column.  
  
 *lpszColumnHeading*  
 Address of a string containing the column's heading.  
  
 `nFormat`  
 Integer specifying the alignment of the column. It can be one of these values: **LVCFMT_LEFT**, **LVCFMT_RIGHT**, or **LVCFMT_CENTER**.  
  
 `nWidth`  
 Width of the column, in pixels. If this parameter is -1, the column width is not set.  
  
 `nSubItem`  
 Index of the subitem associated with the column. If this parameter is -1, no subitem is associated with the column.  
  
## Return Value  
 The index of the new column if successful or -1 otherwise.  
  
## Remarks  
 The leftmost column in a list view control must be left-aligned.  
  
 The [LVCOLUMN](http://msdn.microsoft.com/library/windows/desktop/bb774743) structure contains the attributes of a column in report view. It is also used to receive information about a column. This structure is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::DeleteColumn](../vs140/clistctrl--deletecolumn.md)
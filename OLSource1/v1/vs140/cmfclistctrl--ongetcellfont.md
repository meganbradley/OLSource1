---
title: "CMFCListCtrl::OnGetCellFont"
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
  - "CMFCListCtrl::OnGetCellFont"
  - "CMFCListCtrl.OnGetCellFont"
  - "OnGetCellFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetCellFont method"
ms.assetid: 365e5862-38e0-4cbc-9f75-c0062f8997ce
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCListCtrl::OnGetCellFont
The framework calls this method when it obtains the font for an individual cell.  
  
## Syntax  
  
```  
virtual HFONT OnGetCellFont(  
   int nRow,  
   int nColumn,  
   DWORD dwData = 0   
);  
```  
  
#### Parameters  
 [in] `nRow`  
 The row of the cell in question.  
  
 [in] `nColumn`  
 The column of the cell in question.  
  
 [in] `dwData`  
 User-defined data. The default implementation does not use this parameter.  
  
## Return Value  
 A handle to the font that is used for the current cell.  
  
## Remarks  
 By default, this method returns `NULL`. All of the cells in a list control have the same font. Override this method in order to provide different fonts for different cells.  
  
## Requirements  
 **Header:** afxlistctrl.h  
  
## See Also  
 [CMFCListCtrl Class](../vs140/cmfclistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
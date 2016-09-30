---
title: "CMFCListCtrl::SetSortColumn"
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
  - "SetSortColumn"
  - "CMFCListCtrl::SetSortColumn"
  - "CMFCListCtrl.SetSortColumn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSortColumn method"
ms.assetid: 9984bf7c-2185-4abe-ab0e-b3700a35ddd6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCListCtrl::SetSortColumn
Sets the current sorted column and the sort order.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The column to sort.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A Boolean that specifies the sort order.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean that specifies whether the method adds the column indicated by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to the list of sort columns.  
  
## Remarks  
 This method passes the input parameters to the header control by using the method [CMFCHeaderCtrl::SetSortColumn](../vs140/cmfcheaderctrl--setsortcolumn.md).  
  
## Requirements  
 **Header:** afxlistctrl.h  
  
## See Also  
 [CMFCListCtrl Class](../vs140/cmfclistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
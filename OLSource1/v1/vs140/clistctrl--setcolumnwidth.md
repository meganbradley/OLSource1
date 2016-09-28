---
title: "CListCtrl::SetColumnWidth"
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
  - "CListCtrl::SetColumnWidth"
  - "CListCtrl.SetColumnWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColumnWidth method"
ms.assetid: 285f277c-a5af-4546-9bb2-e270df855868
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetColumnWidth
Changes the width of a column in report view or list view.  
  
## Syntax  
  
```  
  
      BOOL SetColumnWidth(  
   int nCol,  
   int cx   
);  
```  
  
#### Parameters  
 `nCol`  
 Index of the column for which the width is to be set. In list view, this parameter must be 0.  
  
 `cx`  
 The new width of the column. Can be either **LVSCW_AUTOSIZE** or **LVSCW_AUTOSIZE_USEHEADER**, as described in [LVM_SETCOLUMNWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb761163) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetColumnWidth](../vs140/clistctrl--getcolumnwidth.md)   
 [CListCtrl::GetStringWidth](../vs140/clistctrl--getstringwidth.md)
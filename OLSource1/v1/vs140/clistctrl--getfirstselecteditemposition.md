---
title: "CListCtrl::GetFirstSelectedItemPosition"
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
  - "CListCtrl::GetFirstSelectedItemPosition"
  - "CListCtrl.GetFirstSelectedItemPosition"
  - "GetFirstSelectedItemPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFirstSelectedItemPosition method"
ms.assetid: 6d6a849e-c08b-4e5b-ad17-07162ffdbb80
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetFirstSelectedItemPosition
Gets the position of the first selected item in the list view control.  
  
## Syntax  
  
```  
  
POSITION GetFirstSelectedItemPosition( ) const;  
  
```  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if no items are selected.  
  
## Example  
 The following code sample demonstrates the usage of this function.  
  
 [!code[NVC_MFC_CListCtrl#15](../vs140/codesnippet/CPP/clistctrl--getfirstselecteditemposition_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList Class](../vs140/cimagelist-class.md)   
 [CListCtrl::GetNextSelectedItem](../vs140/clistctrl--getnextselecteditem.md)
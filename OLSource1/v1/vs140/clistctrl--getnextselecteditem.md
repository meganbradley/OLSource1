---
title: "CListCtrl::GetNextSelectedItem"
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
  - "GetNextSelectedItem"
  - "CListCtrl::GetNextSelectedItem"
  - "CListCtrl.GetNextSelectedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextSelectedItem method"
ms.assetid: 26c65d3a-3253-4e39-a03e-4be037804338
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetNextSelectedItem
Gets the index of the list item identified by `pos`, then sets *pos* to the **POSITION** value.  
  
## Syntax  
  
```  
  
      int GetNextSelectedItem(  
   POSITION& pos   
) const;  
```  
  
#### Parameters  
 `pos`  
 A reference to a **POSITION** value returned by a previous call to `GetNextSelectedItem` or `GetFirstSelectedItemPosition`. The value is updated to the next position by this call.  
  
## Return Value  
 The index of the list item identified by `pos`.  
  
## Remarks  
 You can use `GetNextSelectedItem` in a forward iteration loop if you establish the initial position with a call to `GetFirstSelectedItemPosition`.  
  
 You must ensure that your **POSITION** value is valid. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
## Example  
 The following code sample demonstrates the usage of this function.  
  
 [!code[NVC_MFC_CListCtrl#15](../vs140/codesnippet/CPP/clistctrl--getnextselecteditem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList Class](../vs140/cimagelist-class.md)   
 [CListCtrl::GetFirstSelectedItemPosition](../vs140/clistctrl--getfirstselecteditemposition.md)
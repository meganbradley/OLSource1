---
title: "CMFCRibbonComboBox::DeleteItem"
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
  - "DeleteItem"
  - "CMFCRibbonComboBox.DeleteItem"
  - "CMFCRibbonComboBox::DeleteItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteItem method"
ms.assetid: d23b1c68-2bb4-4b74-b1ea-a8caa0c58d0c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonComboBox::DeleteItem
Deletes a specified item from the list box.  
  
## Syntax  
  
```  
BOOL DeleteItem(  
   int iIndex   
);  
BOOL DeleteItem(  
   DWORD_PTR dwData   
);  
BOOL DeleteItem(  
   LPCTSTR lpszText   
);  
```  
  
#### Parameters  
 [in] `iIndex`  
 The zero-based index of the item to be deleted.  
  
 [in] `dwData`  
 The data associated with the item to be deleted.  
  
 [in] `lpszText`  
 The string of the item to be deleted. If there are multiple items with the same string, the first item is deleted.  
  
## Return Value  
 `TRUE` if the specified item has been deleted; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncombobox.h  
  
## See Also  
 [CMFCRibbonComboBox Class](../vs140/cmfcribboncombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
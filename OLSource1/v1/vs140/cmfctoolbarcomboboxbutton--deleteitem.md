---
title: "CMFCToolBarComboBoxButton::DeleteItem"
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
  - CMFCToolBarComboBoxButton::DeleteItem
  - DeleteItem
  - CMFCToolBarComboBoxButton.DeleteItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - DeleteItem method
ms.assetid: 8a790f08-84ba-4180-8bb9-40a5957b2bfa
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::DeleteItem
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
 The text of the item to be deleted. If there are multiple items with the same text, the first item is deleted.  
  
## Return Value  
 `TRUE` if the item was located and successfully deleted; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
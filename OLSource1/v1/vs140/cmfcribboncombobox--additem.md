---
title: "CMFCRibbonComboBox::AddItem"
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
  - AddItem
  - CMFCRibbonComboBox.AddItem
  - CMFCRibbonComboBox::AddItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddItem method
ms.assetid: eeaf78bf-c556-49e3-8565-7d9c58e646bf
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonComboBox::AddItem
Appends a unique item to the list box.  
  
## Syntax  
  
```  
virtual INT_PTR AddItem(  
   LPCTSTR lpszItem,  
   DWORD_PTR dwData=0   
);  
```  
  
#### Parameters  
 [in] `lpszItem`  
 The string of the item to add.  
  
 [in] `dwData`  
 The data associated with the item to add.  
  
## Return Value  
 The zero-based index of the appended item.  
  
## Requirements  
 **Header:** afxribboncombobox.h  
  
## See Also  
 [CMFCRibbonComboBox Class](../vs140/cmfcribboncombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
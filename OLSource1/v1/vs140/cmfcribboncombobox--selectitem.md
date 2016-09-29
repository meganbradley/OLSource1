---
title: "CMFCRibbonComboBox::SelectItem"
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
  - "CMFCRibbonComboBox::SelectItem"
  - "CMFCRibbonComboBox.SelectItem"
  - "SelectItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectItem method"
ms.assetid: f7da8595-8f2e-4b76-b361-88159e0cec68
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonComboBox::SelectItem
Selects an item in the list box.  
  
## Syntax  
  
```  
BOOL SelectItem(  
   int iIndex   
);  
BOOL SelectItem(  
   DWORD_PTR dwData   
);  
BOOL SelectItem(  
   LPCTSTR lpszText   
);  
```  
  
#### Parameters  
 [in] `iIndex`  
 The zero-based index of an item in the list box.  
  
 [in] `dwData`  
 The data associated with an item in the list box.  
  
 [in] `lpszText`  
 The string of an item in the list box.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncombobox.h  
  
## See Also  
 [CMFCRibbonComboBox Class](../vs140/cmfcribboncombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
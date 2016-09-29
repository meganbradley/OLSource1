---
title: "CMFCToolBarComboBoxButton::GetItemAll"
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
  - "CMFCToolBarComboBoxButton.GetItemAll"
  - "GetItemAll"
  - "CMFCToolBarComboBoxButton::GetItemAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemAll method"
ms.assetid: c717b591-c5a3-4a06-a9be-6b96eeb3869d
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::GetItemAll
Returns the string associated with an item at a specified index in the list box of a combo box button that has a specified command ID.  
  
## Syntax  
  
```  
static LPCTSTR GetItemAll(  
   UINT uiCmd,  
   int iIndex=-1   
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 The command ID of a combo box button.  
  
 [in] `iIndex`  
 The zero-based index of an item in the list box.  
  
## Return Value  
 A pointer to the item's string if the method was successful; otherwise, `NULL` if the index is invalid, a combo box button is not found, or if index is -1 and there is no selected item in the combo box.  
  
## Remarks  
 An index value of -1 returns the string of the item that is currently selected.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
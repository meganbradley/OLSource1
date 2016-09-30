---
title: "CMFCToolBarComboBoxButton::GetItemDataAll"
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
  - "GetItemDataAll"
  - "CMFCToolBarComboBoxButton.GetItemDataAll"
  - "CMFCToolBarComboBoxButton::GetItemDataAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemDataAll method"
ms.assetid: 2c785e1c-6fe9-4bf8-a5f0-60fde13968fa
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::GetItemDataAll
Returns the data associated with an item at a specific index in the list box of a combo box button that has a specific command ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID of a combo box button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
## Return Value  
 The data associated with the item if the method was successful; otherwise, 0 if the specified index is not valid, or CB_ERR if the combo box button is not found.  
  
## Remarks  
 An index parameter of -1 returns the data associated with the currently selected item.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
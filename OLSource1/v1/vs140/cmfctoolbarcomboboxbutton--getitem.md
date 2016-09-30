---
title: "CMFCToolBarComboBoxButton::GetItem"
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
  - "GetItem"
  - "CMFCToolBarComboBoxButton.GetItem"
  - "CMFCToolBarComboBoxButton::GetItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItem method"
ms.assetid: f13c4658-2fdf-4298-9c87-44dead707183
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::GetItem
Returns the string associated with an item at a specified index in the list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of an item in the list box.  
  
## Return Value  
 A pointer to the string that is associated with the item; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the index parameter is invalid, or if the index parameter is -1 and there is no selected item in the combo box.  
  
## Remarks  
 An index parameter of -1 returns the string of the item that is currently selected.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
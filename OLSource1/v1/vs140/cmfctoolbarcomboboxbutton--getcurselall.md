---
title: "CMFCToolBarComboBoxButton::GetCurSelAll"
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
  - CMFCToolBarComboBoxButton::GetCurSelAll
  - CMFCToolBarComboBoxButton.GetCurSelAll
  - GetCurSelAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCurSelAll method
ms.assetid: 59c362be-614f-4375-b68c-d346f4089373
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::GetCurSelAll
Returns the index of the currently selected item in the list box of a combo box button that has a specified command ID.  
  
## Syntax  
  
```  
static int GetCurSelAll(  
   UINT uiCmd   
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 The command ID of a combo box button.  
  
## Return Value  
 The index of the currently selected item in the list box; otherwise, `CB_ERR` if no item is selected or a combo box button is not found.  
  
## Remarks  
 The list box index is zero-based.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
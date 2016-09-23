---
title: "CMFCToolBarComboBoxButton::SelectItemAll"
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
  - CMFCToolBarComboBoxButton::SelectItemAll
  - CMFCToolBarComboBoxButton.SelectItemAll
  - SelectItemAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - SelectItemAll method
ms.assetid: 7989ad69-ed3b-45fc-85db-266307fcb503
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::SelectItemAll
Selects an item in the list box of a combo box button that has a specified command ID.  
  
## Syntax  
  
```  
static BOOL SelectItemAll(  
   UINT uiCmd,  
   int iIndex   
);  
static BOOL SelectItemAll(  
   UINT uiCmd,  
   DWORD_PTR dwData   
);  
static BOOL SelectItemAll(  
   UINT uiCmd,  
   LPCTSTR lpszText   
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 The command ID of the combo box button that contains the list box.  
  
 [in] `iIndex`  
 The zero-based index of the item in the list box. A value of -1 removes any current selection in the list box and clears the edit box.  
  
 [in] `dwData`  
 The data of an item in the list box.  
  
 [in] `lpszText`  
 The text of an item in the list box.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
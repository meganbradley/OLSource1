---
title: "CMFCToolBarComboBoxButton::GetItemDataPtrAll"
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
  - CMFCToolBarComboBoxButton::GetItemDataPtrAll
  - GetItemDataPtrAll
  - CMFCToolBarComboBoxButton.GetItemDataPtrAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemDataPtrAll method
ms.assetid: 9a5b385e-71e4-47ca-ba02-fc1f15076e2c
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::GetItemDataPtrAll
Returns the data associated with an item at a specific index in the list box of a combo box button that has a specific command ID. This data is returned as a pointer.  
  
## Syntax  
  
```  
static void* GetItemDataPtrAll(  
   UINT uiCmd,  
   int iIndex=-1  
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 The command ID of the combo box button.  
  
 [in] `iIndex`  
 The zero-based index of an item in the list box.  
  
## Return Value  
 A pointer associated with the item if the method was successful; otherwise, -1 if an error occurs, or `NULL` if the combo box button is not found.  
  
## Remarks  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
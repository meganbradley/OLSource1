---
title: "CMFCToolBarComboBoxButton::GetCountAll"
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
  - CMFCToolBarComboBoxButton::GetCountAll
  - GetCountAll
  - CMFCToolBarComboBoxButton.GetCountAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCountAll method
ms.assetid: 8232fc8d-3ca6-406b-9fde-0d78c1fcfadf
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::GetCountAll
Gets the number of items in the list box of a combo box button that has a specified command ID.  
  
## Syntax  
  
```  
static int GetCountAll(  
   UINT uiCmd   
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 The command ID of a combo box button.  
  
## Return Value  
 The number of items in the list box; otherwise, `CB_ERR` if the combo box button is not found.  
  
## Remarks  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
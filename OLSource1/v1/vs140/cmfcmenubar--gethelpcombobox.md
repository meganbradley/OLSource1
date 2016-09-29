---
title: "CMFCMenuBar::GetHelpCombobox"
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
  - "GetHelpCombobox"
  - "CMFCMenuBar::GetHelpCombobox"
  - "CMFCMenuBar.GetHelpCombobox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHelpCombobox method"
ms.assetid: 271238fa-9f93-4e49-948c-3409d99a9899
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::GetHelpCombobox
Returns a pointer to the **Help** combo box.  
  
## Syntax  
  
```  
CMFCToolBarComboBoxButton* GetHelpCombobox();  
```  
  
## Return Value  
 A pointer to the **Help** combo box. `NULL` if the **Help** combo box is hidden or not enabled.  
  
## Remarks  
 The **Help** combo box is located on the right side of the menu bar. Call the method [CMFCMenuBar::EnableHelpCombobox](../vs140/cmfcmenubar--enablehelpcombobox.md) to enable this combo box.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::EnableHelpCombobox](../vs140/cmfcmenubar--enablehelpcombobox.md)
---
title: "CMFCToolBarComboBoxButton::ExportToMenuButton"
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
  - "ExportToMenuButton"
  - "CMFCToolBarComboBoxButton::ExportToMenuButton"
  - "CMFCToolBarComboBoxButton.ExportToMenuButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExportToMenuButton method"
ms.assetid: ade466b6-a4b1-4dc1-a6d6-8d7fab20e9bd
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::ExportToMenuButton
Copies a string from the application string table to the specified menu using the combo box button command ID.  
  
## Syntax  
  
```  
virtual BOOL ExportToMenuButton(  
   CMFCToolBarMenuButton& menuButton  
) const;  
```  
  
#### Parameters  
 [out] `menuButton`  
 Reference to a menu button.  
  
## Return Value  
 Always `TRUE`.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)
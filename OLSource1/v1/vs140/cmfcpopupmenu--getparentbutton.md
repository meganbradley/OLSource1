---
title: "CMFCPopupMenu::GetParentButton"
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
  - "CMFCPopupMenu.GetParentButton"
  - "GetParentButton"
  - "CMFCPopupMenu::GetParentButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParentButton method"
ms.assetid: 9ba01797-f020-4968-bc6a-417102e5b8d7
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::GetParentButton
Returns a pointer to the parent toolbar button.  
  
## Syntax  
  
```  
CMFCToolBarMenuButton* GetParentButton() const;  
```  
  
## Return Value  
 A pointer to the parent toolbar button. `NULL` if the pop-up menu has no parent toolbar button.  
  
## Remarks  
 A [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) can be associated with a button on the menu. In this scenario, the pop-up menu appears when a user selects the parent toolbar button.  
  
 If the pop-up menu is a shortcut menu, it will have no parent toolbar button.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)
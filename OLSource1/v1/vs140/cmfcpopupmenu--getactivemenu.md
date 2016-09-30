---
title: "CMFCPopupMenu::GetActiveMenu"
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
  - "CMFCPopupMenu.GetActiveMenu"
  - "GetActiveMenu"
  - "CMFCPopupMenu::GetActiveMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActiveMenu method"
ms.assetid: d2a834e9-96aa-4241-94aa-6007bd1191e6
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::GetActiveMenu
Returns the currently active menu.  
  
## Syntax  
  
```  
static CMFCPopupMenu* GetActiveMenu();  
```  
  
## Return Value  
 A pointer to the active pop-up menu, or NULL if no pop-up menu is currently active.  
  
## Remarks  
 Each application can have at most one active pop-up menu.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
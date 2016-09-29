---
title: "CMFCPopupMenu::GetParentPopupMenu"
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
  - "CMFCPopupMenu::GetParentPopupMenu"
  - "GetParentPopupMenu"
  - "CMFCPopupMenu.GetParentPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParentPopupMenu method"
ms.assetid: ffb91e2f-bea7-4770-83be-ca8bcdff8440
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::GetParentPopupMenu
Returns a pointer to the parent pop-up menu.  
  
## Syntax  
  
```  
CMFCPopupMenu* GetParentPopupMenu() const;  
```  
  
## Return Value  
 A pointer to the parent [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object; `NULL` if there is no parent pop-up menu.  
  
## Remarks  
 A pop-up menu has a parent `CMFCPopupMenu` object only if it is a submenu.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
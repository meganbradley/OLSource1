---
title: "CContextMenuManager::SetDontCloseActiveMenu"
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
  - "SetDontCloseActiveMenu"
  - "CContextMenuManager::SetDontCloseActiveMenu"
  - "CContextMenuManager.SetDontCloseActiveMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDontCloseActiveMenu method"
ms.assetid: bfae356b-3896-4f00-8bef-ed7741d04661
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContextMenuManager::SetDontCloseActiveMenu
Controls whether the [CContextMenuManager](../vs140/ccontextmenumanager-class.md) closes the active pop-up menu when it displays a new pop-up menu.  
  
## Syntax  
  
```  
void SetDontCloseActiveMenu (  
   BOOL bSet = TRUE  
);  
```  
  
#### Parameters  
 [in] `bSet`  
 A Boolean parameter that controls whether to close the active pop-up menu. A value of `TRUE` indicates the active pop-up menu is not closed. `FALSE` indicates that the active pop-up menu is closed.  
  
## Remarks  
 By default, the `CContextMenuManager` closes the active pop-up menu.  
  
## See Also  
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
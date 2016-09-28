---
title: "CMFCPopupMenu::IsSendMenuSelectMsg"
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
  - "CMFCPopupMenu::IsSendMenuSelectMsg"
  - "CMFCPopupMenu.IsSendMenuSelectMsg"
  - "IsSendMenuSelectMsg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSendMenuSelectMsg method"
ms.assetid: ae797b13-1c44-4b67-a371-30ac221b0e4d
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::IsSendMenuSelectMsg
Indicates whether the framework notifies the parent frame when the user selects a command from the pop-up menu.  
  
## Syntax  
  
```  
static BOOL IsSendMenuSelectMsg();  
```  
  
## Return Value  
 `TRUE` if the framework notifies the parent frame; otherwise `FALSE`.  
  
## Remarks  
 The framework notifies the parent frame by sending it the `WM_MENUSELECT` message when a used selects a menu command.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
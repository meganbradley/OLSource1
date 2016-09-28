---
title: "CMFCPopupMenu::GetMessageWnd"
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
  - "GetMessageWnd"
  - "CMFCPopupMenu.GetMessageWnd"
  - "CMFCPopupMenu::GetMessageWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMessageWnd method"
ms.assetid: eaa1f232-6501-495b-bf22-18ba52de82f0
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::GetMessageWnd
Returns a pointer to the window where the framework routes the pop-up menu messages.  
  
## Syntax  
  
```  
CWnd* GetMessageWnd() const;  
```  
  
## Return Value  
 A pointer to the window that receives the pop-up menu messages; `NULL` if there is no window.  
  
## Remarks  
 When you use the method [CMFCPopupMenu::Create](../vs140/cmfcpopupmenu--create.md) to create a pop-up menu, you specify what window receives the menu messages.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenu::Create](../vs140/cmfcpopupmenu--create.md)
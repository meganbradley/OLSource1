---
title: "CMFCToolBar::ProcessCommand"
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
  - "ProcessCommand"
  - "CMFCToolBar.ProcessCommand"
  - "CMFCToolBar::ProcessCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ProcessCommand method"
ms.assetid: b00af7c6-3112-4c17-861f-95c26efd1e71
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::ProcessCommand
Posts a `WM_COMMAND` message to the window that owns the toolbar.  
  
## Syntax  
  
```  
BOOL ProcessCommand(  
   CMFCToolBarButton* pButton  
);  
```  
  
#### Parameters  
 [in] `pButton`  
 Pointer to a button on the toolbar.  
  
## Return Value  
 This method should always return `TRUE`. MFC uses `FALSE` values internally.  
  
## Remarks  
 This method posts a `WM_COMMAND` message to the window that owns the toolbar by calling [CWnd::PostMessage](../vs140/cwnd--postmessage.md) and passing the command ID of the specified button as the `wParam` parameter.  
  
 Use the [ON_COMMAND](../vs140/on_command.md) macro to map the `WM_COMMAND` message to a member function.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
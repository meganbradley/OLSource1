---
title: "CMFCToolBar::IsLastCommandFromButton"
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
  - CMFCToolBar.IsLastCommandFromButton
  - CMFCToolBar::IsLastCommandFromButton
  - IsLastCommandFromButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsLastCommandFromButton method
ms.assetid: 6f93f2ab-719d-4f0b-a5a7-b202e1b3a218
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::IsLastCommandFromButton
Determines whether the most recently executed command was sent from the specified toolbar button.  
  
## Syntax  
  
```  
static BOOL IsLastCommandFromButton(  
   CMFCToolBarButton* pButton   
);  
```  
  
#### Parameters  
 [in] `pButton`  
 Pointer to button.  
  
## Return Value  
 `TRUE` if the last command was sent from the button that `pButton` specifies; otherwise `FALSE`.  
  
## Remarks  
 This method obtains a pointer to a [MSG Structure](../vs140/msg-structure.md) by calling `CWnd::GetCurrentMessage`. It then compares the `HWND` of the button with the `MSG::lParam` and `MSG::hwnd` members to determine whether the button was the source of the command.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
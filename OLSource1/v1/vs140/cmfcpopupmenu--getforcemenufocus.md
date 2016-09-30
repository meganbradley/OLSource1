---
title: "CMFCPopupMenu::GetForceMenuFocus"
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
  - "GetForceMenuFocus"
  - "CMFCPopupMenu.GetForceMenuFocus"
  - "CMFCPopupMenu::GetForceMenuFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetForceMenuFocus method"
ms.assetid: 40e3387d-60a4-4012-af47-c03c6ce0705b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::GetForceMenuFocus
Indicates whether the focus is returned to the menu bar when a pop-up menu is displayed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the input focus is returned to the menu bar when a pop-up menu is displayed; <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the pop-up menu retains the focus.  
  
## Remarks  
 By default, your application does not return focus to the menu bar. To change this setting, use [CMFCPopupMenu::SetForceMenuFocus](../vs140/cmfcpopupmenu--setforcemenufocus.md).  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenu::SetForceMenuFocus](../vs140/cmfcpopupmenu--setforcemenufocus.md)
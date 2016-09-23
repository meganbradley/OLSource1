---
title: "CWnd::GetSystemMenu"
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
  - CWnd::GetSystemMenu
  - GetSystemMenu
  - CWnd.GetSystemMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSystemMenu method
ms.assetid: af5629b7-f6d2-4857-9620-f135850c1f2e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetSystemMenu
Allows the application to access the Control menu for copying and modification.  
  
## Syntax  
  
```  
  
      CMenu* GetSystemMenu(  
   BOOL bRevert   
) const;  
```  
  
#### Parameters  
 `bRevert`  
 Specifies the action to be taken. If `bRevert` is **FALSE**, `GetSystemMenu` returns a handle to a copy of the Control menu currently in use. This copy is initially identical to the Control menu but can be modified. If `bRevert` is **TRUE**, `GetSystemMenu` resets the Control menu back to the default state. The previous, possibly modified, Control menu, if any, is destroyed. The return value is undefined in this case.  
  
## Return Value  
 Identifies a copy of the Control menu if `bRevert` is **FALSE**. If `bRevert` is **TRUE**, the return value is undefined.  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 Any window that does not use `GetSystemMenu` to make its own copy of the Control menu receives the standard Control menu.  
  
 The pointer returned by the `GetSystemMenu` member function can be used with the [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md), [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md), or [CMenu::ModifyMenu](../vs140/cmenu--modifymenu.md) functions to change the Control menu.  
  
 The Control menu initially contains items identified with various ID values such as **SC_CLOSE**, **SC_MOVE**, and **SC_SIZE**. Items on the Control menu generate [WM_SYSCOMMAND](../vs140/cwnd--onsyscommand.md) messages. All predefined Control-menu items have ID numbers greater than 0xF000. If an application adds items to the Control menu, it should use ID numbers less than F000.  
  
 Windows may automatically make items unavailable on the standard Control menu. `CWnd` can carry out its own selection or unavailability by responding to the [WM_INITMENU](../vs140/cwnd--oninitmenu.md) messages, which are sent before any menu is displayed.  
  
## Example  
 [!code[NVC_MFCWindowing#99](../vs140/codesnippet/CPP/cwnd--getsystemmenu_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md)   
 [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md)   
 [CMenu::ModifyMenu](../vs140/cmenu--modifymenu.md)   
 [GetSystemMenu](http://msdn.microsoft.com/library/windows/desktop/ms647985)
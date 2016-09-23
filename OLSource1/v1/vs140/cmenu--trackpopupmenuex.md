---
title: "CMenu::TrackPopupMenuEx"
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
  - CMenu.TrackPopupMenuEx
  - CMenu::TrackPopupMenuEx
  - TrackPopupMenuEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - TrackPopupMenuEx method
ms.assetid: 2f071e3c-8af6-40f6-9cfb-8288833a10bc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMenu::TrackPopupMenuEx
Displays a floating pop-up menu at the specified location and tracks the selection of items on the pop-up menu.  
  
## Syntax  
  
```  
  
      BOOL TrackPopupMenuEx(   
   UINT fuFlags,   
   int x,   
   int y,   
   CWnd* pWnd,   
   LPTPMPARAMS lptpm   
);  
```  
  
#### Parameters  
 `fuFlags`  
 Specifies various functions for the extended menu. For a listing of all values and their meaning, see [TrackPopupMenuEx](http://msdn.microsoft.com/library/windows/desktop/ms648003).  
  
 *x*  
 Specifies the horizontal position in screen coordinates of the pop-up menu.  
  
 *y*  
 Specifies the vertical position in screen coordinates of the top of the menu on the screen.  
  
 `pWnd`  
 A pointer to the window owning the pop-up menu and receiving the messages from the created menu. This window can be any window from the current application but cannot be **NULL**. If you specify **TPM_NONOTIFY** in the `fuFlags` parameter, the function does not send any messages to `pWnd`. The function must return for the window pointed to by `pWnd` to receive the **WM_COMMAND** message.  
  
 *lptpm*  
 Pointer to a [TPMPARAMS](http://msdn.microsoft.com/library/windows/desktop/ms647586) structure that specifies an area of the screen the menu should not overlap. This parameter can be **NULL**.  
  
## Return Value  
 If you specify **TPM_RETURNCMD** in the `fuFlags` parameter, the return value is the menu-item identifier of the item that the user selected. If the user cancels the menu without making a selection, or if an error occurs, then the return value is 0.  
  
 If you do not specify **TPM_RETURNCMD** in the `fuFlags` parameter, the return value is nonzero if the function succeeds and 0 if it fails. To get extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 A floating pop-up menu can appear anywhere on the screen. For more information on handling errors when creating the pop-up menu, see [TrackPopupMenuEx](http://msdn.microsoft.com/library/windows/desktop/ms648003).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::CreatePopupMenu](../vs140/cmenu--createpopupmenu.md)   
 [CMenu::GetSubMenu](../vs140/cmenu--getsubmenu.md)
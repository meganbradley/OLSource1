---
title: "CMenu::TrackPopupMenu"
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
  - "TrackPopupMenu"
  - "CMenu::TrackPopupMenu"
  - "CMenu.TrackPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, menu operations"
  - "TrackPopupMenu method"
ms.assetid: 13cc4421-4708-4cef-b45e-9b545e2bdf96
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::TrackPopupMenu
Displays a floating pop-up menu at the specified location and tracks the selection of items on the pop-up menu.  
  
## Syntax  
  
```  
  
      BOOL TrackPopupMenu(  
   UINT nFlags,  
   int x,  
   int y,  
   CWnd* pWnd,  
   LPCRECT lpRect = 0  
);  
```  
  
#### Parameters  
 `nFlags`  
 Specifies screen-position and mouse-position flags. See [TrackPopupMenu](http://msdn.microsoft.com/library/windows/desktop/ms648002) for a list of available flags.  
  
 *x*  
 Specifies the horizontal position in screen coordinates of the pop-up menu. Depending on the value of the `nFlags` parameter, the menu can be left-aligned, right-aligned, or centered relative to this position.  
  
 *y*  
 Specifies the vertical position in screen coordinates of the top of the menu on the screen.  
  
 `pWnd`  
 Identifies the window that owns the pop-up menu. This parameter cannot be **NULL**, even if the **TPM_NONOTIFY** flag is specified. This window receives all **WM_COMMAND** messages from the menu. In Windows versions 3.1 and later, the window does not receive **WM_COMMAND** messages until `TrackPopupMenu` returns. In Windows 3.0, the window receives **WM_COMMAND** messages before `TrackPopupMenu` returns.  
  
 `lpRect`  
 Ignored.  
  
## Return Value  
 This method returns the result of calling [TrackPopupMenu](http://msdn.microsoft.com/library/windows/desktop/ms648002) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 A floating pop-up menu can appear anywhere on the screen.  
  
## Example  
 [!code[NVC_MFCWindowing#34](../vs140/codesnippet/CPP/cmenu--trackpopupmenu_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::CreatePopupMenu](../vs140/cmenu--createpopupmenu.md)   
 [CMenu::GetSubMenu](../vs140/cmenu--getsubmenu.md)   
 [TrackPopupMenu](http://msdn.microsoft.com/library/windows/desktop/ms648002)
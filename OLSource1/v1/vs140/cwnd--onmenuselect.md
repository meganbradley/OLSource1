---
title: "CWnd::OnMenuSelect"
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
  - "OnMenuSelect"
  - "CWnd.OnMenuSelect"
  - "WM_MENUSELECT"
  - "CWnd::OnMenuSelect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_MENUSELECT"
  - "OnMenuSelect method"
ms.assetid: 8fff73f9-8987-409f-808f-6ae23667eeba
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnMenuSelect
If the `CWnd` object is associated with a menu, `OnMenuSelect` is called by the framework when the user selects a menu item.  
  
## Syntax  
  
```  
  
      afx_msg void OnMenuSelect(   
   UINT nItemID,   
   UINT nFlags,   
   HMENU hSysMenu    
);  
```  
  
#### Parameters  
 `nItemID`  
 Identifies the item selected. If the selected item is a menu item, `nItemID` contains the menu-item ID. If the selected item contains a pop-up menu, `nItemID` contains the pop-up menu index, and *hSysMenu* contains the handle of the main (clicked-on) menu.  
  
 `nFlags`  
 Contains a combination of the following menu flags:  
  
-   **MF_BITMAP** Item is a bitmap.  
  
-   **MF_CHECKED** Item is checked.  
  
-   **MF_DISABLED** Item is disabled.  
  
-   **MF_GRAYED** Item is dimmed.  
  
-   **MF_MOUSESELECT** Item was selected with a mouse.  
  
-   `MF_OWNERDRAW` Item is an owner-draw item.  
  
-   **MF_POPUP** Item contains a pop-up menu.  
  
-   **MF_SEPARATOR** Item is a menu-item separator.  
  
-   **MF_SYSMENU** Item is contained in the Control menu.  
  
 `hSysMenu`  
 If `nFlags` contains **MF_SYSMENU**, identifies the menu associated with the message. If `nFlags` contains **MF_POPUP**, identifies the handle of the main menu. If `nFlags` contains neither **MF_SYSMENU** nor **MF_POPUP**, it is unused.  
  
## Remarks  
 If `nFlags` contains 0xFFFF and `hSysMenu` contains 0, Windows has closed the menu because the user pressed the ESC key or clicked outside the menu.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnInitMenu](../vs140/cwnd--oninitmenu.md)
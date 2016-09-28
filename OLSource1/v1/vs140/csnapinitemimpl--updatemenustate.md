---
title: "CSnapInItemImpl::UpdateMenuState"
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
  - "UpdateMenuState"
  - "CSnapInItemImpl.UpdateMenuState"
  - "CSnapInItemImpl::UpdateMenuState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateMenuState method"
ms.assetid: ceceae45-da26-495a-83b4-36fad6a01353
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInItemImpl::UpdateMenuState
Call this function to modify a menu item before it is inserted into the context menu of the snap-in object.  
  
## Syntax  
  
```  
  
      void UpdateMenuState(  
   UINT id,  
   LPTSTR pBuf,  
   UINT *flags   
);  
```  
  
#### Parameters  
 `id`  
 [in] The ID of the menu item to be set.  
  
 `pBuf`  
 [in] A pointer to the string for the menu item to be updated.  
  
 `flags`  
 [in] Specifies the new state flags. This can be a combination of the following flags:  
  
-   **MF_POPUP** Specifies that this is a submenu within the context menu. Menu items, insertion points, and further submenus may be added to this submenu using its **lCommandID** as their **IInsertionPointID**.  
  
-   **MF_BITMAP** and `MF_OWNERDRAW` These flags are not permitted and will result in a return value of `E_INVALIDARG`.  
  
-   **MF_SEPARATOR** Draws a horizontal dividing line. Only **IContextMenuProvider** is allowed to add menu items with **MF_SEPARATOR** set.  
  
-   **MF_CHECKED** Places a check mark next to the menu item.  
  
-   **MF_DISABLED** Disables the menu item so it cannot be selected, but the flag does not gray it.  
  
-   `MF_ENABLED` Enables the menu item so it can be selected, restoring it from its grayed state.  
  
-   **MF_GRAYED** Disables the menu item, graying it so it cannot be selected.  
  
-   **MF_MENUBARBREAK** Functions the same as the **MF_MENUBREAK** flag for a menu bar. For a drop-down menu, submenu, or shortcut menu, the new column is separated from the old column by a vertical line.  
  
-   **MF_MENUBREAK** Places the item on a new line (for a menu bar) or in a new column (for a drop-down menu, submenu, or shortcut menu) without separating columns.  
  
-   **MF_UNCHECKED** Does not place a check mark next to the item (default).  
  
 The following groups of flags cannot be used together:  
  
-   **MF_DISABLED**, `MF_ENABLED`, and **MF_GRAYED**.  
  
-   **MF_MENUBARBREAK** and **MF_MENUBREAK**.  
  
-   **MF_CHECKED** and **MF_UNCHECKED**.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)
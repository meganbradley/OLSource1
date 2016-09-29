---
title: "CMDIFrameWndEx::GetMDITabsContextMenuAllowedItems"
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
  - "CMDIFrameWndEx.GetMDITabsContextMenuAllowedItems"
  - "CMDIFrameWndEx::GetMDITabsContextMenuAllowedItems"
  - "GetMDITabsContextMenuAllowedItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMDITabsContextMenuAllowedItems method"
ms.assetid: e0924999-5432-4c86-baa2-5582e639d07b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::GetMDITabsContextMenuAllowedItems
Returns a combination of flags that determines what operations are valid when the MDI Tabbed Groups feature is enabled.  
  
## Syntax  
  
```  
DWORD GetMDITabsContextMenuAllowedItems();  
```  
  
## Return Value  
 A bitwise-OR combination of the following flags:  
  
-   `BCGP_MDI_CREATE_VERT_GROUP` - can create a vertical tab group.  
  
-   `BCGP_MDI_CREATE_HORZ_GROUP` - can create a horizontal tab group.  
  
-   `BCGP_MDI_CAN_MOVE_PREV` - can move a tab to the previous tab group.  
  
-   `BCGP_MDI_CAN_MOVE_NEXT` - can move a tab to the next tab group.  
  
## Remarks  
 When the MDI Tabbed Groups feature is enabled, you must know what operations are allowed on the tabs of a particular window. This method analyzes the current layout of tabbed windows and returns a combination of flags that can be used to build, for example, a shortcut menu.  
  
 You can create a new vertical tab group when all tabbed windows are aligned vertically, or when there is only one tabbed window.  
  
 You can create a new horizontal tab group when all tabbed windows are aligned horizontally, or when there is only one tabbed window.  
  
 You can move a tab to the previous group only if there is more than one tab in a tabbed window.  
  
 You can move a tab to the next group only if there is more than one tab in a tabbed window.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)
---
title: "CFrameWnd::SetMenuBarState"
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
  - "CFrameWnd.SetMenuBarState"
  - "SetMenuBarState"
  - "CFrameWnd::SetMenuBarState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenuBarState method"
ms.assetid: 8bcaee11-1867-4f70-83cc-44f3c51c40e8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::SetMenuBarState
Sets the display state of the menu in the current MFC application to hidden or displayed.  
  
## Syntax  
  
```  
virtual BOOL SetMenuBarState(   
    DWORD nState  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `nState`|Specifies whether to display or hide the menu. The `nState` parameter can have the following values:<br /><br /> -   AFX_MBS_VISIBLE (0x01) – Displays the menu if it is hidden, but has no effect if it is visible.<br />-   AFX_MBS_HIDDEN (0x02) – Hides the menu if it is visible, but has no effect if it is hidden.|  
  
## Return Value  
 `true` if this method successfully changes the menu state; otherwise, `false`.  
  
## Remarks  
 If a runtime error occurs, this method asserts in Debug mode and raises an exception derived from the [CException](../vs140/cexception-class.md) class.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::GetMenuBarState](../vs140/cframewnd--getmenubarstate.md)
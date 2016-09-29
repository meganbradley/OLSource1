---
title: "CWnd::OnQueryUIState"
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
  - "CWnd.OnQueryUIState"
  - "CWnd::OnQueryUIState"
  - "OnQueryUIState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnQueryUIState method"
ms.assetid: 09c74433-4825-468c-81ca-d44df7fdc0ac
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnQueryUIState
Called to retrieve the user interface (UI) state for a window.  
  
## Syntax  
  
```  
  
afx_msg UINT OnQueryUIState( );  
  
```  
  
## Return Value  
 The return value is **NULL** if the focus indicators and the keyboard accelerators are visible. Otherwise, the return value can be one or more of the following values:  
  
-   **UISF_HIDEFOCUS** Focus indicators are hidden.  
  
-   **UISF_HIDEACCEL** Keyboard accelerators are hidden.  
  
-   **UISF_ACTIVE Windows XP:** A control should be drawn in the style used for active controls.  
  
## Remarks  
 This member function emulates the functionality of the [WM_QUERYUISTATE](http://msdn.microsoft.com/library/windows/desktop/ms646355) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnChangeUIState](../vs140/cwnd--onchangeuistate.md)   
 [CWnd::OnUpdateUIState](../vs140/cwnd--onupdateuistate.md)
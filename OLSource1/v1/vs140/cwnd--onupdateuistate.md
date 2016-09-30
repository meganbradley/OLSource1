---
title: "CWnd::OnUpdateUIState"
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
  - "CWnd::OnUpdateUIState"
  - "OnUpdateUIState"
  - "CWnd.OnUpdateUIState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdateUIState method"
ms.assetid: ddefbefa-d00d-4b9f-b9e3-b4ccec023bd0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnUpdateUIState
Called to to change the user interface (UI) state for the specified window and all its child windows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the action to be performed. Can be one of the following values:  
  
-   **UIS_CLEAR** The UI state element (specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) should be hidden.  
  
-   **UIS_INITIALIZE** The UI state element (specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) should be changed based on the last input event. For more information, see the **Remarks** section of [WM_UPDATEISTATE](http://msdn.microsoft.com/library/windows/desktop/ms646361).  
  
-   **UIS_SET** The UI state element (specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) should be visible.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies which UI state elements are affected or the style of the control. Can be one of the following values:  
  
-   **UISF_HIDEACCEL** Keyboard accelerators.  
  
-   **UISF_HIDEFOCUS** Focus indicators.  
  
-   **UISF_ACTIVE Windows XP:** A control should be drawn in the style used for active controls.  
  
## Remarks  
 This member function emulates the functionality of the [WM_UPDATEUISTATE](http://msdn.microsoft.com/library/windows/desktop/ms646361) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnChangeUIState](../vs140/cwnd--onchangeuistate.md)   
 [CWnd::OnQueryUIState](../vs140/cwnd--onqueryuistate.md)
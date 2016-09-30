---
title: "CMDIFrameWnd::MDIActivate"
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
  - "MDIActivate"
  - "CMDIFrameWnd.MDIActivate"
  - "CMDIFrameWnd::MDIActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMDIFrameWnd class, operations"
  - "MDIActivate method"
ms.assetid: 5dc97a6b-5880-4387-9b58-ad7914501cb0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWnd::MDIActivate
Activates a different MDI child window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pWndActivate*  
 Points to the MDI child window to be activated.  
  
## Remarks  
 This member function sends the [WM_MDIACTIVATE](../vs140/cwnd--onmdiactivate.md) message to both the child window being activated and the child window being deactivated.  
  
 This is the same message that is sent if the user changes the focus to an MDI child window by using the mouse or keyboard.  
  
> [!NOTE]
>  An MDI child window is activated independently of the MDI frame window. When the frame becomes active, the child window that was last activated is sent a [WM_NCACTIVATE](../vs140/cwnd--onncactivate.md) message to draw an active window frame and caption bar, but it does not receive another <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> message.  
  
## Example  
 See the example for [CMDIFrameWnd::GetWindowMenuPopup](../vs140/cmdiframewnd--getwindowmenupopup.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIFrameWnd Class](../vs140/cmdiframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::MDIGetActive](../vs140/cmdiframewnd--mdigetactive.md)   
 [CMDIFrameWnd::MDINext](../vs140/cmdiframewnd--mdinext.md)   
 [CWnd::OnActivate](../vs140/cwnd--onactivate.md)   
 [WM_NCACTIVATE](http://msdn.microsoft.com/library/windows/desktop/ms632633)
---
title: "CWnd::GetWindowPlacement"
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
  - "CWnd::GetWindowPlacement"
  - "CWnd.GetWindowPlacement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindowPlacement method"
ms.assetid: bffdfc1f-daea-46ca-b484-dc4fbd8caf07
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetWindowPlacement
Retrieves the show state and the normal (restored), minimized, and maximized positions of a window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure that receives the show state and position information.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The **flags** member of the [WINDOWPLACEMENT](../vs140/windowplacement-structure.md) structure retrieved by this function is always 0. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is maximized, the **showCmd** member of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **SW_SHOWMAXIMIZED**. If the window is minimized, it is **SW_SHOWMINIMIZED.** It is **SW_SHOWNORMAL** otherwise.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetWindowPlacement](../vs140/cwnd--setwindowplacement.md)   
 [GetWindowPlacement](http://msdn.microsoft.com/library/windows/desktop/ms633518)
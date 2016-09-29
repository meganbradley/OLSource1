---
title: "CWnd::SetWindowPlacement"
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
  - "CWnd.SetWindowPlacement"
  - "CWnd::SetWindowPlacement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowPlacement method"
ms.assetid: 4a37d32f-9d57-4f27-82bc-0f5f4c8b8a09
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetWindowPlacement
Sets the show state and the normal (restored), minimized, and maximized positions for a window.  
  
## Syntax  
  
```  
  
      BOOL SetWindowPlacement(  
   const WINDOWPLACEMENT*lpwndpl   
);   
```  
  
#### Parameters  
 `lpwndpl`  
 Points to a [WINDOWPLACEMENT](../vs140/windowplacement-structure.md) structure that specifies the new show state and positions.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetWindowPlacement](../vs140/cwnd--getwindowplacement.md)   
 [SetWindowPlacement](http://msdn.microsoft.com/library/windows/desktop/ms633544)
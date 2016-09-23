---
title: "CMDIFrameWnd::MDIRestore"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - MDIRestore
  - CMDIFrameWnd::MDIRestore
  - CMDIFrameWnd.MDIRestore
dev_langs: 
  - C++
helpviewer_keywords: 
  - MDIRestore method
  - CMDIFrameWnd class, operations
ms.assetid: 904b8200-c9d8-4628-9964-e46956adb2d3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWnd::MDIRestore
Restores an MDI child window from maximized or minimized size.  
  
## Syntax  
  
```  
  
      void MDIRestore(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 Points to the window to restore.  
  
## Example  
 See the example for [CMDIChildWnd::MDIRestore](../vs140/cmdichildwnd--mdirestore.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIFrameWnd Class](../vs140/cmdiframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::MDIMaximize](../vs140/cmdiframewnd--mdimaximize.md)   
 [WM_MDIRESTORE](http://msdn.microsoft.com/library/windows/desktop/ms644920)
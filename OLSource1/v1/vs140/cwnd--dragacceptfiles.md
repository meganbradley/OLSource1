---
title: "CWnd::DragAcceptFiles"
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
  - "CWnd.DragAcceptFiles"
  - "CWnd::DragAcceptFiles"
  - "DragAcceptFiles"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DragAcceptFiles method"
ms.assetid: d65453da-7271-49c1-b57b-cd326544ab33
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::DragAcceptFiles
Call this member function from within a window, using a `CWnd` pointer, in your application's [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md) function to indicate that the window accepts dropped files from the Windows File Manager or File Explorer.  
  
## Syntax  
  
```  
  
      void DragAcceptFiles(  
   BOOL bAccept = TRUE   
);  
```  
  
#### Parameters  
 *BAccept*  
 Flag that indicates whether dragged files are accepted.  
  
## Remarks  
 Only the window that calls `DragAcceptFiles` with the `bAccept` parameter set to **TRUE** has identified itself as able to process the Windows message `WM_DROPFILES`. For example, in an MDI application, if the `CMDIFrameWnd` window pointer is used in the `DragAcceptFiles` function call, only the `CMDIFrameWnd` window gets the `WM_DROPFILES` message. This message is not sent to all open `CMDIChildWnd` windows. For a `CMDIChildWnd` window to receive this message, you must call `DragAcceptFiles` with the `CMDIChildWnd` window pointer.  
  
 To discontinue receiving dragged files, call the member function with `bAccept` set to **FALSE**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DragAcceptFiles](http://msdn.microsoft.com/library/windows/desktop/bb776406)   
 [WM_DROPFILES](http://msdn.microsoft.com/library/windows/desktop/bb774303)
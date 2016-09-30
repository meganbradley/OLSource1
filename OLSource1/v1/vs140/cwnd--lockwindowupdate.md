---
title: "CWnd::LockWindowUpdate"
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
  - "LockWindowUpdate"
  - "CWnd.LockWindowUpdate"
  - "CWnd::LockWindowUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LockWindowUpdate method"
ms.assetid: 3aab9646-61b3-4702-902d-03a49db7cad3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::LockWindowUpdate
Disables drawing in the given window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the function is successful. It is 0 if a failure occurs or if the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function has been used to lock another window.  
  
## Remarks  
 A locked window cannot be moved. Only one window can be locked at a time. To unlock a window locked with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, call [UnlockWindowUpdate](../vs140/cwnd--unlockwindowupdate.md).  
  
 If an application with a locked window (or any locked child windows) calls the [GetDC,](http://msdn.microsoft.com/library/windows/desktop/dd144871) [GetDCEx,](http://msdn.microsoft.com/library/windows/desktop/dd144873) or [BeginPaint](http://msdn.microsoft.com/library/windows/desktop/dd183362) Windows function, the called function returns a device context whose visible region is empty. This will occur until the application unlocks the window by calling the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function.  
  
 While window updates are locked, the system keeps track of the bounding rectangle of any drawing operations to device contexts associated with a locked window. When drawing is reenabled, this bounding rectangle is invalidated in the locked window and its child windows to force an eventual [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message to update the screen. If no drawing has occurred while the window updates were locked, no area is invalidated.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function does not make the given window invisible and does not clear the [WS_VISIBLE](../vs140/window-styles.md) style bit.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDCEx](../vs140/cwnd--getdcex.md)   
 [LockWindowUpdate](http://msdn.microsoft.com/library/windows/desktop/dd145034)
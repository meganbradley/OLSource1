---
title: "CWnd::ModifyStyleEx"
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
  - CWnd.ModifyStyleEx
  - CWnd::ModifyStyleEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - ModifyStyleEx method
ms.assetid: 24e7490e-80b0-45ee-b025-7335750f8085
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::ModifyStyleEx
Call this member function to modify a window's extended style.  
  
## Syntax  
  
```  
  
      BOOL ModifyStyleEx(  
   DWORD dwRemove,  
   DWORD dwAdd,  
   UINT nFlags = 0   
);  
```  
  
#### Parameters  
 `dwRemove`  
 Specifies extended styles to be removed during style modification.  
  
 `dwAdd`  
 Specifies extended styles to be added during style modification.  
  
 `nFlags`  
 Flags to be passed to [SetWindowPos](../vs140/cwnd--setwindowpos.md), or zero if `SetWindowPos` should not be called. The default is zero. See the Remarks section for a list of preset flags.  
  
## Return Value  
 Nonzero if style was successfully modified; otherwise, 0.  
  
## Remarks  
 Styles to be added or removed can be combined by using the bitwise OR (&#124;) operator. See the topics [Extended Window Styles](../vs140/extended-window-styles.md) in this book and [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for information about the available extended styles  
  
 If `nFlags` is nonzero, `ModifyStyleEx` calls the Windows API function [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) and redraws the window by combining `nFlags` with the following four preset flags:  
  
-   `SWP_NOSIZE` Retains the current size.  
  
-   `SWP_NOMOVE` Retains the current position.  
  
-   `SWP_NOZORDER` Retains the current Z order.  
  
-   `SWP_NOACTIVATE` Does not activate the window.  
  
 To modify windows using regular window styles, see [ModifyStyle](../vs140/cwnd--modifystyle.md).  
  
## Example  
 [!code[NVC_MFCWindowing#106](../vs140/codesnippet/CPP/cwnd--modifystyleex_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ModifyStyle](../vs140/cwnd--modifystyle.md)   
 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680)
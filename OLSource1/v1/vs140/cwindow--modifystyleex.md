---
title: "CWindow::ModifyStyleEx"
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
  - ATL::CWindow::ModifyStyleEx
  - ATL.CWindow.ModifyStyleEx
  - CWindow.ModifyStyleEx
  - CWindow::ModifyStyleEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - ModifyStyleEx method
  - SWP_NOMOVE
  - SWP_NOZORDER
  - SWP_NOSIZE
  - SWP_NOACTIVATE
ms.assetid: 2f1b61d9-cb9c-4fc7-8a36-4c086ffbb6c2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::ModifyStyleEx
Modifies the extended window styles of the `CWindow` object.  
  
## Syntax  
  
```  
  
      BOOL ModifyStyleEx(  
   DWORD dwRemove,  
   DWORD dwAdd,  
   UINT nFlags = 0   
) throw();  
```  
  
#### Parameters  
 `dwRemove`  
 [in] Specifies the extended styles to be removed during style modification.  
  
 `dwAdd`  
 [in] Specifies the extended styles to be added during style modification.  
  
 `nFlags`  
 [in] Window-positioning flags. For a list of possible values, see the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 **TRUE** if the extended window styles are modified; otherwise, **FALSE**.  
  
## Remarks  
 Styles to be added or removed can be combined by using the bitwise OR ( &#124; ) operator. See the [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for information about the available extended styles.  
  
 If `nFlags` is nonzero, `ModifyStyleEx` calls the Win32 function `SetWindowPos`, and redraws the window by combining `nFlags` with the following four flags:  
  
-   `SWP_NOSIZE` Retains the current size.  
  
-   `SWP_NOMOVE` Retains the current position.  
  
-   `SWP_NOZORDER` Retains the current Z order.  
  
-   `SWP_NOACTIVATE` Does not activate the window.  
  
 To modify windows using regular window styles, call [ModifyStyle](../vs140/cwindow--modifystyle.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#26](../vs140/codesnippet/CPP/cwindow--modifystyleex_1.cpp)]
  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetExStyle](../vs140/cwindow--getexstyle.md)
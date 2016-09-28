---
title: "CWindow::ModifyStyle"
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
  - "ATL::CWindow::ModifyStyle"
  - "SWP_NOMOVE"
  - "ATL.CWindow.ModifyStyle"
  - "SWP_NOSIZE"
  - "CWindow.ModifyStyle"
  - "CWindow::ModifyStyle"
  - "SWP_NOZORDER"
  - "SWP_NOACTIVATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SWP_NOMOVE"
  - "SWP_NOZORDER"
  - "SWP_NOSIZE"
  - "SWP_NOACTIVATE"
  - "ModifyStyle method"
ms.assetid: 830f68de-07f4-4ce4-9b1b-6e8011ab3f43
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::ModifyStyle
Modifies the window styles of the `CWindow` object.  
  
## Syntax  
  
```  
  
      BOOL ModifyStyle(  
   DWORD dwRemove,  
   DWORD dwAdd,  
   UINT nFlags = 0   
) throw();  
```  
  
#### Parameters  
 `dwRemove`  
 [in] Specifies the window styles to be removed during style modification.  
  
 `dwAdd`  
 [in] Specifies the window styles to be added during style modification.  
  
 `nFlags`  
 [in] Window-positioning flags. For a list of possible values, see the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 **TRUE** if the window styles are modified; otherwise, **FALSE**.  
  
## Remarks  
 Styles to be added or removed can be combined by using the bitwise OR ( &#124; ) operator. See the [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for information about the available window styles.  
  
 If `nFlags` is nonzero, `ModifyStyle` calls the Win32 function `SetWindowPos`, and redraws the window by combining `nFlags` with the following four flags:  
  
-   `SWP_NOSIZE` Retains the current size.  
  
-   `SWP_NOMOVE` Retains the current position.  
  
-   `SWP_NOZORDER` Retains the current Z order.  
  
-   `SWP_NOACTIVATE` Does not activate the window.  
  
 To modify a window's extended styles, call [ModifyStyleEx](../vs140/cwindow--modifystyleex.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#25](../vs140/codesnippet/CPP/cwindow--modifystyle_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetStyle](../vs140/cwindow--getstyle.md)
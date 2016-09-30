---
title: "CWindow::ModifyStyleEx"
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
  - "ATL::CWindow::ModifyStyleEx"
  - "ATL.CWindow.ModifyStyleEx"
  - "CWindow.ModifyStyleEx"
  - "CWindow::ModifyStyleEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ModifyStyleEx method"
  - "SWP_NOMOVE"
  - "SWP_NOZORDER"
  - "SWP_NOSIZE"
  - "SWP_NOACTIVATE"
ms.assetid: 2f1b61d9-cb9c-4fc7-8a36-4c086ffbb6c2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::ModifyStyleEx
Modifies the extended window styles of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the extended styles to be removed during style modification.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the extended styles to be added during style modification.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Window-positioning flags. For a list of possible values, see the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 **TRUE** if the extended window styles are modified; otherwise, **FALSE**.  
  
## Remarks  
 Styles to be added or removed can be combined by using the bitwise OR ( &#124; ) operator. See the [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for information about the available extended styles.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is nonzero, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> calls the Win32 function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and redraws the window by combining <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with the following four flags:  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Retains the current size.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Retains the current position.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Retains the current Z order.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> Does not activate the window.  
  
 To modify windows using regular window styles, call [ModifyStyle](../vs140/cwindow--modifystyle.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#26](../vs140/codesnippet/CPP/cwindow--modifystyleex_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetExStyle](../vs140/cwindow--getexstyle.md)
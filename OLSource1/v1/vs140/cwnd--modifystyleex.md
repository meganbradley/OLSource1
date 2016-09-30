---
title: "CWnd::ModifyStyleEx"
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
  - "CWnd.ModifyStyleEx"
  - "CWnd::ModifyStyleEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ModifyStyleEx method"
ms.assetid: 24e7490e-80b0-45ee-b025-7335750f8085
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ModifyStyleEx
Call this member function to modify a window's extended style.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies extended styles to be removed during style modification.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies extended styles to be added during style modification.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Flags to be passed to [SetWindowPos](../vs140/cwnd--setwindowpos.md), or zero if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> should not be called. The default is zero. See the Remarks section for a list of preset flags.  
  
## Return Value  
 Nonzero if style was successfully modified; otherwise, 0.  
  
## Remarks  
 Styles to be added or removed can be combined by using the bitwise OR (&#124;) operator. See the topics [Extended Window Styles](../vs140/extended-window-styles.md) in this book and [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for information about the available extended styles  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is nonzero, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> calls the Windows API function [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) and redraws the window by combining <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with the following four preset flags:  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Retains the current size.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Retains the current position.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Retains the current Z order.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Does not activate the window.  
  
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
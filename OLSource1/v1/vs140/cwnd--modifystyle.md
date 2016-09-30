---
title: "CWnd::ModifyStyle"
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
  - "CWnd::ModifyStyle"
  - "CWnd.ModifyStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ModifyStyle method"
ms.assetid: 5b6c28bd-ec51-45c4-b7fe-a8ae522f9ba8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ModifyStyle
Call this member function to modify a window's style.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies window styles to be removed during style modification.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies window styles to be added during style modification.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Flags to be passed to [SetWindowPos](../vs140/cwnd--setwindowpos.md), or zero if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> should not be called. The default is zero. See the Remarks section for a list of preset flags.  
  
## Return Value  
 Nonzero if style was successfully modified; otherwise, 0.  
  
## Remarks  
 Styles to be added or removed can be combined by using the bitwise OR (&#124;) operator. See the topics [Window Styles](http://msdn.microsoft.com/library/windows/desktop/ms632600) and [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for information about the available window styles.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is nonzero, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> calls the Windows API function [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) and redraws the window by combining <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with the following four preset flags:  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Retains the current size.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Retains the current position.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Retains the current Z order.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Does not activate the window.  
  
 To modify a window's extended styles, see [ModifyStyleEx](../vs140/cwnd--modifystyleex.md).  
  
> [!NOTE]
>  For some styles in certain controls (the **ES_READONLY** style in the edit control, for example), **ModifyStyle** may not properly change the style because the control may need to perform special internal processing. In these cases, a corresponding message to change the style will be available (**EM_SETREADONLY** in the example mentioned).  
  
## Example  
 [!code[NVC_MFCWindowing#105](../vs140/codesnippet/CPP/cwnd--modifystyle_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md)   
 [CWnd::ModifyStyleEx](../vs140/cwnd--modifystyleex.md)   
 [Window Styles](http://msdn.microsoft.com/library/windows/desktop/ms632600)   
 [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545)
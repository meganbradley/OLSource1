---
title: "CWnd::CreateEx"
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
  - "CWnd::CreateEx"
  - "CWnd.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
  - "CWnd class, protected initialization"
ms.assetid: 9c6b7bdd-6ae5-4150-843f-493380a0b266
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CreateEx
Creates the specified window and attaches it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Bitwise combination (OR) of [extended window styles](../vs140/extended-window-styles.md); otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for the default extended window style.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the name of a registered system window class; or the name of a predefined system window class.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the window display name; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for no window display name.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Bitwise combination (OR) of [window styles](../vs140/window-styles.md); otherwise <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for the default window style.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The initial horizontal distance of the window from the left side of the screen or the parent window.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The initial vertical distance of the window from the top of the screen or the parent window.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The width, in pixels, of the window.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The height, in pixels, of the window.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 For a child window, the handle to the parent window; otherwise, the handle of the owner window if the window has an owner.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 For a child window, the window ID; otherwise, the ID of a menu for the window.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Pointer to user data that is passed to the [CWnd::OnCreate](../vs140/cwnd--oncreate.md) method in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> field.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The size and location of the window relative to the screen or the parent window.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 For a child window, pointer to the parent window; otherwise, pointer to the owner window if the window has an owner.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 For a child window, the window ID; otherwise, the ID of a menu for the window.  
  
## Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Remarks  
  
> [!WARNING]
>  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> now assigns the hMenu member of its <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> pointer if the menu is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and the style contains <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For proper functionality, ensure that your dialog control has an ID that is not <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
>   
>  This change fixes a crash in managed/native interop scenarios. A <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> alerts the developer of the problem.  
  
 The default extended window style is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. The default window style is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 Use the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) function to register window classes. User defined window classes are available in the module where they are registered.  
  
 Dimensions for child windows are relative to the top-left corner of the client area of the parent window. Dimensions for top-level windows are relative to the top-left corner of the screen.  
  
 The [CWnd::OnCreate](../vs140/cwnd--oncreate.md) method is called before the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method returns, and before the window becomes visible.  
  
## Example  
 [!code[NVC_MFCWindowing#82](../vs140/codesnippet/CPP/cwnd--createex_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Create](../vs140/cwnd--create.md)   
 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680)
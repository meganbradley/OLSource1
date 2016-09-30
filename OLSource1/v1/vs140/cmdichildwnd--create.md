---
title: "CMDIChildWnd::Create"
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
  - "CMDIChildWnd.Create"
  - "CMDIChildWnd::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMDIChildWnd class, initialization"
  - "Create method [C++]"
ms.assetid: a787e216-a447-4ae7-9508-23cccf52afcc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWnd::Create
Call this member function to create a Windows MDI child window and attach it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that names the Windows class (a [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576) structure). The class name can be any name registered with the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) global function. Should be **NULL** for a standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that represents the window name. Used as text for the title bar.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the window [style](../vs140/window-styles.md) attributes. The **WS_CHILD** style is required.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Contains the size and position of the window. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value allows Windows to specify the size and position of the new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the window's parent. If **NULL**, the main application window is used.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies a [CCreateContext](../vs140/ccreatecontext-structure.md) structure. This parameter can be **NULL**.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The currently active MDI child frame window can determine the caption of the parent frame window. This feature is disabled by turning off the **FWS_ADDTOTITLE** style bit of the child frame window.  
  
 The framework calls this member function in response to a user command to create a child window, and the framework uses the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter to properly connect the child window to the application. When you call **Create**, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> can be **NULL**.  
  
## Example  
 Example 1:  
  
 [!code[NVC_MFCWindowing#7](../vs140/codesnippet/CPP/cmdichildwnd--create_1.cpp)]  
  
## Example  
 Example 2:  
  
 [!code[NVC_MFCWindowing#8](../vs140/codesnippet/CPP/cmdichildwnd--create_2.cpp)]  
  
 [!code[NVC_MFCWindowing#9](../vs140/codesnippet/CPP/cmdichildwnd--create_3.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIChildWnd Class](../vs140/cmdichildwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIChildWnd::CMDIChildWnd](../vs140/cmdichildwnd--cmdichildwnd.md)   
 [CWnd::PreCreateWindow](../vs140/cwnd--precreatewindow.md)
---
title: "CWnd::OnInitMenu"
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
  - "WM_INITMENU"
  - "CWnd.OnInitMenu"
  - "CWnd::OnInitMenu"
  - "OnInitMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnInitMenu method"
  - "CWnd class, initialization message handlers"
  - "WM_INITMENU"
ms.assetid: 242e43eb-6b51-414f-be5a-9a4ffbd070dd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnInitMenu
The framework calls this member function when a menu is about to become active.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the menu to be initialized. May be temporary and should not be stored for later use.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called when the user clicks an item on the menu bar or presses a menu key. Override this member function to modify the menu before it is displayed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is only called once, when a menu is first accessed (for example, when a user clicks an item on the menu bar). This method does not provide information about menu items. As the user moves to items within the menu (for example, by moving the mouse across several menu items) the function is not called again. Once the user exits from the menu (for example, by clicking on the application client area) and later clicks an item on the menu bar, the function will be called again.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnInitMenuPopup](../vs140/cwnd--oninitmenupopup.md)   
 [WM_INITMENU](http://msdn.microsoft.com/library/windows/desktop/ms646344)
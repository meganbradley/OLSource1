---
title: "CMFCDesktopAlertWnd::Create"
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
  - "CMFCDesktopAlertWnd::Create"
  - "CMFCDesktopAlertWnd.Create"
  - "Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: fe4fea0f-6e77-46bd-9401-c8df587e329a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDesktopAlertWnd::Create
Creates and initializes the desktop alert window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the owner of the alert window. That owner will then receive all notifications for the desktop alert window. This value cannot be <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the resource ID of the alert window.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the menu that displays when the user clicks the menu button. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the menu button is not displayed.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the initial position where the alert window is displayed, using screen coordinates. If this parameter is (-1, -1), the alert window is displayed in the lower-right corner of the screen.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Runtime class information for a custom dialog box class that covers the alert window's client area.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies parameters that are used to create an alert window.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the alert window was created successfully; otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to create an alert window. The client area of the alert window contains a child dialog box that hosts all controls that are displayed to the user.  
  
 The first method overload creates an alert window that contains a child dialog box that is loaded from the application's resources. The first method overload can also specify runtime class information for a custom dialog box class.  
  
 The second method overload creates an alert window that contains default controls. You can specify which controls to display by modifying the [CMFCDesktopAlertWndInfo Class](../vs140/cmfcdesktopalertwndinfo-class.md).  
  
## Requirements  
 **Header:** afxDesktopAlertWnd.h  
  
## See Also  
 [CMFCDesktopAlertWnd Class](../vs140/cmfcdesktopalertwnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)
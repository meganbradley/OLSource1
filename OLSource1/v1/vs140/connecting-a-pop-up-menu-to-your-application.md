---
title: "Connecting a Pop-up Menu to Your Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop-up menus, connecting to applications"
  - "context menus, connecting to applications"
  - "menus, pop-up"
  - "shortcut menus, connecting to applications"
ms.assetid: 295cbf0e-6416-478e-bc3d-472fb98e0e52
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Connecting a Pop-up Menu to Your Application
### To connect a pop-up menu to your application  
  
1.  Add a message handler for [WM_CONTEXTMENU](_win32_WM_CONTEXTMENU) (for example). For more information, see [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md).  
  
2.  Add the following code to the message handler:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  The [CPoint](../vs140/cpoint-class.md) **passed by the message handler is in screen coordinates.**  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 MFC  
  
## See Also  
 [Creating Pop-up Menus](../vs140/creating-pop-up-menus.md)   
 [Menu Editor](../vs140/menu-editor.md)   
 [Menus](_win32_Menus)
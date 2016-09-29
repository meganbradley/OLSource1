---
title: "Defining Member Variables for Dialog Controls"
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
  - "C++"
helpviewer_keywords: 
  - "member variables, defining for controls"
  - "variables, dialog box control member variables"
  - "controls [C++], member variables"
  - "Dialog editor, defining member variables for controls"
ms.assetid: 84347c63-c33c-4b04-91f5-6d008c45ba58
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Defining Member Variables for Dialog Controls
To define a member variable for any dialog box control except buttons, you can use the following method.  
  
> [!NOTE]
>  This article applies only to dialog controls within an MFC project. ATL projects should use the **New Windows Messages and Event Handlers** dialog box.  
  
### To define a member variable for a (non-button) dialog box control  
  
1.  In the [Dialog editor](../vs140/dialog-editor.md), select a control.  
  
2.  While pressing the **CTRL** key, double-click the dialog box control.  
  
     The [Add Member Variable wizard](../vs140/add-member-variable-wizard.md) appears.  
  
3.  Type the appropriate information in the **Add Member Variable** wizard. For more information, see [Dialog Data Exchange](../vs140/dialog-data-exchange.md).  
  
4.  Click **OK** to return to the Dialog editor.  
  
    > [!TIP]
    >  To jump from any dialog box control to its existing handler, double-click the control.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 You can also use the **Member Variables** tab in **MFC Class Wizard** to add new member variables for a specified class, and view those that have already been defined.  
  
 Requirements  
  
 MFC  
  
## See Also  
 [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md)   
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [MFC Class Wizard](../vs140/mfc-class-wizard.md)   
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Adding a Member Function](../vs140/adding-a-member-function--visual-c---.md)   
 [Adding a Member Variable](../vs140/adding-a-member-variable---visual-c---.md)   
 [Overriding a Virtual Function](../vs140/overriding-a-virtual-function--visual-c---.md)   
 [MFC Message Handler](../vs140/adding-an-mfc-message-handler.md)
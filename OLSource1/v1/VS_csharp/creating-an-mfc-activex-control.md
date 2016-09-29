---
title: "Creating an MFC ActiveX Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.appwiz.activex.project"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC ActiveX controls [C++], creating"
  - "ActiveX controls [C++], creating"
ms.assetid: 8bd5a93c-d04d-414e-bb28-163fdc1c0dd5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating an MFC ActiveX Control
ActiveX control programs are modular programs designed to give a specific type of functionality to a parent application. For example, you can create a control such as a button for use in a dialog, or toolbar for use in a Web page.  
  
 The easiest way to create an MFC ActiveX control is to use the [MFC ActiveX Control Wizard](../VS_csharp/mfc-activex-control-wizard.md).  
  
### To create an MFC ActiveX Control using the MFC ActiveX Control Wizard  
  
1.  Follow the instructions in the help topic [Creating a Project with a Visual C++ Application Wizard](../VS_csharp/creating-desktop-projects-by-using-application-wizards.md).  
  
2.  In the **New Project** dialog box, select the **MFC ActiveX Control** icon in the Templates pane to open the MFC ActiveX Control Wizard.  
  
3.  Define your [application settings](../VS_csharp/application-settings--mfc-activex-control-wizard.md), [control names](../VS_csharp/control-names--mfc-activex-control-wizard.md), and [control settings](../VS_csharp/control-settings--mfc-activex-control-wizard.md) using the MFC ActiveX Control Wizard.  
  
    > [!NOTE]
    >  Skip this step to keep the wizard default settings.  
  
4.  Click **Finish** to close the wizard and open your new project in the development environment.  
  
 After you have created your project, you can view the files created in **Solution Explorer**. For more information about the files the wizard creates for your project, see the project-generated file ReadMe.txt. For more information about the file types, see [File Types Created for Visual C++ Projects](../VS_csharp/file-types-created-for-visual-c---projects.md).  
  
 After you have created your project, you can use the code wizards to add [functions](../VS_csharp/add-member-function-wizard.md), [variables](../VS_csharp/add-member-variable-wizard.md), [events](../VS_csharp/add-event-wizard.md), [properties](../VS_csharp/names--add-property-wizard.md), and [methods](../VS_csharp/add-method-wizard.md). For more information about customizing your ActiveX control, see [MFC ActiveX Controls](../VS_csharp/mfc-activex-controls.md).  
  
## See Also  
 [Adding Functionality with Code Wizards](../VS_csharp/adding-functionality-with-code-wizards--c---.md)   
 [Property Pages](../VS_csharp/property-pages--visual-c---.md)   
 [Deploying Applications](assetId:///4ff8881d-0daf-47e7-bfe7-774c625031b4)
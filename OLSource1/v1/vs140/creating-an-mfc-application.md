---
title: "Creating an MFC Application"
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
  - "applications [MFC]"
  - "MFC [C++], creating applications"
  - "MFC applications"
ms.assetid: b8b8aa08-9c49-404c-8078-b42079ac18f0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating an MFC Application
An MFC application is an executable application for Windows that is based on the Microsoft Foundation Class (MFC) Library. The easiest way to create an MFC application is to use the MFC Application Wizard.  
  
> [!IMPORTANT]
>  MFC projects are not supported in Visual Studio Express editions.  
  
 MFC executables generally fall into five types: standard Windows applications, dialog boxes, forms-based applications, Explorer-style applications, and Web browser–style applications. For more information, see:  
  
-   [Using the Classes to Write Windows Applications](../vs140/using-the-classes-to-write-applications-for-windows.md)  
  
-   [Creating and Displaying Dialog Boxes](../vs140/creating-and-displaying-dialog-boxes.md)  
  
-   [Creating a Forms-Based MFC Application](../vs140/creating-a-forms-based-mfc-application.md)  
  
-   [Creating a File Explorer-Style MFC Application](../vs140/creating-a-file-explorer-style-mfc-application.md)  
  
-   [Creating a Web Browser-Style MFC Application](../vs140/creating-a-web-browser-style-mfc-application.md)  
  
 The MFC Application Wizard generates the appropriate classes and files for any of these types of applications, depending on the options you select in the wizard.  
  
### To create an MFC application using the MFC Application Wizard  
  
1.  Follow the instructions in the help topic [Creating a Project with a Visual C++ Application Wizard](../vs140/creating-desktop-projects-by-using-application-wizards.md).  
  
2.  In the **New Project** dialog box, select **MFC Application** in the Templates pane to open the wizard.  
  
3.  Define your application settings using the [MFC Application Wizard](../vs140/mfc-application-wizard.md).  
  
    > [!NOTE]
    >  Skip this step to keep the wizard default settings.  
  
4.  Click **Finish** to close the wizard and open your new project in the development environment.  
  
 Once your project is created, you can view the files created in **Solution Explorer**. For more information about the files the wizard creates for your project, see the project-generated file ReadMe.txt. For more information about the file types, see [File Types Created for Visual C++ Projects](../vs140/file-types-created-for-visual-c---projects.md).  
  
## See Also  
 [Debugging Preparation: Visual C++ Windows Applications](assetId:///a8bc54de-41a3-464d-9a12-db9bdcbc1ad5)   
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Property Pages](../vs140/property-pages--visual-c---.md)   
 [Deploying Applications](assetId:///4ff8881d-0daf-47e7-bfe7-774c625031b4)
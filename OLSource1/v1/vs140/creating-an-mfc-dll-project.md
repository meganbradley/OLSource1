---
title: "Creating an MFC DLL Project"
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
  - "vc.appwiz.mfcdll.project"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC DLLs [C++], creating projects"
  - "DLLs [C++], MFC"
  - "projects [C++], creating"
  - "DLLs [C++], creating"
ms.assetid: 05540b93-4781-4a90-aadf-55158313f5b2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating an MFC DLL Project
An MFC DLL is a binary file that acts as a shared library of functions that can be used simultaneously by multiple applications. The easiest way to create an MFC DLL project is to use the MFC DLL Wizard.  
  
> [!NOTE]
>  The appearance of features in the IDE can depend on your active settings or edition, and might differ from those described in Help. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To create an MFC DLL Project using the MFC DLL Wizard  
  
1.  Follow the instructions in the help topic [Creating a Project with a Visual C++ Application Wizard](../vs140/creating-desktop-projects-by-using-application-wizards.md).  
  
 **Note** In the **New Project** dialog box, select the `MFC DLL` icon in the Templates pane to open the MFC DLL Wizard.  
  
1.  Define your application settings using the [application settings](../vs140/application-settings--mfc-dll-wizard.md) page of the [MFC DLL Wizard](../vs140/mfc-dll-wizard.md).  
  
    > [!NOTE]
    >  Skip this step to keep the wizard default settings.  
  
2.  Click **Finish** to close the wizard and open your new project in **Solution Explorer**.  
  
 Once your project is created, you can view the files created in the Solution Explorer. For more information about the files the wizard creates for your project, see the project-generated file ReadMe.txt. For more information about the file types, see [File Types Created for Visual C++ Projects](../vs140/file-types-created-for-visual-c---projects.md).  
  
## See Also  
 [Debugging Preparation: Visual C++ Project Types](../vs140/debugging-preparation--visual-c---project-types.md)   
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Property Pages](../vs140/property-pages--visual-c---.md)   
 [Deploying Applications](assetId:///4ff8881d-0daf-47e7-bfe7-774c625031b4)
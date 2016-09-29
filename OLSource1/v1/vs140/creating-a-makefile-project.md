---
title: "Creating a Makefile Project"
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
  - "vc.appwiz.makefile.project"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Makefile projects, creating"
  - "project files [C++], Makefile projects"
ms.assetid: dd077af3-97a8-48fb-baaa-cf7e07ddef61
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating a Makefile Project
If you have a project that you build from the command line with a makefile, then the Visual Studio development environment will not recognize your project. To open and build your project using [!INCLUDE[vsUltShort](../vs140/includes/vsultshort_md.md)], [!INCLUDE[vsPro](../vs140/includes/vspro_md.md)], or Visual Studio Express for Windows Desktop, first create an empty project by selecting the MakeFile project template. You can then use this project to build your project from the Visual Studio development environment.  
  
 The project displays no files in Solution Explorer. The project specifies the build settings, which are reflected in the project's property page.  
  
 The output file that you specify in the project has no effect on the name that the build script generates; it declares only an intention.  
  
### To create a Makefile project  
  
1.  Follow the instructions in the help topic [Creating a Project with a Visual C++ Application Wizard](../vs140/creating-desktop-projects-by-using-application-wizards.md).  
  
2.  In the **New Project** dialog box, select **Makefile Project** in the Templates pane to open the wizard.  
  
3.  In the [Application Settings](../vs140/application-settings--makefile-project-wizard.md) page, provide the command, output, clean, and rebuild information.  
  
4.  Click **Finish** to close the wizard and open the newly created project in **Solution Explorer**.  
  
 You can view and edit the project's properties in its property page. See [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md) for information about displaying the property page.  
  
## See Also  
 [Makefile Project Wizard](../vs140/makefile-project-wizard.md)   
 [Special Characters in a Makefile](../vs140/special-characters-in-a-makefile.md)   
 [Contents of a Makefile](../vs140/contents-of-a-makefile.md)
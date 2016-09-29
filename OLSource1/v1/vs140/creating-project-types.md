---
title: "Creating Project Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "project types, new"
  - "projects [Visual Studio SDK], new project types"
ms.assetid: bdb2d22e-d622-450c-bb2d-98152a745fcf
caps.latest.revision: 29
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Creating Project Types
You can extend [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] by creating a new project type. To create a new project type, you must understand several concepts and complete a number of steps. The following topics provide an overview of how to create project types.  
  
## In This Section  
 [Project Type Design Decisions](../vs140/project-type-design-decisions.md)  
 Discusses the item, project file persistence, and commitment mechanic design decisions that you have to make before creating a new project type.  
  
 [Checklist: Creating New Project Types](../vs140/checklist--creating-new-project-types.md)  
 Provides an overview of the steps that you must follow to create a new project type that supports programming tasks as editing code and compiling, building, debugging, and deploying applications in your project.  
  
 [Creating Project Instances By Using Project Factories](../vs140/creating-project-instances-by-using-project-factories.md)  
 Provides information about how to provide and use a project factory to create instances of a new project.  
  
 [Registering a Project Type](../vs140/registering-a-project-type.md)  
 Provides code samples of statements from the registry that provide default paths and data, and a table that contain entries from the registry script for each statement.  
  
 [Project Persistence](../vs140/project-persistence.md)  
 Discusses the use of `IPersistFileFormat` to persist both file and non-file-based project objects.  
  
 [Using MSBuild](../vs140/using-msbuild.md)  
 Describes how your project type can use the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] build engine to let users build from [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and at the command line.  
  
## Related Sections  
 [Supporting Symbol-Browsing Tools](../vs140/supporting-symbol-browsing-tools.md)  
 Explains the architecture of code viewing tools such as the **Object Browser** and **Class View** window. Describes the interfaces and methods that are used to implement object browsing in a VSPackage.  
  
 [Adding Project and Project Item Templates](../vs140/adding-project-and-project-item-templates.md)  
 Discusses the significance that projects play in determining which editor is used when a project item is opened and how project resources can be manipulated.  
  
 [Installing VSPackages With Windows Installer](../vs140/installing-vspackages-with-windows-installer.md)  
 Shows how to give your VSPackage its own unique identity and how to wrap your VSPackage DLLs and other information in a Windows Installer package (.MSI file) for deployment to your customers.  
  
 [Hierarchies in Visual Studio](../vs140/hierarchies-in-visual-studio.md)  
 Describes how [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] views and addresses hierarchies.  
  
 [VSPackages Overview](../vs140/vspackages.md)  
 Provides an overview of a VSPackage, an installable COM object that extends the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment and discusses how to implement your own VSPackage.  
  
 [Project Types](../vs140/project-types.md)  
 Discusses how to use projects to modify code, compile and build code, and run and debug code, and provides links to detailed topics about how to create project types.
---
title: "Project Type Essentials"
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
  - "project types [Visual Studio SDK]"
ms.assetid: 09991589-2300-430e-b6a4-7f2b95fe676f
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Project Type Essentials
[!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] includes several project types for languages such as [!INCLUDE[csprcs](../VS_csharp/includes/csprcs_md.md)] or [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)]. [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] also lets you create your own project types.  
  
 If you just want to add custom commands, editors, or tool windows to [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)], you can do so without creating a new project type. For more information, see the following topics:  
  
-   [Menu and Toolbar Commands](../VS_csharp/commands--menus--and-toolbars.md)  
  
-   [Editors](../VS_csharp/editor-and-language-service-extensions.md)  
  
-   [Extending and Customizing Tool Windows](../VS_csharp/extending-and-customizing-tool-windows.md)  
  
 Likewise, if you want to customize the behavior of the supplied [!INCLUDE[csprcs](../VS_csharp/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] project types, you can do so using project subtypes. For more information, see [Project Subtypes](../VS_csharp/project-subtypes.md).  
  
 You must create a new project type for projects that are based on a language other than [!INCLUDE[csprcs](../VS_csharp/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] if you want to support one or more of the following:  
  
-   Build  
  
-   Deployment  
  
-   Multiple configurations  
  
-   Source control  
  
-   Debugging  
  
-   Project items in Solution Explorer  
  
-   The **Open Project** or **New Project** dialog boxes  
  
-   Project nesting  
  
-   For more information about the capabilities of project types, see the following:  
  
-   Project types are objects in a VSPackage that implement the set of interfaces [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] expects. If you are using C# to develop a project type, the Managed Package Framework project classes implement the necessary interfaces for you and let you inherit that implementation. For more information, see [Using MPF Project Classes to Implement a Project Type (C#)](../VS_csharp/using-the-managed-package-framework-to-implement-a-project-type--csharp-.md).  
  
-   For C++ developers, the classes in the HierUtil library work in a similar manner. For more information, see [Not in Build: Using HierUtil7 Project Classes to Implement a Project Type (C++)](assetId:///a5c16a09-94a2-46ef-87b5-35b815e2f346).  
  
-   Project types can support data other than typical source code files that build into an .exe or .dll assembly. For example, [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] database projects contain references to script and query files stored on disk and add commands to **Solution Explorer** to execute the scripts and queries against a database, but the projects do not support build behavior. For more information, see [Opening and Saving Project Items](../VS_csharp/opening-and-saving-project-items.md).  
  
-   A project type does not have to use files at all. For example, a project type could store all its data in a database. [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] gives project types complete control over how they persist data for projects and project items. For more information, see [Project Type Design Decisions](../VS_csharp/project-type-design-decisions.md).  
  
-   Project types must provide a *project factory*, which is an object that creates an instance of the project type whenever [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] is told to open or create a project that is based on that project type. For more information, see [Creating Project Instances with Project Factories](../VS_csharp/creating-project-instances-by-using-project-factories.md).  
  
-   Project types must supply templates for projects and project items. [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] uses the templates when users create new projects and add new items to existing projects. For more information, see [Adding Project and Project Item Templates](../VS_csharp/adding-project-and-project-item-templates.md).  
  
-   Project types can support multiple configurations, such as Debug and Release. Users can change the different configurations of a project by using property pages that you supply. For more information, see [Managing Configuration Options](../VS_csharp/managing-configuration-options.md).  
  
## See Also  
 [Deploying Managed-Code Project Types](../VS_csharp/deploying-project-types.md)
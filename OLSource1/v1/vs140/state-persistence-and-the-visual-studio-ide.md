---
title: "State Persistence and the Visual Studio IDE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDE settings, state persistence"
  - "user settings [Visual Studio SDK], persisting"
  - "Tools Options pages [Visual Studio SDK], persisting settings"
  - "IDE, state persistence"
  - "persistence, user settings"
ms.assetid: fdd49bb1-ed3b-4428-b685-de65c3215c1c
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# State Persistence and the Visual Studio IDE
The **Import/Export Settings** command on the **Tools** menu of the integrated development environment (IDE) imports and exports customizations of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment. The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings APIs in the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] enable a VSPackage to define one or more settings categories (groups of state variables) to be persisted when a user chooses the **Import/Export Settings** command.  
  
 A GUID uniquely identifies each settings category and is defined in its own registry entry, referred to as a *Custom Settings Point*.  
  
> [!NOTE]
>  The standard implementations of the **ToolsOptions** pages, the **Toolbox**, and the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> automatically provide support for persistence. The settings API can override the default mechanism. For more information, see [Toolbox Overview](../vs140/extending-the-toolbox.md), [Tools Options Pages Overview](../vs140/options-pages.md), and \<xref:Microsoft.VisualStudio.Shell.DialogPage*>.  
  
## In This Section  
 [Persistence Settings](../vs140/support-for-user-settings.md)  
 Describes the registry settings (Custom Settings Point) and attributes used to specify a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings implementation used by a given VSPackage.  
  
 [How to: Export Environment Settings by Using Interop Assemblies](../vs140/how-to--export-settings-by-using-interop-assemblies.md)  
 Provides a detailed description of how to implement support for saving configuration data by using the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings mechanism for interop assembly based VSPackages.  
  
 [How to: Use Interop Assemblies to Import Environment Settings](../vs140/how-to--use-interop-assemblies-to-import-settings.md)  
 Provides a detailed description of how to implement support for retrieving configuration data by using the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings mechanism for interop assembly based VSPackages.  
  
 [How to: Export Environment Settings by Using the Managed Package Framework](../vs140/exporting-settings.md)  
 Includes a detailed description of how to implement support for saving configuration data by using the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings mechanism for Managed Package Framework based VSPackages.  
  
 [How to: Import Environment Settings by Using the Managed Package Framework](../vs140/importing-settings.md)  
 Provides a detailed description of how to implement support for retrieving configuration data by using the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings mechanism for Managed Package Framework based VSPackages.  
  
## Related Sections  
 [Working with Settings](assetId:///4c0a56ab-6091-4ebc-9dc7-52c40846bacb)  
 Describes how to manage the export/import sections of the IDE.  
  
 [Tools Options Pages](../vs140/options-pages.md)  
 Describes the support that the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] automatically provides for managing existing or creating new **Tools Options** pages.  
  
 [Toolbox Overview](../vs140/extending-the-toolbox.md)  
 Explains the support that the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] automatically provides for managing or extending the **Toolbox**.  
  
 [User Settings and Options](../vs140/extending-user-settings-and-options.md)  
 Describes how to program your VSPackage to obtain and preserve user preferences.
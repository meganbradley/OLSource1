---
title: "IDE-Defined Commands, Menus, and Groups"
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
  - "commands, environment-defined"
  - ".vsct files, environment-defined constants"
  - "command groups, environment-defined"
ms.assetid: 86b3af13-7163-48c6-986b-7beeedbc26cc
caps.latest.revision: 31
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDE-Defined Commands, Menus, and Groups
Many menus, commands and command groups are already defined for use by the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] IDE. These commands are also available for your use when you extend [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].  
  
## Finding Environment-Defined Commands  
 The environment commands are defined in a set of four .vsct files:  
  
-   SharedCmdDef.vsct  
  
-   SharedCmdPlace.vsct  
  
-   ShellCmdDef.vsct  
  
-   ShellCmdPlace.vsct  
  
 These files are located in *<Visual Studio SDK installation path\>*\VisualStudioIntegration\Common\Inc\\. These files provide the definitions and GUIDs of the menus and groups that you can use in the command table configuration (.vsct) file of your VSPackage as containers for your own menus, groups, and commands.  
  
## In This Section  
 [GUIDs and IDs of Visual Studio Menus](../VS_csharp/guids-and-ids-of-visual-studio-menus.md)  
 Gives the GUID and ID values of menus on the Visual Studio menu bar, and of the groups they contain.  
  
 [GUIDs and IDs of Visual Studio Toolbars](../VS_csharp/guids-and-ids-of-visual-studio-toolbars.md)  
 Gives the GUID and ID values of toolbars in the Visual Studio IDE, and of the groups they contain.  
  
 [GUIDs and IDs of Visual Studio Commands](../VS_csharp/guids-and-ids-of-visual-studio-commands.md)  
 Gives the GUID and ID values of commands defined by the Visual Studio IDE.  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../VS_csharp/visual-studio-command-table--.vsct--files.md)   
 [Environment-Defined Commands for Extending Project Systems](../VS_csharp/ide-defined-commands-for-extending-project-systems.md)   
 [How VSPackages Contribute User Interface Elements](../VS_csharp/how-vspackages-add-user-interface-elements.md)
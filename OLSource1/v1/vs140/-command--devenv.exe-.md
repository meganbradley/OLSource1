---
title: "-Command (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Command (devenv.exe)"
helpviewer_keywords: 
  - "Devenv, /command switch"
  - "/command Devenv switch"
ms.assetid: 13c20cd6-f09d-400a-8b7b-ecc266a32cef
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Command (devenv.exe)
Executes the specified command after launching the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE).  
  
## Syntax  
  
```  
devenv /command CommandName  
```  
  
## Arguments  
 `CommandName`  
 Required. The complete name of a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] command or its alias, enclosed in double quotation marks. For more information about command and alias syntax, see [Visual Studio Commands](../vs140/visual-studio-commands.md).  
  
## Remarks  
 After startup is complete, the IDE executes the named command. If you use this switch, the IDE does not display the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Start Page on startup.  
  
 If an add-in exposes a command, you can use this switch to launch the add-in from the command line. For more information, see [Controlling Add-Ins with the Add-In Manager](assetId:///4f60444a-cb48-4cdb-8df4-941f6419aeeb).  
  
## Example  
 This example launches [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and automatically runs the macro Open Favorite Files.  
  
```  
devenv /command "Macros.MyMacros.Module1.OpenFavoriteFiles"  
```  
  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)
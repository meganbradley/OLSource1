---
title: "Extending Menus and Commands"
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
  - "menus, common tasks"
  - "VSPackages, menu tasks"
  - ".vsct files, common menu tasks"
ms.assetid: 7b2be4b9-e3fe-4412-874f-ae72ebc84c4b
caps.latest.revision: 53
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Extending Menus and Commands
Commands are the way you add actions and processes to Visual Studio. In most cases commands are displayed on menus or toolbars. The VSPackage project template shows how to implement a very basic command. For a slightly longer but still basic implementation, see [Creating a VSPackage with a Menu Command](../VS_csharp/creating-an-extension-with-a-menu-command.md).  
  
 For more information about Visual Studio commands, menus and toolbars, see [Commands, Menus, and Toolbars](../VS_csharp/commands--menus--and-toolbars.md).  
  
 Commands, menus, and toolbars are defined in the .vsct file that is part of VSPackage projects. You can find information about the Visual Studio IDE and the .vsct file in [How VSPackages Add User Interface Elements](../VS_csharp/how-vspackages-add-user-interface-elements.md).  
  
 The following topics explain how to add different kinds of commands, menus, and toolbars.  
  
## In This Section  
 [Adding a Menu to the Visual Studio Menu Bar](../VS_csharp/adding-a-menu-to-the-visual-studio-menu-bar.md)  
 Explains how to add a menu to the top Visual Studio menu bar.  
  
 [Binding Keyboard Shortcuts to Menu Items](../VS_csharp/binding-keyboard-shortcuts-to-menu-items.md)  
 Explains how to add a keyboard shortcut (such as CTRL + 3) to a menu item.  
  
 [Adding a Submenu to a Menu](../VS_csharp/adding-a-submenu-to-a-menu.md)  
 Explains how to add a submenu to the top menu.  
  
 [Adding a Most Recently Used List to a Submenu](../VS_csharp/adding-a-most-recently-used-list-to-a-submenu.md)  
 Explains how to add a Most Recently Used list.  
  
 [How to: Create Reusable Groups of Buttons](../VS_csharp/creating-reusable-groups-of-buttons.md)  
 Describes how to group command items so that they can be included on multiple menus.  
  
 [How to: Add Icons to Commands](../VS_csharp/adding-icons-to-menu-commands.md)  
 Describes how to add an icon to a command on both a toolbar and a menu.  
  
 [How to: Change Text of Menus](../VS_csharp/changing-the-text-of-a-menu-command.md)  
 Describes the use of the `TextChanges` flag to enable a menu item to be changed dynamically.  
  
 [How to: Change the Appearance of Commands](../VS_csharp/changing-the-appearance-of-a-command.md)  
 Describes how to dynamically enable or disable a command.  
  
 [How to: Update the User Interface](../VS_csharp/updating-the-user-interface.md)  
 Describes how to force an update of the user interface to reflect recent changes.  
  
 [Localizing Menu Commands](../VS_csharp/localizing-menu-commands.md)  
 Explains how to localize menu commands.  
  
## Related Sections
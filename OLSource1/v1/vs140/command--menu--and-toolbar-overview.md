---
title: "Command, Menu, and Toolbar Overview"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - menu essentials [Visual Studio SDK]
  - toolbar essentials [Visual Studio SDK]
ms.assetid: cbdaceaa-7dd3-4a56-aea6-b759e48d83d6
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Command, Menu, and Toolbar Overview
Menus and toolbars provide a convenient graphical way for users to access commands in your VSPackage. Commands are functions that accomplish tasks, such as printing a document, refreshing a view, or creating a new file. Menus and toolbars are convenient graphical ways to present your commands to users. Typically, related commands are clustered together on the same menu or toolbar.  
  
-   Menus typically are displayed as one-word strings clustered in a row at the top of the integrated development environment (IDE) or a tool window. Menus also can be displayed as the result of a right-click event, and are referred to as shortcut menus in that context. When clicked, menus expand to display one or more commands. Commands, when clicked, can carry out tasks or launch submenus that contain additional commands. Some well-known menu names are File, Edit, View, and Window. For more information, see [Common Menu Tasks](../vs140/extending-menus-and-commands.md).  
  
-   Toolbars typically are rows of buttons and other controls, such as combo boxes, list boxes, text boxes, and menu controllers. All toolbar controls are associated with commands. When you click a toolbar button, its associated command is activated. Toolbar buttons usually have icons that suggest the underlying commands, such as a printer for a Print command. In a drop-down list control, each item in the list is associated with a different command. A menu controller is a hybrid in which one side of the control is a toolbar button and the other side is a down arrow that displays additional commands when clicked. For more information, see [How to: Create Toolbars for Tool Windows](../vs140/how-to--create-toolbars-for-tool-windows.md) and [How to: Add Icons to Commands on Toolbars](../vs140/adding-icons-to-menu-commands.md).  
  
-   When you create a command, you also must create an event handler for it. The event handler determines when the command is visible or enabled, allows you to modify its text, and ensures that the command responds appropriately ("routes") when activated. In most instances, the IDE handles commands using the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget?qualifyHint=False> interface. Commands in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] route in a hierarchical manner, starting with the innermost command context, based on the local selection, and proceeding to the outermost context, based on the global selection. Commands added to the main menu are immediately available for scripting. For more information, see [How to: Create and Handle Commands in VSPackages (C#)](../vs140/menucommands-vs.-olemenucommands.md) and [Selection Context Objects](../vs140/selection-context-objects.md).  
  
 To define new menus and toolbars, you must describe them in an Visual Studio Command Table (.vsct) file. The Visual Studio Package Template creates this file for you, along with the necessary elements to support whatever commands, toolbars, and editors you selected in the template. Alternatively, you can write your own .vsct file, using the xml schema described here: [VSCT XML Schema Reference](../vs140/vsct-xml-schema-reference.md).  
  
 For more information about working with .vsct files, see [Visual Studio Command Table (.Vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md), or try any of the [Menu and Toolbar Command Walkthroughs](../vs140/walkthroughs-for-user-interface-elements.md).  
  
 For a more detailed overview of menus and toolbars, see [Introduction to Menu and Toolbar Commands](../vs140/command-design.md).  
  
## See Also  
 [Common Menu Tasks](../vs140/extending-menus-and-commands.md)   
 [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md)   
 [VSPackages](../vs140/vspackages.md)
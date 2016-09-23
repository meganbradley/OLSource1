---
title: "Associating Menu Commands with Status Bar Text in MFC Applications"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - status bars, associating menu items
  - menus, status bar text
ms.assetid: 757c0e02-bc97-493f-bccd-6cc6887ebc64
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Associating Menu Commands with Status Bar Text in MFC Applications
Your application can display descriptive text for each of the menu commands a user may select. You do this by assigning a text string to each menu command using the **Prompt** property in the Properties window. If you have a string in the [string table](../vs140/string-editor.md) whose ID is the same as the command, an MFC application will automatically display this string resource in the status bar of the running application when a user hovers over a menu item.  
  
### To associate a menu command with a status bar text string  
  
1.  In the **Menu** editor, select the menu command.  
  
2.  In the [Properties Window](../vs140/properties-window.md), type the associated status bar text in the **Prompt** box.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 MFC  
  
## See Also  
 [Strings (ATL/MFC)](../vs140/strings--atl-mfc-.md)   
 [Adding Commands to a Menu](../vs140/adding-commands-to-a-menu.md)   
 [Menu Editor](../vs140/menu-editor.md)
---
title: "Accelerator Editor"
ms.custom: na
ms.date: 09/23/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vc.editors.accelerator.F1
dev_langs: 
  - C++
helpviewer_keywords: 
  - accelerator tables [C++], editing
  - tables [Visual Studio], accelerator key
  - accelerator keys
  - resource editors, Accelerator editor
  - keyboard shortcuts [C++], Accelerator editor
  - Accelerator editor
ms.assetid: 013c30b6-5d61-4f1c-acef-8bd15bed7060
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Accelerator Editor
An accelerator table is a Windows resource that contains a list of accelerator keys (also known as shortcut keys) and the command identifiers that are associated with them. A program can have more than one accelerator table.  
  
 Normally, accelerators are used as keyboard shortcuts for program commands that are also available on a menu or toolbar. However, you can use the accelerator table to define key combinations for commands that don't have a user-interface object associated with them.  
  
 You can use [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925) to hook accelerator key commands to code.  
  
 With the Accelerator editor, you can:  
  
-   [Set Accelerator Properties](../vs140/setting-accelerator-properties.md)  
  
-   [Associate an Accelerator Key with a Menu Item](../vs140/associating-an-accelerator-key-with-a-menu-item.md)  
  
-   [Edit Accelerator Tables](../vs140/editing-accelerator-tables.md)  
  
-   [Use Predefined Accelerator Keys](../vs140/predefined-accelerator-keys.md)  
  
    > [!TIP]
    >  While using the Accelerator editor, you can right-click to display a shortcut menu of frequently used commands. The commands available depend on what the pointer is pointing to.  
  
    > [!NOTE]
    >  Windows does not allow you to create empty accelerator tables. If you create an accelerator table with no entries, it is deleted automatically when you save the table.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
## Requirements  
 Win32  
  
## See Also  
 [Resource Editors](../vs140/resource-editors.md)
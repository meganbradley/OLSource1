---
title: "Changing the Properties of Multiple Accelerator Keys"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "keyboard shortcuts [C++], property changing"
  - "accelerator tables [C++], changing properties"
ms.assetid: b55c9bd6-b430-48bb-b942-0e6f21d7abf9
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Changing the Properties of Multiple Accelerator Keys
### To change the properties of multiple accelerator keys  
  
1.  Open the accelerator table by double-clicking its icon in [Resource View](../vs140/resource-view-window.md).  
  
    > [!NOTE]
    >  If your project doesn't already contain an .rc file, please see [Creating a New Resource Script File](../vs140/how-to--create-a-resource-script-file.md).  
  
2.  Select the accelerator keys you want to change by holding down the **CTRL** key as you click each one.  
  
3.  Go to the [Properties window](../vs140/properties-window.md) and type in the values you want all of the selected accelerators to share.  
  
    > [!NOTE]
    >  Each modifier value appears as a Boolean property in the Properties window. If you change a [Modifier](../vs140/accelerator-modifier-property.md) value in the Properties window, the accelerator table treats the new modifier as an addition to any modifiers that were previously there. Because of this, if you set any modifier values, you will need to set all of them to ensure that every accelerator shares the same Modifier settings.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 Win32  
  
## See Also  
 [Editing Accelerator Tables](../vs140/editing-accelerator-tables.md)   
 [Accelerator Editor](../vs140/accelerator-editor.md)
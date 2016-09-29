---
title: "Setting Accelerator Properties"
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
  - "accelerator properties"
  - "properties [C++], accelerator properties"
  - "Type property"
  - "Key property"
  - "Modifier property"
ms.assetid: 0fce9156-3025-4e18-b034-e219a4c65812
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Setting Accelerator Properties
In Visual C++ .NET, you can set accelerator properties in the [Properties window](../vs140/properties-window.md) at any time. You can also use the Accelerator editor to modify the accelerator properties in the accelerator table. Changes made using the Properties window or the Accelerator editor have the same result: edits are immediately reflected in the accelerator table.  
  
 There are three properties for each [accelerator ID](../vs140/id-property.md):  
  
-   The [Modifier property](../vs140/accelerator-modifier-property.md) sets control key combinations for the accelerator.  
  
    > [!NOTE]
    >  In the Properties window, this property appears as three separate Boolean properties, all of which can be controlled independently: Alt, Ctrl, and Shift.  
  
-   The [Key property](../vs140/accelerator-key-property.md) sets the actual key to use as the accelerator.  
  
-   The [Type property](../vs140/accelerator-type-property.md) determines whether the key is interpreted as virtual (VIRTKEY) or ASCII/ANSI.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
## Requirements  
 Win32  
  
## See Also  
 [Predefined Accelerator Keys](../vs140/predefined-accelerator-keys.md)   
 [Resource Editors](../vs140/resource-editors.md)   
 [Accelerator Editor](../vs140/accelerator-editor.md)
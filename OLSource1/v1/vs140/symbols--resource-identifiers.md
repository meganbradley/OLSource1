---
title: "Symbols: Resource Identifiers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.editors.symbol.identifiers"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "symbols, resource identifiers"
  - "symbols, creating"
  - "resource symbols"
  - "symbols, editing"
  - "resource editors, resource symbols"
ms.assetid: 8fccc09a-0237-4a65-b9c4-57d60c59e324
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Symbols: Resource Identifiers
A symbol is a resource identifier (ID) that consists of two parts: a text string (symbol name) mapped to an integer value (symbol value). For example:  
  
```  
IDC_EDITNAME = 5100  
```  
  
 Symbol names are most often referred to as identifiers.  
  
 Symbols provide a descriptive way of referring to resources and user-interface objects, both in your source code and while you're working with them in the resource editors. You can view and manipulate symbols in one convenient place using the [Resource Symbols dialog box](../vs140/viewing-resource-symbols.md).  
  
 When you create a new resource or resource object, the [resource editors](../vs140/resource-editors.md) provide a default name for the resource, for example, `IDC_RADIO1`, and assign a value to it. The name-plus-value definition is stored in the Resource.h file.  
  
> [!NOTE]
>  When you are copying resources or resource objects from one .rc file to another, Visual C++ may change the transferred resource's symbol value, or symbol name and value, to avoid conflicts with symbol names or values in the existing file.  
  
 As your application grows in size and sophistication, so does its number of resources and symbols. Tracking large numbers of symbols scattered throughout several files can be difficult. The [Resource Symbols dialog box](../vs140/resource-symbols-dialog-box.md) simplifies symbol management by offering a central tool through which you can:  
  
-   [View Resource Symbols](../vs140/viewing-resource-symbols.md)  
  
-   [Create New Symbols](../vs140/creating-new-symbols.md)  
  
-   [Change Unassigned Symbols](../vs140/changing-unassigned-symbols.md)  
  
-   [Delete Unassigned Symbols](../vs140/deleting-unassigned-symbols.md)  
  
-   [Open the Resource Editor for a Given Symbol](../vs140/opening-the-resource-editor-for-a-given-symbol.md)  
  
-   [Change a Symbol or Symbol Name (ID)](../vs140/changing-a-symbol-or-symbol-name--id-.md)  
  
-   [Change a Symbol's Numeric Value](../vs140/changing-a-symbol-s-numeric-value.md)  
  
-   [Change the Names of Symbol Header Files](../vs140/changing-the-names-of-symbol-header-files.md)  
  
-   [Include Shared (Read-Only) or Calculated Symbols](../vs140/including-shared--read-only--or-calculated-symbols.md)  
  
-   [View Predefined Symbol IDs](../vs140/predefined-symbol-ids.md)  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
## Requirements  
 Win32  
  
## See Also  
 [How to: Search for Symbols in Resources](../vs140/how-to--search-for-symbols-in-resources.md)   
 [Resource Editors](../vs140/resource-editors.md)   
 [Resource Files](../vs140/resource-files--visual-studio-.md)
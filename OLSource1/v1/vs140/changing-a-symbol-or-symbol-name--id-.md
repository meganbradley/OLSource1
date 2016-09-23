---
title: "Changing a Symbol or Symbol Name (ID)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vc.editors.symbol.changing
dev_langs: 
  - C++
helpviewer_keywords: 
  - symbol names
  - symbols, names
ms.assetid: 26541832-8dba-4177-b642-e08f94502ea7
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Changing a Symbol or Symbol Name (ID)
When you create a new resource or resource object, the development environment assigns it a default symbol name, for example, IDD_DIALOG1. You can use the [Properties Window](../vs140/properties-window.md) to change the default symbol name or to change the name of any symbol already associated with a resource.  
  
### To change a resource's symbol name  
  
1.  In [Resource View](../vs140/resource-view-window.md), select the resource.  
  
    > [!NOTE]
    >  If your project doesn't already contain an .rc file, please see [Creating a New Resource Script File](../vs140/how-to--create-a-resource-script-file.md).  
  
2.  In the **Properties** window, type a new symbol name or select from the list of existing symbols in the **ID** box.  
  
     If you type a new symbol name, it is automatically assigned a value.  
  
 You can use the [Resource Symbols dialog box](../vs140/resource-symbols-dialog-box.md) to change the names of symbols not currently assigned to a resource. For more information, see [Changing Unassigned Symbols](../vs140/changing-unassigned-symbols.md).  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 Requirements  
  
 Win32  
  
## See Also  
 [Symbol Name Restrictions](../vs140/symbol-name-restrictions.md)   
 [Predefined Symbol IDs](../vs140/predefined-symbol-ids.md)
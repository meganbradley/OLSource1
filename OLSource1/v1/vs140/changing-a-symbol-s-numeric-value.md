---
title: "Changing a Symbol&#39;s Numeric Value"
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
  - vc.editors.symbol.changing.value
dev_langs: 
  - C++
helpviewer_keywords: 
  - numeric values
  - symbols, numeric values
  - numeric values, changing symbols
ms.assetid: 468e903b-9c07-4251-ae09-3b6cb754cc2b
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Changing a Symbol&#39;s Numeric Value
For symbols associated with a single resource, you can use the [Properties Window](../vs140/properties-window.md) to change the symbol value. You can use the [Resource Symbols dialog box](../vs140/resource-symbols-dialog-box.md) to change the value of symbols not currently assigned to a resource. For more information, see [Changing Unassigned Symbols](../vs140/changing-unassigned-symbols.md).  
  
### To change a symbol value assigned to a single resource or object  
  
1.  In [Resource View](../vs140/resource-view-window.md), select the resource.  
  
    > [!NOTE]
    >  If your project doesn't already contain an .rc file, please see [Creating a New Resource Script File](../vs140/how-to--create-a-resource-script-file.md).  
  
2.  In the **Properties** window, type the symbol name followed by an equal sign and an integer in the **ID** box, for example:  
  
    ```  
    IDC_EDITNAME=5100  
    ```  
  
 The new value is stored in the symbol header file the next time you save the project. Only the symbol name remains visible in the ID box; the equal sign and value are not displayed after they are validated.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 Requirements  
  
 Win32  
  
## See Also  
 [Symbol Value Restrictions](../vs140/symbol-value-restrictions.md)   
 [Predefined Symbol IDs](../vs140/predefined-symbol-ids.md)
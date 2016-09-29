---
title: "How to: Search for Symbols in Resources"
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
  - "symbols, finding"
  - "resources [Visual Studio], searching for symbols"
ms.assetid: 6efef8e8-d0d4-4c49-b895-314974e7791a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Search for Symbols in Resources
### To find symbols in resources  
  
1.  From the **Edit** menu, choose **Find Symbol**.  
  
2.  In the [Find Symbol dialog box](assetId:///63e93d9c-784f-418d-a76a-723da5ff5d96), in the **Find What** box, select a previous search string from the drop-down list or type the accelerator key you want to find (for example, ID_ACCEL1).  
  
    > [!TIP]
    >  To use [regular expressions](../vs140/using-regular-expressions-in-visual-studio.md) for your search, you must use the [Find in Files command](../vs140/find-command.md) from the **Edit** menu instead of the **Find Symbol** command. To enable regular expressions, you must have the **Use: Regular Expressions** check box selected in the [Find dialog box](assetId:///dad03582-4931-4893-83ba-84b37f5b1600). Then you can click the right-arrow button to the right of the **Find What** box to display a list of regular search expressions. When you select an expression from this list, it is substituted as the search text in the **Find What** box.  
  
3.  Select any of the **Find** options.  
  
4.  Click **Find Next**.  
  
    > [!NOTE]
    >  You cannot search for symbols in string, accelerator, or binary resources.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 Win32  
  
## See Also  
 [Symbols: Resource Identifiers](../vs140/symbols--resource-identifiers.md)   
 [Resource Files](../vs140/resource-files--visual-studio-.md)   
 [Resource Editors](../vs140/resource-editors.md)
---
title: "Adding Formatting or Special Characters to a String"
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
  - "special characters, adding to strings"
  - "ASCII characters, adding to strings"
  - "strings [C++], formatting"
  - "strings [C++], special characters"
ms.assetid: c40f394a-8b2c-4896-ab30-6922863ddbb5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding Formatting or Special Characters to a String
### To add formatting or special characters to a string  
  
1.  Open the string table by double-clicking its icon in [Resource View](../vs140/resource-view-window.md).  
  
    > [!NOTE]
    >  If your project doesn't already contain an .rc file, please see [Creating a New Resource Script File](../vs140/how-to--create-a-resource-script-file.md).  
  
2.  Select the string you want to modify.  
  
3.  In the [Properties Window](../vs140/properties-window.md), add any of the standard escape sequences listed below to the text in the **Caption** box, and press **ENTER**.  
  
    |To get this|Type this|  
    |-----------------|---------------|  
    |New line|\n|  
    |Carriage return|\r|  
    |Tab|\t|  
    |Backslash (\\)|\\\|  
    |ASCII character|\ddd (octal notation)|  
    |Alert (bell)|\a|  
  
> [!NOTE]
>  The String editor does not support the full set of escaped ASCI characters. You can only use those listed above.  
  
 For information on adding resources to managed projects (those that target the common language runtime), please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 Win32  
  
## See Also  
 [String Editor](../vs140/string-editor.md)   
 [Strings](_win32_Strings)   
 [About Strings](_win32_About_Strings_cpp)
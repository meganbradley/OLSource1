---
title: "Finding a String"
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
  - "vc.editors.string"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strings [C++], searching"
  - "strings [C++]"
ms.assetid: c2497173-f356-4f77-97d6-f0ac41782510
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Finding a String
You can search for one or more strings in the string table, and use [regular expressions](../VS_csharp/using-regular-expressions-in-visual-studio.md) with the **Find in Files** command (**Edit** menu) to locate all instances of strings that match a pattern.  
  
### To find a string in the string table  
  
1.  Open the string table by double-clicking its icon in [Resource View](../VS_csharp/resource-view-window.md).  
  
    > [!NOTE]
    >  If your project doesn't already contain an .rc file, please see [Creating a New Resource Script File](../VS_csharp/how-to--create-a-resource-script-file.md).  
  
2.  On the **Edit** menu, click **Find and Replace**, then choose **Find**.  
  
3.  In the **Find What** box, select a previous search string from the drop-down list or type the caption text or resource identifier of the string you want to find.  
  
4.  Select any of the **Find** options.  
  
5.  Click **Find Next**.  
  
    > [!TIP]
    >  To use regular expressions when searching files, use the **Find in Files** command. Type a regular expression to match a pattern or click the button to the right of the **Find What** box to display a list of regular search expressions. When you select an expression from this list, it is substituted as the search text in the **Find What** box. If you use regular expressions, be sure the **Use: Regular Expressions** check box is selected.  
  
 For information on adding resources to managed projects (those that target the common language runtime), please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 Win32  
  
## See Also  
 [String Editor](../VS_csharp/string-editor.md)   
 [Strings](_win32_Strings)   
 [About Strings](_win32_About_Strings_cpp)
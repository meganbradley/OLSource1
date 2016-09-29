---
title: "Resource Includes Dialog Box"
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
  - "vc.editors.resourceincludes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Resource Includes dialog box"
  - "rc files, changing storage"
  - "symbol header files, changing"
  - "compiling source code, including resources"
  - ".rc files, changing storage"
  - "symbol header files, read-only"
  - "symbols, symbol header files"
ms.assetid: 659a54e6-e416-4045-8411-798730ff4ce3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resource Includes Dialog Box
You can use the **Resource Includes** dialog box to modify the environment's normal working arrangement of storing all resources in the project .rc file and all [symbols](../VS_csharp/symbols--resource-identifiers.md) in Resource.h.  
  
 To open the **Resource Includes** dialog box, right-click an .rc file in [Resource View](../VS_csharp/resource-view-window.md), then choose **Resource Includes** from the shortcut menu.  
  
 **Symbol header file**  
 Allows you to change the name of the header file where the symbol definitions for your resource file are stored. For more information, see [Changing the Names of Symbol Header Files](../VS_csharp/changing-the-names-of-symbol-header-files.md).  
  
 **Read-only symbol directives**  
 Enables you to include header files that contain symbols that should not be modified during an editing session. For example, you can include a symbol file that is shared among several projects. You can also include MFC .h files. For more information, see [Including Shared (Read-Only) or Calculated Symbols](../VS_csharp/including-shared--read-only--or-calculated-symbols.md).  
  
 **Compile-time directives**  
 Allows you to include resource files that are created and edited separately from the resources in your main resource file, contain compile-time directives (such as those that conditionally include resources), or contain resources in a custom format. You can also use the Compile-time directives box to include standard MFC resource files. For more information, see [Including Resources at Compile Time](../VS_csharp/how-to--include-resources-at-compile-time.md).  
  
> [!NOTE]
>  Entries in these text boxes appear in the .rc file marked by `TEXTINCLUDE 1`, `TEXTINCLUDE 2`, and `TEXTINCLUDE 3` respectively. For more information, see [TN035: Using Multiple Resource Files and Header Files with Visual C++](../VS_csharp/tn035--using-multiple-resource-files-and-header-files-with-visual-c--.md).  
  
 Once you have made changes to your resource file using the **Resource Includes** dialog box, you need to close the .rc file and then reopen it for the changes to take effect. For more information, see [Including Resources at Compile Time](../VS_csharp/how-to--include-resources-at-compile-time.md).  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
## Requirements  
 Win32  
  
## See Also  
 [How to: Specify Include Directories for Resources](../VS_csharp/how-to--specify-include-directories-for-resources.md)   
 [Symbols: Resource Identifiers](../VS_csharp/symbols--resource-identifiers.md)   
 [Resource Files](../VS_csharp/resource-files--visual-studio-.md)   
 [Resource Editors](../VS_csharp/resource-editors.md)
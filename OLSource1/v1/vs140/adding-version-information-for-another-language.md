---
title: "Adding Version Information for Another Language"
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
  - "vc.editors.version"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "languages, version information"
  - "New Version Info Block"
  - "blocks, adding"
  - "resources [Visual Studio], adding version information"
  - "version information, adding for languages"
ms.assetid: 17f6273c-e1cc-441a-a3d8-f564341cbf20
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding Version Information for Another Language
### To add version information for another language (new info block)  
  
1.  Open a version information resource by double-clicking it in [Resource View](../vs140/resource-view-window.md).  
  
    > [!NOTE]
    >  If your project doesn't already contain an .rc file, please see [Creating a New Resource Script File](../vs140/how-to--create-a-resource-script-file.md).  
  
2.  Right-click within the version information table and choose **New Version Info Block** from the shortcut menu.  
  
     This command adds an additional information block to the current version information resource and opens its corresponding properties in the [Properties window](../vs140/properties-window.md).  
  
3.  In the **Properties** window, choose the appropriate language and character set for your new block.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 Win32  
  
## See Also  
 [Version Information Editor](../vs140/version-information-editor.md)   
 [Version Information (Windows)](https://msdn.microsoft.com/library/windows/desktop/ms646981.aspx)
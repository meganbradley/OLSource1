---
title: "Registering Verbs for File Name Extensions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "verbs, registering"
ms.assetid: 81a58e40-7cd0-4ef4-a475-c4e1e84d6e06
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering Verbs for File Name Extensions
The association of a file name extension with an application generally has a preferred action that occurs when a user double-clicks a file. This preferred action is linked to a verb, for example open, that corresponds to the action.  
  
 You can register verbs that are associated with a programmatic identifier (ProgID) for an extension by using the Shell key located at HKEY_CLASSES_ROOT\\*progid*\shell. For more information, see [File Types](http://msdn.microsoft.com/library/windows/desktop/cc144148\(v=vs.85\).aspx).  
  
## Registering Standard Verbs  
 The operating system recognizes the following standard verbs:  
  
-   Open  
  
-   Edit  
  
-   Play  
  
-   Print  
  
-   Preview  
  
 Whenever possible, register a standard verb. The most common choice is the Open verb. Use the Edit verb only if there is a clear difference between opening the file and editing the file. For example, opening an .htm file displays it in the browser, whereas editing an .htm file starts an HTML editor. Standard verbs are localized with the operating system locale.  
  
> [!NOTE]
>  When registering standard verbs, do not set the default value for the Open key. The default value contains the display string on the menu. The operating system supplies this string for standard verbs.  
  
 Project files should be registered to start a new instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] when a user opens the file. The following example illustrates a standard verb registration for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] project.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To open a file in an existing instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], register a DDEEXEC key. The following example illustrates a standard verb registration for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] .cs file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Setting the Default Verb  
 The default verb is the action that is executed when a user double-clicks a file in Windows Explorer. The default verb is the verb specified as the default value for the HKEY_CLASSES_ROOT\\*progid*\Shell key. If no value is specified, the default verb is the first verb specified in the HKEY_CLASSES_ROOT\\*progid*\Shell key list.  
  
> [!NOTE]
>  If you plan to change the default verb for an extension in a side-by-side deployment, consider the impact on installation and removal. During installation the original default value is overwritten.  
  
## See Also  
 [Creating a File Association](_win32_file_associations)   
 [Managing Side-by-Side Projects](../vs140/managing-side-by-side-file-associations.md)
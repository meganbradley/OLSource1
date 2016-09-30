---
title: "Adding Directories to the New Project Dialog Box"
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
  - "New Project dialog box, extending"
ms.assetid: 53b328f5-20bb-49a3-bf9e-1818f4fbdf50
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding Directories to the New Project Dialog Box
When you create new project types, you also can register a new directory in the **New Project** dialog box to display them for use as templates. The following code example explains how to register a new directory, also known as a node. In the example, templates exposed by VSPackage CLSID_Package are registered. As a result, the left side of the **New Project** dialog box offers the added node, with a name determined by the Folder_Label_ResID resource. This resource is loaded from the VSPackage satellite DLL.  
  
 The **Folder** value represents a GUID of a folder under which the Folder_Label_ResID node is displayed. In the example, the GUID represents the **Other Projects** folder in the **Project Types** pane of the **New Project** dialog box. If the **Other Projects** value is absent, the label is positioned at the top level.  
  
 The TemplatesDir value specifies the full path of the directory that contains the project templates. These files can be either .vsz files or typical template files to be cloned.  
  
 If you specify TemplatesLocalizedSubDir, it must be the resource ID of a string that names the subdirectory of TemplatesDir that holds localized templates. Because [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] loads the string resource from a satellite DLL if you have one, each satellite DLL can contain a different subdirectory name. The SortPriority value specifies a sorting priority.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Registering Project and Item Templates](../vs140/registering-project-and-item-templates.md)   
 [Adding Items to the Add New Item Dialog Boxes](../vs140/adding-items-to-the-add-new-item-dialog-boxes.md)   
 [Adding Directories to the Add New Item Dialog Box](../vs140/adding-directories-to-the-add-new-item-dialog-box.md)
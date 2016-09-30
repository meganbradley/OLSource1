---
title: "Visual Studio Template Manifest Schema Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: bc7d0a81-0df5-41a9-a912-1b30e5da1d13
caps.latest.revision: 7
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Visual Studio Template Manifest Schema Reference
This schema describes the format of the Visual Studio template manifest (.vstman) files generated for Visual Studio project or item templates, and describes the location and other relevant information about the template.  
  
 : Because there are separate item and project template directories, a manifest should never have a mix of item and project templates.  
  
> [!IMPORTANT]
>  This manifest is available starting in Visual Studio "15" Preview 2.  
  
## VSTemplateManifest Element  
 The root element of the manifest.  
  
### Attributes  
  
-   **Version**: A string representing the version of the template manifest. Required.  
  
-   **Locale**: A string representing the locale or locales of the template manifest. The locale value applies to all templates, so you  must use a separate manifest for each locale. Optional.  
  
### Child Elements  
  
-   **VSTemplateContainer** Optional.  
  
-   **VSTemplateDir** Optional.  
  
### Parent Element  
 None.  
  
## VSTemplateContainer  
 The container of the template manifest elements. A manifest has one template container for each template it defines.  
  
### Attributes  
 **VSTemplateType** : A string value that specifies the type of the template (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>). Required  
  
### Child Elements  
  
-   **RelativePathOnDisk**:  The relative path of the template file on disk. This location also defines the placement of the template in the template tree shown in the **New Project** or **New Item** dialog. For templates deployed as a directory and individual files, this path refers to the directory containing the template files. For templates deployed as a .zip file, this path should be the path to the .zip file.  
  
-   **VSTemplateHeader** : A [TemplateData](../vs140/templatedata-element--visual-studio-templates-.md) element that describes the header.  
  
### Parent Element  
 **VSTemplateManifest**  
  
## VSTemplateDir  
 Describes the directory where the template is located. A manifest can contain multiple **VSTemplateDir** entries to provide localized name and sort ordering for directories to control their appearance in template category tree.  
  
 Due to their design, **VSTemplateDir** entries should  appear only in non-locale specified manifests.  
  
### Attributes  
 None.  
  
### Child Elements  
  
-   **RelativePath**: The path of the template. There can  be only one entry per path, so the first one will win for all manifests.  
  
-   **LocalizedName**: A **NameDescriptionIcon** element that specifies the localized name. Optional.  
  
-   **SortOrder** :A string that specifies the sort order. Optional.  
  
-   **ParentFolderOverrideName**: The overridden name of the parent folder. Optional. This element has a **Name** attribute, which is a string value that specifies the name.  
  
### Parent Element  
 **VSTemplateManifest**  
  
## NameDescriptionIcon  
 Specifies the name and description, possibly for localized templates. See **LocalizedName** above.  
  
### Attributes  
  
-   **Package**: A string value that specifies the package. Optional.  
  
-   **ID**:  A string value that specifies the ID. Optional.  
  
### Child Elements  
 None.  
  
### Parent Element  
 **LocalizedName**  
  
## Examples  
 The following is an example of a project template .vstman file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following is an example of an item template .vstman file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>
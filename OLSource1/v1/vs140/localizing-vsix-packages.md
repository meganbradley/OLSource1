---
title: "Localizing VSIX Packages"
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
  - "localize package"
  - "localize extension"
  - "localized deployment"
ms.assetid: 10e80b13-b39e-466c-a7c8-774a862355af
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Localizing VSIX Packages
You can localize a VSIX package by creating an Extension.vsixlangpack file for each target language and then putting them in the correct folder. When a localized package is installed, the localized name of the extension is displayed together with a localized description. If you supply a localized license file, or a URL that points to localized information, they are also displayed.  
  
 If the content your VSIX package includes a VSPackage that adds menu commands or other UI, see [How to: Localize Menu Commands](../vs140/localizing-menu-commands.md) for information about localizing the new UI elements.  
  
## Directory Structure  
 When a user installs an extension, **Extensions and Updates** checks the top level of the VSIX package for a folder whose name matches the Visual Studio locale of the target computer. If **Extensions and Updates** finds a .vsixlangpack file in the folder, it substitutes the localized values in that file for the corresponding values in the .vsixmanifest file. These values are displayed when the extension is being installed. The following example shows the directory structure for a VSIX package that is localized into Spanish (es-ES) and French (fr-FR).  
  
 MyExtension.dll  
  
 Extension.vsixmanifest  
  
 [Content_Types].xml  
  
 es-ES  
  
 Extension.vsixlangpack  
  
 fr-FR  
  
 Extension.vsixlangpack  
  
> [!NOTE]
>  The VSIX-supported project templates in the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] generate a VSIX manifest and name it source.extension.vsixmanifest. When Visual Studio builds the project, it copies the content of that file into Extension.VsixManifest in the VSIX package.  
  
## The Extension.vsixlangpack File  
 The Extension.vsixlangpack file follows the [VSIX Language Pack Schema](../vs140/vsx-language-pack-schema-reference.md). This schema has a [VSIXLanguagePack](../vs140/vsixlanguagepack-element--vsix-language-pack-schema-.md) root element, and these four child elements: [LocalizedName](../vs140/localizedname-element--vsix-language-pack-schema-.md), [LocalizedDescription](../vs140/localizeddescription-element--vsix-language-pack-schema-.md), [MoreInfoURL](../vs140/moreinfourl-element--vsix-language-pack-schema-.md), and [License](../vs140/license-element--vsix-language-pack-schema-.md). These child elements correspond to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> child elements of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element of the Extension.vsixmanifest file.  
  
 When you create a vsixlangpack file, you must set the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Otherwise, the localized installation text will be ignored.  
  
#### To set the Include in Vsix property  
  
1.  In **Solution Explorer**, right-click the Extension.vsixlangpack file, and then click **Properties**.  
  
2.  In the Property Grid, click **Include in Vsix**, and set its value to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
### Description  
 The following example shows relevant portions of an Extension.vsixmanifest file, together with the corresponding Extension.vsixlangpack file for Spanish. The values from the language pack replace the values from the manifest if the Visual Studio locale of the target computer is set to Spanish.  
  
### Code  
 [Extension.vsixmanifest]  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 [Extension.vsixlangpack]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSIXLanguagePack Element (VSIX Language Pack Schema)](../vs140/vsixlanguagepack-element--vsix-language-pack-schema-.md)   
 [Anatomy of a VSIX Container](../vs140/anatomy-of-a-vsix-package.md)   
 [Walkthrough: Publishing a Visual Studio Extension](../vs140/vsix-project-template.md)
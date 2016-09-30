---
title: "Walkthrough: Linking a Content Type to a File Name Extension"
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
  - "editors [Visual Studio SDK], new - link content type to file name extension"
ms.assetid: 21ee64ce-9afe-4b08-94a0-8389cc4dc67c
caps.latest.revision: 28
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Linking a Content Type to a File Name Extension
You can define your own content type and link a file name extension to it by using editor Managed Extensibility Framework (MEF) extensions. In some cases, the file name extension has already been defined by a language service; nevertheless, to use it with MEF you still must link it to a content type.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a MEF Project  
  
1.  Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
2.  In the **source.extension.vsixmanifest** file, go to the **Assets** tab, and set the **Type** field to **Microsoft.VisualStudio.MefComponent**, the **Source** field to **A project in current solution**, and the **Project** field to the name of the project.  
  
## Defining the Content Type  
  
1.  Add a class file and name it <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
2.  Add references to the following assemblies:  
  
    1.  System.ComponentModel.Composition  
  
    2.  Microsoft.VisualStudio.Text.Logic  
  
    3.  Microsoft.VisualStudio.CoreUtility  
  
3.  Add the following <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directives.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  Declare a static class that contains the definitions.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  In this class, export a \<xref:Microsoft.VisualStudio.Utilities.ContentTypeDefinition*> named "hid" and declare its base definition to be "text".  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Linking a File Name Extension to a Content Type  
  
-   To map this content type to a file name extension, export a \<xref:Microsoft.VisualStudio.Utilities.FileExtensionToContentTypeDefinition*> that has the extension ".hid" and the content type "hid".  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Adding the Content Type to an Editor Export  
  
1.  Create an editor extension. For example, you can use the margin glyph extension described in [Walkthrough: Creating a Margin Glyph](../vs140/walkthrough--creating-a-margin-glyph.md).  
  
2.  Add the class you defined in this procedure.  
  
3.  When you export the extension class, add a \<xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute*> of type "hid" to it.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Editor Extension Points](../vs140/language-service-and-editor-extension-points.md)
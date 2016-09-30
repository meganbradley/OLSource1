---
title: "How to: Reference the Name or Location of the Project File"
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
  - "locations, referencing"
  - "locations"
  - "MSBuildProjectName property"
  - "MSBuild, referencing the project file"
  - "names, referencing"
  - "reserved properties"
  - "project files, referencing"
ms.assetid: c8fcc594-5d37-4e2e-b070-4d9c012043b5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Reference the Name or Location of the Project File
You can use the name or location of the project in the project file itself without having to create your own property. [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] provides reserved properties that reference the project file name and other properties related to the project. For more information on reserved properties, see [MSBuild Reserved Properties](../vs140/msbuild-reserved-and-well-known-properties.md).  
  
## Using the MSBuildProjectName Property  
 [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] provides some reserved properties that you can use in your project files without defining them each time. For example, the reserved property <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> provides a reference to the project file name.  
  
#### To use the MSBuildProjectName Property  
  
-   Reference the property in the project file with the $() notation, just as you would with any property. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 An advantage of using a reserved property is that any changes to the project file name are incorporated automatically. The next time that you build the project, the output file will have the new name with no further action required on your part.  
  
> [!NOTE]
>  Reserved properties cannot be redefined in the project file.  
  
## Example  
 The following example project file references the project name as a reserved property to specify the name for the output.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild](../vs140/msbuild.md)   
 [MSBuild Reserved Properties](../vs140/msbuild-reserved-and-well-known-properties.md)
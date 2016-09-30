---
title: "Project Element (Visual Studio Templates)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Project"
helpviewer_keywords: 
  - "Project element [Visual Studio Templates]"
  - "<Project> element [Visual Studio Templates]"
ms.assetid: 1da15ea6-26e2-462b-a03e-584ef4996579
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Project Element (Visual Studio Templates)
Specifies the files or directories to add to the project.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<Project>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required attribute.\<br />\<br /> Specifies the name of the project file in the template .zip file.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> A Boolean value that specifies whether the project file has parameter values that must be replaced when a project is created from the template. Default value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Specifies the name of the project file when a project is created from the template.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Specifies whether the project should be added to the current solution. If the value of custom parameter, "$*myCustomParameter*$" exists in the parameter replacement file, the project is created but not added as part of the currently open solution.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Folder](../vs140/folder-element--visual-studio-project-templates-.md)|Optional element.\<br />\<br /> Specifies a folder to add to the project.|  
|[ProjectItem](../vs140/projectitem-element--visual-studio-project-templates-.md)|Optional element.\<br />\<br /> Specifies a file to add to a project.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateContent](../vs140/templatecontent-element--visual-studio-templates-.md)|Required element.|  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an optional child element of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element is used to specifiy a project, and therefore, is only valid in project templates.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> elements can have [Folder](../vs140/folder-element--visual-studio-project-templates-.md) children elements or [ProjectItem](../vs140/projectitem-element--visual-studio-project-templates-.md) children elements, but not a mixture of both <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> children elements.  
  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] automatically renames the project file name based on the name entered by the user in the **New Project** dialog box. Use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attribute if you want to provide an alternate file name for project files created with the template.  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [ProjectItem Element (Visual Studio Project Templates)](../vs140/projectitem-element--visual-studio-project-templates-.md)   
 [Folder Element (Visual Studio Project Templates)](../vs140/folder-element--visual-studio-project-templates-.md)
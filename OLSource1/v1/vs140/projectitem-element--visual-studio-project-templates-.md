---
title: "ProjectItem Element (Visual Studio Project Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ProjectItem"
helpviewer_keywords: 
  - "ProjectItem element [Visual Studio project templates]"
  - "<ProjectItem> element [Visual Studio project templates]"
ms.assetid: 82879fbe-7756-42cd-9a07-c10edf5b4673
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ProjectItem Element (Visual Studio Project Templates)
Specifies a file that is included in the project template.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element accepts different attributes depending on whether the template is for a project or an item. This topic explains the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element for project templates. For an explanation of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element for item templates, see [ProjectItem Element (Visual Studio Item Templates)](../vs140/projectitem-element--visual-studio-item-templates-.md).  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<Project>  
 \<ProjectItem>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Specifies the name and path of the project item when a project is created from the template. This attribute is useful for creating a directory structure different from the directory structure in the template .zip file, or for using parameter replacement to create an item name.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> A Boolean value that specifies whether the item has parameter values that must be replaced when a project is created from the template. Default value is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> A Boolean value that specifies whether the item should be opened in its respective editor in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] when a project is created from the template.\<br />\<br /> The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attributes are ignored on an item with an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.\<br />\<br /> The default value is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> A Boolean value that specifies whether the item should be opened the Web browser when a project is created from the template.\<br />\<br /> Only HTML files and text files that are local to the project can be opened in the Web browser. External URLs cannot be opened with this attribute.\<br />\<br /> The default value is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> A Boolean value that specifies whether the item should be opened in the Help viewer when a project is created from the template.\<br />\<br /> Only HTML files and text files that are local to the project can be opened in the Help browser. External URLs cannot be opened with this attribute.\<br />\<br /> The default value is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Specifies a numeric value that represents the order that items will be opened in their respective editors. All values must be multiples of 10. Items with higher <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> values are opened first.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../vs140/project-element--visual-studio-templates-.md)|Specifies the files or directories to add to the project.|  
  
## Text Value  
 A text value is required.  
  
 A <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> that represents the name or path to a file in the template .zip file.  
  
## Remarks  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is an optional child of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> attribute can be used to create a directory structure different from the directory structure in the template .zip file. For example, if the file <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> exists in the root of the template .zip file, but you want the file to be placed in a directory named <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in all projects created from the template, you would use the following XML:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attribute can also be used to rename files that contain international characters in their filenames. For example, a template .zip file cannot contain file names with Unicode characters, so the file must be renamed before it can be compressed into a .zip file. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> attribute can be used to set the file name back to the original Unicode file name.  
  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> attribute can also be used to rename files with parameters. The following procedure explains how to rename the file <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, which exists in the root directory of the template .zip file, to a file name based on the project name.  
  
### To rename files with parameters  
  
1.  Use the following XML in the .vstemplate file:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  Open the project file (.vbproj for a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project) in a text editor or [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
3.  Locate the line in the project file that looks similar to the following XML:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  Replace the line of code with the following XML:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     When a project is created from this template, the file name will be based on the name the user entered in the **New Project** dialog box, with all unsafe characters and spaces removed. For more information, see [Template Parameters](../vs140/template-parameters.md).  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] application.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [Template Parameters](../vs140/template-parameters.md)   
 [ProjectItem Element (Visual Studio Templates)](../vs140/projectitem-element--visual-studio-item-templates-.md)
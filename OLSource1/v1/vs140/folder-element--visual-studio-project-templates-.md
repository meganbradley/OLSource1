---
title: "Folder Element (Visual Studio Project Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Folder"
helpviewer_keywords: 
  - "Folder element [Visual Studio project templates]"
ms.assetid: 558e3d41-0db5-4c44-82bb-6bb87892b093
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Folder Element (Visual Studio Project Templates)
Specifies a folder that will be added to the project.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<Project>  
 \<Folder>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required attribute.\<br />\<br /> The name of the project folder.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Specifies the name to give the folder when a project is created from the template. This attribute is useful for using parameter replacement to create a folder name or naming a folder with an international string that cannot be used directly in the .zip file.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Specifies a folder to add to the project. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> elements can contain child <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements.|  
|[ProjectItem](../vs140/projectitem-element--visual-studio-item-templates-.md)|Specifies a file to add to the project.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../vs140/project-element--visual-studio-templates-.md)|Optional child element of [TemplateContent](../vs140/templatecontent-element--visual-studio-templates-.md).|  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an optional child of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 You can use any of the following methods to to organize project items into folders in a template:  
  
-   Include the folders in the template .zip file, and add them to the project in the .vstemplate file by specifying the path to the file in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> elements, with no <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> elements. This is the recommended method. For example:  
  
     <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
-   Include the folders in the template .zip file, and add them to the project in the .vstemplate file with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> elements. For example:  
  
     <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
-   Do not include folders in the template .zip file, but add folders using the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> element. For example:  
  
     <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
## Example  
 The following example illustrates the metadata for a project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] Windows application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [ProjectItem Element (Visual Studio Templates)](../vs140/projectitem-element--visual-studio-item-templates-.md)
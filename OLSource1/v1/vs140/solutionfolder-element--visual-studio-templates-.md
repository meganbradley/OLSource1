---
title: "SolutionFolder Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#SolutionFolder"
helpviewer_keywords: 
  - "<SolutionFolder> element [Visual Studio Templates]"
  - "SolutionFolder element [Visual Studio Templates]"
ms.assetid: 963f0398-fb50-4d8e-879d-d48f8b7c6d80
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SolutionFolder Element (Visual Studio Templates)
Groups projects in multi-project templates.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<ProjectCollection>  
 \<SolutionFolder>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required attribute.\<br />\<br /> The name of the solution folder.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectTemplateLink](../vs140/projecttemplatelink-element--visual-studio-templates-.md)|Optional element.\<br />\<br /> Specifies the path to the .vstemplate file of one project in a multi-project template.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional element.\<br />\<br /> Groups projects in multi-project templates.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectCollection](../vs140/projectcollection-element--visual-studio-templates-.md)|Specifies the organization and contents of multi-project templates.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Groups projects in multi-project templates.|  
  
## Remarks  
 Multi-project templates act as containers for two or more projects. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element is used to organize the projects in the template into groups. The folders specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements are created as solution folders in the project in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For more information on multi-project templates, see [How to: Create Multi-Project Templates](../vs140/how-to--create-multi-project-templates.md).  
  
## Example  
 This example uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element to divide the multi-project template into two groups, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The template contains four projects, two of which are placed in each solution folder.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [How to: Create Multi-Project Templates](../vs140/how-to--create-multi-project-templates.md)
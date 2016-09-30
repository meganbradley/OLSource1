---
title: "ProjectCollection Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ProjectCollection"
helpviewer_keywords: 
  - "<ProjectCollection> element [Visual Studio Templates]"
  - "ProjectCollection element [Visual Studio Templates]"
ms.assetid: deb27180-2035-49ed-b835-c47bb3cd2f8f
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ProjectCollection Element (Visual Studio Templates)
Specifies the organization and contents of multi-project templates.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<ProjectCollection>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectTemplateLink](../vs140/projecttemplatelink-element--visual-studio-templates-.md)|Optional element.\<br />\<br /> Specifies a project in a multi-project template.|  
|[SolutionFolder](../vs140/solutionfolder-element--visual-studio-templates-.md)|Optional element.\<br />\<br /> Groups projects in multi-project templates.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateContent](../vs140/templatecontent-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Specifies the contents of the template.|  
  
## Remarks  
 Multi-project templates act as containers for two or more projects. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is used to specify the projects to contain in the template. For more information on multi-project templates, see [How to: Create Multi-Project Templates](../vs140/how-to--create-multi-project-templates.md).  
  
## Example  
 This example shows a simple multi-project root .vstemplate file. In this example, the template contains two projects, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute on the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element sets the name for [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to assign this project. If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute does not exist, the name of the .vstemplate file is used as the project name.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [How to: Create Multi-Project Templates](../vs140/how-to--create-multi-project-templates.md)
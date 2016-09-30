---
title: "CreateNewFolder Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#CreateNewFolder"
helpviewer_keywords: 
  - "CreateNewFolder element [Visual Studio project templates]"
ms.assetid: acef2016-4140-45d6-ace8-b8160eabd676
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# CreateNewFolder Element (Visual Studio Templates)
Determines whether to check that the target directory where the project is to be created does not exist. If the directory does exist, a fresh directory can be created for the project. This setting is typically overridden by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> registry flag (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) that all common project types use to determine whether to create a new project in a new directory.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<CreateNewFolder>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Type  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be either <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, indicating whether or not a new container folder should be created when a project is created from the template.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an optional element. The default value is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The value specified in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element is only honored by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] if the underlying project system supports it.  
  
## Example  
 The following code example specifies not to create a new folder when a project is created from the template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)
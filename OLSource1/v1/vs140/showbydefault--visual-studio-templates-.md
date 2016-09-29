---
title: "ShowByDefault (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ShowByDefault"
helpviewer_keywords: 
  - "<ShowByDefault> element [Visual Studio Templates]"
  - "ShowByDefault element [Visual Studio Templates]"
ms.assetid: 7be783f6-0ef6-42bc-924a-df9a2eba7781
caps.latest.revision: 11
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ShowByDefault (Visual Studio Templates)
If `false`, specifies that the template will only be displayed under the specified [TemplateGroupID](../vs140/templategroupid-element--visual-studio-templates-.md).  
  
 <VSTemplate\>  
 <TemplateData\>  
 <ShowByDefault\>  
  
## Syntax  
  
```  
<ShowByDefault> true/false </ShowByDefault>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be either `true` or `false`. If true, specifies that the template will be displayed for all project types. If false, the template will only be displayed under the specified `TemplateGroupID`.  
  
## Remarks  
 `ShowByDefault` is an optional element. The default value is `true`.  
  
## Example  
 The following example illustrates the metadata for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] template.  
  
```  
<VSTemplate Type="Project" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>My template</Name>  
        <Description>A basic template</Description>  
        <Icon>TemplateIcon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
        <ShowByDefault>false</ShowByDefault>  
    </TemplateData>  
    <TemplateContent>  
        <Project File="MyTemplate.csproj">  
            <ProjectItem>Form1.cs<ProjectItem>  
            <ProjectItem>Form1.Designer.cs</ProjectItem>  
            <ProjectItem>Program.cs</ProjectItem>  
            <ProjectItem>Properties\AssemblyInfo.cs</ProjectItem>  
            <ProjectItem>Properties\Resources.resx</ProjectItem>  
            <ProjectItem>Properties\Resources.Designer.cs</ProjectItem>  
            <ProjectItem>Properties\Settings.settings</ProjectItem>  
            <ProjectItem>Properties\Settings.Designer.cs</ProjectItem>  
        </Project>  
    </TemplateContent>  
</VSTemplate>  
```  
  
## See Also  
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [TemplateGroupID Element (Visual Studio Templates)](../vs140/templategroupid-element--visual-studio-templates-.md)
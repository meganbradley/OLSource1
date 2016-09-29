---
title: "VSTemplate Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#VSTemplate"
helpviewer_keywords: 
  - "VSTemplate element [Visual Studio project templates]"
ms.assetid: f8ac561b-3b0b-4246-9ec9-118d2447e9a9
caps.latest.revision: 24
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VSTemplate Element (Visual Studio Templates)
Contains all the metadata about the project template, item template, or starter kit.  
  
## Syntax  
  
```  
<VSTemplate Type="TemplateType" Version="x.x.x">  
    <TemplateData>    </TemplateData>  
    <TemplateContent>    </TemplateContent>  
    ...  
</VSTemplate>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Type`|Identifies the template as a project template or an item template. This attribute can have a value of `Project` or `Item`.|  
|`Version`|Specifies a version number for the template. Templates in [!INCLUDE[vs_dev10_long](../vs140/includes/vs_dev10_long_md.md)] and [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)] have a `Version` attribute value of `3.0.0`.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Required element.<br /><br /> Specifies data that categorizes the template, and defines how it displays in the **New Project** or **Add New Item** dialog box.|  
|[TemplateContent](../vs140/templatecontent-element--visual-studio-templates-.md)|Required element.<br /><br /> Specifies the contents of the template.|  
|[WizardExtension](../vs140/wizardextension-element--visual-studio-templates-.md)|Optional element.|  
|[WizardData](../vs140/wizarddata-element--visual-studio-templates-.md)|Optional element.|  
  
### Parent Elements  
 None.  
  
## Remarks  
 The `VSTemplate` element is the root element of .vstemplate files.  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] application.  
  
```  
<VSTemplate Type="Project" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>My template</Name>  
        <Description>A basic starter kit</Description>  
        <Icon>TemplateIcon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
    </TemplateData>  
    <TemplateContent>  
        <Project File="MyStarterKit.csproj">  
            <ProjectItem>Form1.cs</ProjectItem>  
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
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)
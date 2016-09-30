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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Identifies the template as a project template or an item template. This attribute can have a value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Specifies a version number for the template. Templates in [!INCLUDE[vs_dev10_long](../vs140/includes/vs_dev10_long_md.md)] and [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)] have a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Specifies data that categorizes the template, and defines how it displays in the **New Project** or **Add New Item** dialog box.|  
|[TemplateContent](../vs140/templatecontent-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Specifies the contents of the template.|  
|[WizardExtension](../vs140/wizardextension-element--visual-studio-templates-.md)|Optional element.|  
|[WizardData](../vs140/wizarddata-element--visual-studio-templates-.md)|Optional element.|  
  
### Parent Elements  
 None.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element is the root element of .vstemplate files.  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)
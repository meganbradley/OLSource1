---
title: "EnableLocationBrowseButton Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#EnableLocationBrowseButton"
helpviewer_keywords: 
  - "EnableLocationBrowseButton [Visual Studio project templates]"
ms.assetid: a12d10d8-af49-482a-af77-e084fd07a47d
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EnableLocationBrowseButton Element (Visual Studio Templates)
Specifies whether the **Browse** button is available in the **New Project** dialog box, so that users can easily modify the default directory where a new project is saved.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<EnableLocationBrowseButton>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
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
  
 The text must be either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, indicating whether or not to display the **Browse** button on the **New Project** dialog box.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an optional element. The default value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which displays the **Browse** button in the **New Project** dialog box.  
  
 In the **New Project** dialog box, the **Location** text box specifies the directory where a new project is saved. The **Browse** button helps you modify this directory by displaying the **Project Location** dialog box, which enables you to easily navigate to a different directory that is available from your computer, and then choose it as the directory where the new project is saved.  
  
## Example  
 The following example illustrates the metadata for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] Windows application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)
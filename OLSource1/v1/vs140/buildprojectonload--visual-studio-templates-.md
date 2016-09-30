---
title: "BuildProjectOnLoad (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#BuildOnLoad"
helpviewer_keywords: 
  - "<BuildOnLoad> element [Visual Studio Templates]"
  - "BuildOnLoad element [Visual Studio Templates]"
ms.assetid: 950f5fc1-d041-4090-9a5c-60844768a4cc
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BuildProjectOnLoad (Visual Studio Templates)
Specifies whether to build the project immediately after it's created.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<BuildProjectOnLoad>  
  
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
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, indicating whether to build the project immediately after it's created.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an optional attribute. The default value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the metadata for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [TemplateContent Element (Visual Studio Templates)](../vs140/templatecontent-element--visual-studio-templates-.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)
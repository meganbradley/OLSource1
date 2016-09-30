---
title: "Hidden Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Hidden"
helpviewer_keywords: 
  - "Hidden element [Visual Studio project template]"
ms.assetid: f37406b0-52e7-4f2c-aacf-bc8d7a4117b3
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Hidden Element (Visual Studio Templates)
Specifies whether the template appears in either the **New Project** or **Add New Item** dialog box.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<Hidden>  
  
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
  
 The text must be either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, indicating whether or not the template will appear in the **New Project** or **Add New Item** dialog boxes.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an optional element.  
  
 If specified, no other child elements of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element are required.  
  
## Example  
 The following example illustrates the metadata for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)
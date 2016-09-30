---
title: "ProjectSubType Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ProjectSubType"
helpviewer_keywords: 
  - "ProjectSubType element [Visual Studio Templates]"
  - "<ProjectSubType> element [Visual Studio Templates]"
ms.assetid: f6895cd4-3e95-4f0e-aa9e-8c7750f46ed4
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ProjectSubType Element (Visual Studio Templates)
Classifies the template into a subcategory of the value specified in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<ProjectSubType>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
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
  
 This value specifies the subcategory of the template.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an optional child element of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element provides a subcategory to the [ProjectType](../vs140/projecttype-element--visual-studio-templates-.md) element. This value can include:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>: Specifies that the template targets the [!INCLUDE[Compact](../vs140/includes/compact_md.md)] version 1.0.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>: Specifies that the tempalate targets the [!INCLUDE[Compact](../vs140/includes/compact_md.md)] version 2.0.  
  
 If a template contains a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element with a value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element specifies the programming language of the template. This element can have the following values:  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>: Specifies that the template creates a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] Web project or item.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>: Specifies that the template creates a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] Web project or item.  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] device application targeting the [!INCLUDE[Compact](../vs140/includes/compact_md.md)] version 2.0.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [ProjectType Element (Visual Studio Templates)](../vs140/projecttype-element--visual-studio-templates-.md)
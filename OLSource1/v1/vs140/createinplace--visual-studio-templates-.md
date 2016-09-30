---
title: "CreateInPlace (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#CreateInPlace"
helpviewer_keywords: 
  - "CreateInPlace element [Visual Studio Templates]"
  - "<CreateInPlace> element [Visual Studio Templates]"
ms.assetid: 420d46ea-2470-4da9-ad8e-95165588a920
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CreateInPlace (Visual Studio Templates)
Specifies whether to create the project and perform parameter replacement in the specified location, or perform parameter replacement in a temporary location and then save the project to the specified location.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<CreateInPlace>  
  
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
  
 The text must be either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the project is created and parameter replacement is performed in the location specified in the **New Project** dialog box. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, parameter replacement is performed in a temporary location and the project is then copied to the specified location.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is an optional element. The default value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the metadata for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)
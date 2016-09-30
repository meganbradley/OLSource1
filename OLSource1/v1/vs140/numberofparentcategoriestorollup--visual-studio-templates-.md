---
title: "NumberOfParentCategoriesToRollUp (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#NumberOfParentCategoriesToRollUp"
helpviewer_keywords: 
  - "NumberOfParentCategoriesToRollUp element [Visual Studio Templates]"
  - "<NumberOfParentCategoriesToRollUp> element [Visual Studio Templates]"
ms.assetid: 6f9d36f5-ae23-4a92-8132-b11799e2c21a
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NumberOfParentCategoriesToRollUp (Visual Studio Templates)
Specifies the number of parent categories that will display the template in the **New Project** dialog box.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<NumberOfParentCategoriesToRollUp>  
  
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
 An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value is required.  
  
 This value specifies the number of parent categories that will display the template in the **New Project** dialog box.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an optional element.  
  
## Example  
 This example illustrates the metadata for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] Windows application. If a template with this metadata is placed two folder levels below the top level [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] node, the template will appear in the top level node in the **New Project** dialog box. If the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not set, the template only appears in the node in which it is physically located.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)